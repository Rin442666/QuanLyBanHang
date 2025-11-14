using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL1
{
    public partial class addHDB : Form
    {
        string connStr;
        string maHDBMoi;
        DataTable dtGioHang;

        public addHDB(string maHDB, string connectionString)
        {
            InitializeComponent();
            this.connStr = connectionString;
            this.maHDBMoi = maHDB;
        }

        private void addHDN_Load(object sender, EventArgs e)
        {
            LoadDanhSachHang();

            dtGioHang = new DataTable();
            dtGioHang.Columns.Add("MaHH", typeof(string));
            dtGioHang.Columns.Add("TenHH", typeof(string));
            dtGioHang.Columns.Add("Gia", typeof(decimal));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("ThanhTien", typeof(decimal), "Gia * SoLuong");

            dgvGioHang.DataSource = dtGioHang;
        }

        private void LoadDanhSachHang()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT MaHH, TenHH, Gia, SLTon FROM HangHoa WHERE SLTon > 0", conn))
                {
                    DataTable dtHang = new DataTable();
                    da.Fill(dtHang);
                    dgvDanhSachHang.DataSource = dtHang;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hàng hóa: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng từ danh sách bên trái.");
                return;
            }

            DataGridViewRow selectedRow = dgvDanhSachHang.CurrentRow;
            string maHH = selectedRow.Cells["MaHH"].Value.ToString();
            string tenHH = selectedRow.Cells["TenHH"].Value.ToString();
            decimal gia = Convert.ToDecimal(selectedRow.Cells["Gia"].Value);
            int slTon = Convert.ToInt32(selectedRow.Cells["SLTon"].Value);
            int slMua = (int)nudSoLuong.Value;

            if (slMua <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.");
                return;
            }

            if (slMua > slTon)
            {
                MessageBox.Show($"Số lượng tồn kho không đủ (Chỉ còn {slTon}).");
                return;
            }

            DataRow existingRow = dtGioHang.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaHH") == maHH);

            if (existingRow != null)
            {
                int slMoi = existingRow.Field<int>("SoLuong") + slMua;
                if (slMoi > slTon)
                {
                    MessageBox.Show($"Tổng số lượng vượt quá tồn kho (Đã có {existingRow.Field<int>("SoLuong")} trong giỏ, chỉ còn {slTon}).");
                    return;
                }
                existingRow["SoLuong"] = slMoi;
            }
            else
            {
                dtGioHang.Rows.Add(maHH, tenHH, gia, slMua);
            }

            CapNhatTongTien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng từ giỏ hàng bên phải.");
                return;
            }

            int selectedIndex = dgvGioHang.CurrentRow.Index;
            dtGioHang.Rows[selectedIndex].Delete();

            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            if (dtGioHang.Rows.Count > 0)
            {
                decimal tongTien = Convert.ToDecimal(dtGioHang.Compute("SUM(ThanhTien)", string.Empty));
                lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + " VND";
            }
            else
            {
                lblTongTien.Text = "Tổng tiền: 0 VND";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã nhân viên và Mã khách hàng.");
                return;
            }
            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống. Vui lòng thêm sản phẩm.");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string queryHD = "INSERT INTO HoaDonBan (MaHDB, NgayBan, MaNV, MaKH, TongTien) VALUES (@MaHDB, @NgayBan, @MaNV, @MaKH, NULL)";
                    using (SqlCommand cmdHD = new SqlCommand(queryHD, conn, transaction))
                    {
                        cmdHD.Parameters.AddWithValue("@MaHDB", this.maHDBMoi);
                        cmdHD.Parameters.AddWithValue("@NgayBan", DateTime.Now);
                        cmdHD.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                        cmdHD.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());
                        cmdHD.ExecuteNonQuery();
                    }
                    string queryCT = "INSERT INTO ChiTietHDB (MaHDB, MaHH, SLBan) VALUES (@MaHDB, @MaHH, @SLBan)";
                    string queryUpdateKho = "UPDATE HangHoa SET SLTon = SLTon - @SLBan WHERE MaHH = @MaHH";
                    foreach (DataRow row in dtGioHang.Rows)
                    {
                        int slBan = Convert.ToInt32(row["SoLuong"]);
                        string maHH = row["MaHH"].ToString();

                        using (SqlCommand cmdCT = new SqlCommand(queryCT, conn, transaction))
                        {
                            cmdCT.Parameters.AddWithValue("@MaHDB", this.maHDBMoi);
                            cmdCT.Parameters.AddWithValue("@MaHH", maHH);
                            cmdCT.Parameters.AddWithValue("@SLBan", slBan);
                            cmdCT.ExecuteNonQuery();
                        }
                        using (SqlCommand cmdKho = new SqlCommand(queryUpdateKho, conn, transaction))
                        {
                            cmdKho.Parameters.AddWithValue("@SLBan", slBan);
                            cmdKho.Parameters.AddWithValue("@MaHH", maHH);
                            cmdKho.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Tạo hóa đơn " + this.maHDBMoi + " thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Lỗi: Mã Nhân viên hoặc Mã Khách hàng không tồn tại. Vui lòng kiểm tra lại.", "Lỗi Khóa Ngoại");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi CSDL khi lưu hóa đơn: " + ex.Message, "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi");
                }
            }
        }
    }
}