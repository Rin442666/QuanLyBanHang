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
using System.Configuration; // Đừng quên thêm Reference này

namespace BTL1
{
    // Đổi tên class "addHDN" cho đúng chuẩn C#
    public partial class addHDN : Form
    {
        string connStr;
        string maHDNMoi;
        DataTable dtGioHang; // Data cho dgvHoaDon (Giỏ hàng - BÊN PHẢI)
        DataTable dtHangCu;  // Data cho dgvHangCu (Hàng có sẵn - BÊN TRÁI)

        public addHDN(string maHDN, string connectionString)
        {
            InitializeComponent();
            this.maHDNMoi = maHDN;
            this.connStr = connectionString;
        }

        private void addHDN_Load(object sender, EventArgs e)
        {
            this.Text = "Tạo Hóa Đơn Nhập: " + maHDNMoi;

            SetupGioHang();
            LoadHangCu();
        }
        private void LoadHangCu()
        {
            try
            {
                string query = "SELECT MaHH, TenHH, DonVi, Gia FROM HangHoa";
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    dtHangCu = new DataTable();
                    da.Fill(dtHangCu);
                    dgvHangCu.DataSource = dtHangCu;
                    if (dgvHangCu.Columns["Gia"] != null)
                        dgvHangCu.Columns["Gia"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách hàng cũ: " + ex.Message); }
        }

        /// <summary>
        /// Cấu hình DataTable cho "Giỏ hàng" (dgvHoaDon - Lưới bên phải)
        /// </summary>
        private void SetupGioHang()
        {
            dtGioHang = new DataTable();
            dtGioHang.Columns.Add("MaHH", typeof(string));
            dtGioHang.Columns.Add("TenHH", typeof(string));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("Gia", typeof(decimal)); // Giá này là Giá Nhập
            dtGioHang.Columns.Add("ThanhTien", typeof(decimal), "SoLuong * Gia"); // Cột tự tính

            dgvHoaDon.DataSource = dtGioHang;
        }

        // ==========================================
        // CÁC NÚT CHỨC NĂNG (BÊN TRÁI - TOP)
        // ==========================================

        /// <summary>
        /// Nút "Thêm": Thêm hàng từ Tab đang chọn vào Giỏ hàng (lưới phải)
        /// </summary>
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy số lượng chung
            int soLuong = (int)nudSoLuong.Value;
            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.");
                return;
            }

            // Xử lý tùy theo Tab đang được chọn
            if (tabControl1.SelectedTab == tabHangCu)
            {
                // 1. Lấy hàng từ Tab HÀNG CŨ
                if (dgvHangCu.CurrentRow == null) return;

                DataGridViewRow row = dgvHangCu.CurrentRow;
                string maHH = row.Cells["MaHH"].Value.ToString();
                string tenHH = row.Cells["TenHH"].Value.ToString();
                decimal gia = Convert.ToDecimal(row.Cells["Gia"].Value); // Lấy giá ẩn

                ThemDongVaoGioHang(maHH, tenHH, soLuong, gia);
            }
            else if (tabControl1.SelectedTab == tabHangMoi)
            {
                // 2. Lấy hàng từ Tab HÀNG MỚI
                string maHH = txtMaHH_Moi.Text.Trim();
                string tenHH = txtTenHH_Moi.Text.Trim();
                string donVi = txtDonVi_Moi.Text.Trim();

                decimal gia = 0;
                if (!decimal.TryParse(txtGia_Moi.Text, out gia) || gia <= 0)
                {
                    MessageBox.Show("Vui lòng nhập giá hợp lệ.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(maHH) || string.IsNullOrWhiteSpace(tenHH))
                {
                    MessageBox.Show("Vui lòng nhập đủ Mã và Tên hàng mới.");
                    return;
                }

                // BƯỚC QUAN TRỌNG: Phải tạo hàng mới này trong CSDL TRƯỚC
                if (!TaoHangHoaMoi(maHH, tenHH, donVi, gia))
                {
                    // Nếu tạo thất bại (ví dụ trùng Mã), dừng lại
                    return;
                }

                // Nếu tạo thành công, thêm vào giỏ hàng
                ThemDongVaoGioHang(maHH, tenHH, soLuong, gia);

                // Làm mới Tab 1 (để hàng mới xuất hiện) và xóa Tab 2
                LoadHangCu();
                txtMaHH_Moi.Clear(); txtTenHH_Moi.Clear();
                txtDonVi_Moi.Clear(); txtGia_Moi.Clear();
            }
        }

        /// <summary>
        /// Nút "Xóa": Xóa hàng đang chọn khỏi Giỏ hàng (lưới phải)
        /// </summary>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hàng trong Hóa Đơn (bên phải) để xóa.");
                return;
            }

            // Xóa dòng khỏi DataTable
            int selectedIndex = dgvHoaDon.CurrentRow.Index;
            dtGioHang.Rows[selectedIndex].Delete();

            CapNhatTongTien();
        }

        /// <summary>
        /// Nút "Hủy Hóa Đơn": Thoát Form
        /// </summary>
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        /// <summary>
        /// Nút "Xác Nhận": Lưu Hóa đơn và Chi tiết vào CSDL
        /// </summary>
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống. Không thể lưu.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Nhân Viên.");
                txtMaNV.Focus();
                return;
            }

            // Bắt đầu Transaction (Đảm bảo an toàn dữ liệu)
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // 1. Tạo Hóa Đơn Nhập (Header)
                    // Trigger của bạn sẽ tự tính TongTien sau
                    string qHD = "INSERT INTO HoaDonNhap (MaHDN, NgayNhap, MaNV, TongTien) VALUES (@Ma, @Ngay, @NV, NULL)";
                    using (SqlCommand cmdHD = new SqlCommand(qHD, conn, trans))
                    {
                        cmdHD.Parameters.AddWithValue("@Ma", maHDNMoi);
                        cmdHD.Parameters.AddWithValue("@Ngay", dtpNgayNhap.Value);
                        cmdHD.Parameters.AddWithValue("@NV", txtMaNV.Text.Trim());
                        cmdHD.ExecuteNonQuery();
                    }

                    // 2. Lưu chi tiết (Loop) VÀ Cập nhật kho
                    string qCT = "INSERT INTO ChiTietHDN (MaHDN, MaHH, SLNhap, Gia) VALUES (@MaHD, @MaHH, @SL, @Gia)";
                    string qKho = "UPDATE HangHoa SET SLTon = SLTon + @SL WHERE MaHH = @MaHH"; // CỘNG kho

                    foreach (DataRow row in dtGioHang.Rows)
                    {
                        // Lệnh 1: Insert vào ChiTietHDN
                        using (SqlCommand cmdCT = new SqlCommand(qCT, conn, trans))
                        {
                            cmdCT.Parameters.AddWithValue("@MaHD", maHDNMoi);
                            cmdCT.Parameters.AddWithValue("@MaHH", row["MaHH"]);
                            cmdCT.Parameters.AddWithValue("@SL", row["SoLuong"]);
                            cmdCT.Parameters.AddWithValue("@Gia", row["Gia"]); // Dùng giá nhập từ giỏ hàng
                            cmdCT.ExecuteNonQuery();
                        }

                        // Lệnh 2: Cập nhật (CỘNG) số lượng tồn kho
                        using (SqlCommand cmdKho = new SqlCommand(qKho, conn, trans))
                        {
                            cmdKho.Parameters.AddWithValue("@SL", row["SoLuong"]);
                            cmdKho.Parameters.AddWithValue("@MaHH", row["MaHH"]);
                            cmdKho.ExecuteNonQuery();
                        }
                    }

                    // Nếu mọi thứ OK, xác nhận
                    trans.Commit();
                    MessageBox.Show("Tạo hóa đơn nhập " + maHDNMoi + " thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (SqlException ex)
                {
                    trans.Rollback(); // Hủy bỏ mọi thay đổi nếu có lỗi
                    if (ex.Number == 547) // Lỗi khóa ngoại
                        MessageBox.Show("Lỗi: Mã Nhân Viên không tồn tại. Vui lòng kiểm tra lại.");
                    else
                        MessageBox.Show("Lỗi CSDL: " + ex.Message);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                }
            } // 'using' tự động đóng kết nối
        }

        // ==========================================
        // CÁC HÀM HỖ TRỢ (PRIVATE)
        // ==========================================

        /// <summary>
        /// Logic thêm hàng mới vào CSDL (Bảng HangHoa)
        /// </summary>
        private bool TaoHangHoaMoi(string ma, string ten, string donvi, decimal gia)
        {
            // (Giá nhập = Giá bán, SLTon ban đầu = 0)
            string query = "INSERT INTO HangHoa (MaHH, TenHH, DonVi, Gia, SLTon) VALUES (@Ma, @Ten, @DonVi, @Gia, 0)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ma", ma);
                    cmd.Parameters.AddWithValue("@Ten", ten);
                    cmd.Parameters.AddWithValue("@DonVi", donvi);
                    cmd.Parameters.AddWithValue("@Gia", gia);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true; // Thành công
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Lỗi Trùng Khóa Chính (Primary Key)
                    MessageBox.Show("Mã Hàng Hóa '" + ma + "' đã tồn tại. Vui lòng chọn mã khác.");
                else
                    MessageBox.Show("Lỗi CSDL khi tạo hàng mới: " + ex.Message);
                return false; // Thất bại
            }
        }

        /// <summary>
        /// Logic trung tâm để thêm 1 dòng vào Giỏ hàng (lưới phải)
        /// </summary>
        private void ThemDongVaoGioHang(string maHH, string tenHH, int soLuong, decimal gia)
        {
            // Kiểm tra xem hàng đã có trong giỏ chưa
            DataRow existingRow = dtGioHang.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaHH") == maHH);

            if (existingRow != null)
            {
                // Nếu có rồi -> Cập nhật số lượng
                existingRow["SoLuong"] = existingRow.Field<int>("SoLuong") + soLuong;
            }
            else
            {
                // Nếu chưa có -> Thêm dòng mới
                dtGioHang.Rows.Add(maHH, tenHH, soLuong, gia);
            }

            CapNhatTongTien();
        }

        /// <summary>
        /// Tính và cập nhật Label Tổng tiền
        /// </summary>
        private void CapNhatTongTien()
        {
            object sumObject = dtGioHang.Compute("SUM(ThanhTien)", string.Empty);

            if (sumObject != DBNull.Value)
            {
                lblTongTien.Text = "Tổng tiền: " + Convert.ToDecimal(sumObject).ToString("N0") + " VND";
            }
            else
            {
                lblTongTien.Text = "Tổng tiền: 0 VND";
            }
        }
    }
}