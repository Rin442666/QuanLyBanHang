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
            // 1. Tải danh sách hàng hóa có sẵn
            LoadDanhSachHang();

            // 2. Chuẩn bị "Giỏ hàng" (dgvGioHang)
            dtGioHang = new DataTable();
            dtGioHang.Columns.Add("MaHH", typeof(string));
            dtGioHang.Columns.Add("TenHH", typeof(string));
            dtGioHang.Columns.Add("Gia", typeof(decimal));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("ThanhTien", typeof(decimal), "Gia * SoLuong"); // Cột tự tính toán

            dgvGioHang.DataSource = dtGioHang;
        }

        /// <FORM_LOGIC>
        /// Tải tất cả hàng hóa từ CSDL vào lưới bên trái
        /// </summary>
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

        /// <summary>
        /// Nút "Thêm ->" (Thêm hàng từ lưới trái sang lưới phải)
        /// </summary>
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

            // Kiểm tra xem hàng đã có trong giỏ chưa
            DataRow existingRow = dtGioHang.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaHH") == maHH);

            if (existingRow != null)
            {
                // Nếu đã có, chỉ cập nhật số lượng
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
                // Nếu chưa có, thêm dòng mới
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

            // Xóa dòng khỏi DataTable
            int selectedIndex = dgvGioHang.CurrentRow.Index;
            dtGioHang.Rows[selectedIndex].Delete();

            CapNhatTongTien();
        }

        /// <summary>
        /// Tính tổng tiền từ dgvGioHang và cập nhật Label
        /// </summary>
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

        /// <summary>
        /// Nút "Hủy bỏ"
        /// </summary>
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Nút "Xác nhận & Lưu" (Logic chính)
        /// </summary>
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra thông tin
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

            // 2. Bắt đầu Transaction (Quan trọng: Nếu 1 lệnh lỗi, tất cả sẽ bị hủy)
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 3. LƯU HÓA ĐƠN (SHELL)
                    // (Lưu ý: TongTien = NULL, vì Trigger trg_CapNhatTongT sẽ tự tính)
                    string queryHD = "INSERT INTO HoaDonBan (MaHDB, NgayBan, MaNV, MaKH, TongTien) VALUES (@MaHDB, @NgayBan, @MaNV, @MaKH, NULL)";
                    using (SqlCommand cmdHD = new SqlCommand(queryHD, conn, transaction))
                    {
                        cmdHD.Parameters.AddWithValue("@MaHDB", this.maHDBMoi);
                        cmdHD.Parameters.AddWithValue("@NgayBan", DateTime.Now);
                        cmdHD.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                        cmdHD.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());
                        cmdHD.ExecuteNonQuery();
                    }

                    // 4. LƯU CHI TIẾT HÓA ĐƠN (LOOP)
                    string queryCT = "INSERT INTO ChiTietHDB (MaHDB, MaHH, SLBan) VALUES (@MaHDB, @MaHH, @SLBan)";
                    foreach (DataRow row in dtGioHang.Rows)
                    {
                        using (SqlCommand cmdCT = new SqlCommand(queryCT, conn, transaction))
                        {
                            cmdCT.Parameters.AddWithValue("@MaHDB", this.maHDBMoi);
                            cmdCT.Parameters.AddWithValue("@MaHH", row["MaHH"].ToString());
                            cmdCT.Parameters.AddWithValue("@SLBan", Convert.ToInt32(row["SoLuong"]));
                            cmdCT.ExecuteNonQuery();
                        }
                    }

                    // 5. Nếu mọi thứ thành công, xác nhận transaction
                    transaction.Commit();
                    MessageBox.Show("Tạo hóa đơn " + this.maHDBMoi + " thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (SqlException ex)
                {
                    // 6. Nếu có lỗi, HỦY BỎ transaction
                    transaction.Rollback();
                    if (ex.Number == 547) // Lỗi Foreign Key
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