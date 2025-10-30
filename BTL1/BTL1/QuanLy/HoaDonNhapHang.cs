using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BTL1
{
    public partial class HoaDonNhapHang : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        string action = "";
        string connStr;

        public HoaDonNhapHang()
        {
            InitializeComponent();
            connStr = ConfigurationManager.ConnectionStrings["QuanLyBanHangConnectionString"].ConnectionString;
            conn = new SqlConnection(connStr);
        }

        private void HoaDonNhapHang_Load(object sender, EventArgs e)
        {
            LoadData();
            SetInputEnabled(false);
            btnXemChiTiet.Enabled = false;
            dgvChiTietHDN.DataSource = null;
            pnTong.Visible = false;
            btnLuu.Visible = false;
        }

        private void LoadData()
        {
            try
            {
                da = new SqlDataAdapter("SELECT MaHDN as[Mã HĐN], NgayNhap as[Ngày nhập], MaNV as[Mã NV], TongTien as[Tổng tiền] FROM HoaDonNhap", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvHDN.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetInputEnabled(bool enable)
        {
            txtMaHDN.Enabled = enable;
            txtMaNV.Enabled = enable;
            dtpNhap.Enabled = enable;
        }

        private void dgvHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHDN.Rows[e.RowIndex];

                txtMaHDN.Text = row.Cells["Mã HĐN"].Value.ToString();
                txtMaNV.Text = row.Cells["Mã NV"].Value == DBNull.Value ? "" : row.Cells["Mã NV"].Value.ToString();

                if (row.Cells["Ngày nhập"].Value != DBNull.Value)
                {
                    dtpNhap.Value = Convert.ToDateTime(row.Cells["Ngày nhập"].Value);
                }
                else
                {
                    dtpNhap.Value = DateTime.Now;
                }

                if (row.Cells["Tổng tiền"].Value != DBNull.Value)
                {   
                    decimal tongTien = Convert.ToDecimal(row.Cells["Tổng tiền"].Value);
                    txtTongTien.Text = tongTien.ToString("N0");
                }
                else
                {
                    txtTongTien.Text = "0";
                }

                pnTong.Visible = false;
                btnXemChiTiet.Enabled = true;
                dgvChiTietHDN.DataSource = null;
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            string maHDN = txtMaHDN.Text;
            string query = "SELECT CT.MaHH as [Mã hàng], HH.TenHH as [Tên], HH.Gia as [Giá], CT.SLNhap as [Số lượng], (CT.SLNhap * HH.Gia) as [Thành tiền] FROM ChiTietHDN AS CT INNER JOIN HangHoa AS HH ON CT.MaHH = HH.MaHH WHERE CT.MaHDN = @MaHDN";


            SqlDataAdapter daChiTiet = new SqlDataAdapter(query, conn);
            daChiTiet.SelectCommand.Parameters.AddWithValue("@MaHDN", maHDN);
            pnTong.Visible = true;

            DataTable dtChiTiet = new DataTable();

            try
            {
                daChiTiet.Fill(dtChiTiet);
                dgvChiTietHDN.DataSource = dtChiTiet;

                if (dtChiTiet.Rows.Count == 0)
                {
                    MessageBox.Show("Hóa đơn này không có chi tiết.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            string query = "SELECT MaHDN as[Mã HĐN], NgayNhap as[Ngày nhập], MaNV as[Mã NV], TongTien as[Tổng tiền] FROM HoaDonNhap WHERE MaHDN LIKE @keyword OR MaNV LIKE @keyword";

            da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            dt = new DataTable();
            da.Fill(dt);
            dgvHDN.DataSource = dt;
        }

        private string GetNewMaHD()
        {
            string newMa = "HDN01";
            string query = "SELECT TOP 1 MaHDN FROM HoaDonNhap ORDER BY MaHDN DESC";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    object result = cmd.ExecuteScalar();
                    conn.Close();

                    if (result != null)
                    {
                        string lastMa = result.ToString();
                        string prefix = lastMa.Substring(0, 3);
                        int number = int.Parse(lastMa.Substring(3));
                        newMa = prefix + (number + 1).ToString("D2");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tạo mã hóa đơn mới: " + ex.Message, "Lỗi");
                }
            }
            return newMa;
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            txtMaHDN.Text = GetNewMaHD();
            txtMaNV.Enabled = true;
            txtMaNV.Text = "";
            txtTongTien.Text = "0";
            dtpNhap.Value = DateTime.Now;
            btnLuu.Visible = true;

            if (dgvChiTietHDN.DataSource is DataTable dtChiTiet)
            {
                dtChiTiet.Clear();
            }
            else
            {
                dgvChiTietHDN.DataSource = null;
            }
            txtMaNV.Focus();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hóa đơn!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO HoaDonNhap (MaHDN, NgayNhap, MaNV) VALUES (@MaHDN, @NgayNhap, @MaNV)", conn);
            cmd.Parameters.AddWithValue("@MaHDN", txtMaHDN.Text.Trim());
            cmd.Parameters.AddWithValue("@NgayNhap", dtpNhap.Value);
            cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Thêm hóa đơn nhập thành công!");
            btnLuu.Visible = false;
            LoadData();
        }

        private void XuatHoaDonRaExcel_Interop()
        {
            Excel.Application objApp = null;
            Excel.Workbook objWorkbook = null;
            Excel.Worksheet wsTongQuat = null;
            Excel.Worksheet wsChiTiet = null;

            // --- 1. Lấy dữ liệu cần thiết ---
            string maHDN = txtMaHDN.Text.Trim();
            string maNV = txtMaNV.Text.Trim();
            string ngayNhap = dtpNhap.Value.ToString("dd/MM/yyyy");

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(maHDN) || dgvChiTietHDN.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn và xem chi tiết trước khi xuất Excel.", "Cảnh báo");
                return;
            }

            // --- 2. Chọn nơi lưu file ---
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel Files|*.xlsx";
            saveFile.FileName = "HoaDonNhap_" + maHDN + "_" + DateTime.Now.ToString("ddMMyyyy");

            if (saveFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                // Khởi tạo Excel
                objApp = new Excel.Application();
                objWorkbook = objApp.Workbooks.Add(Type.Missing);

                // =======================================================
                // ========== Sheet 1: Thông tin chung Hóa đơn (HEADER) ==========
                // =======================================================

                wsTongQuat = (Excel.Worksheet)objWorkbook.Sheets[1];
                wsTongQuat.Name = "ThongTinChung";

                // Tiêu đề
                wsTongQuat.Cells[1, 1] = "PHIẾU NHẬP HÀNG";
                wsTongQuat.Range[wsTongQuat.Cells[1, 1], wsTongQuat.Cells[1, 3]].Merge();
                wsTongQuat.Cells[1, 1].Font.Bold = true;

                // Thông tin chung
                wsTongQuat.Cells[3, 1] = "Mã hóa đơn nhập:";
                wsTongQuat.Cells[3, 2] = maHDN;

                wsTongQuat.Cells[4, 1] = "Mã nhân viên:";
                wsTongQuat.Cells[4, 2] = maNV;

                wsTongQuat.Cells[5, 1] = "Ngày nhập:";
                wsTongQuat.Cells[5, 2] = ngayNhap;

                wsTongQuat.Columns.AutoFit();


                // =======================================================
                // ========== Sheet 2: Chi tiết Hóa đơn (DETAILS) ==========
                // =======================================================

                objWorkbook.Sheets.Add(After: objWorkbook.Sheets[objWorkbook.Sheets.Count]);
                wsChiTiet = (Excel.Worksheet)objWorkbook.Sheets[objWorkbook.Sheets.Count];
                wsChiTiet.Name = "ChiTietHoaDon";

                int rowStart = 1;

                // 1. Ghi tiêu đề cột
                for (int i = 0; i < dgvChiTietHDN.Columns.Count; i++)
                {
                    wsChiTiet.Cells[rowStart, i + 1] = dgvChiTietHDN.Columns[i].HeaderText;
                    wsChiTiet.Cells[rowStart, i + 1].Font.Bold = true;
                }

                // 2. Ghi dữ liệu chi tiết
                int dataRowCount = dgvChiTietHDN.Rows.Count;
                for (int i = 0; i < dgvChiTietHDN.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvChiTietHDN.Columns.Count; j++)
                    {
                        // Kiểm tra null để tránh lỗi Interop
                        object value = dgvChiTietHDN.Rows[i].Cells[j].Value;
                        if (value != null)
                        {
                            wsChiTiet.Cells[i + rowStart + 1, j + 1] = value.ToString();
                        }
                    }
                }

                // 1. Xác định vị trí dòng tổng cộng
                int totalRow = rowStart + dataRowCount + 1; // Hàng ngay sau hàng dữ liệu cuối cùng

                // 2. Tìm chỉ số cột Thành tiền (Dựa trên HeaderText là "Thành tiền")
                int thanhTienColIndex = -1;
                for (int i = 0; i < dgvChiTietHDN.Columns.Count; i++)
                {
                    if (dgvChiTietHDN.Columns[i].HeaderText == "Thành tiền")
                    {
                        thanhTienColIndex = i + 1; // +1 vì Excel index bắt đầu từ 1
                        break;
                    }
                }

                if (thanhTienColIndex > 0)
                {
                    // 3. Ghi chữ "Tổng cộng" vào cột đầu tiên
                    wsChiTiet.Cells[totalRow, 1] = "Tổng cộng:";
                    wsChiTiet.Cells[totalRow, 1].Font.Bold = true;

                    // 4. Ghi giá trị Tổng tiền từ txtTongTien.Text
                    decimal tongTienValue;
                    // Cố gắng chuyển đổi chuỗi từ TextBox sang Decimal để đảm bảo Excel nhận giá trị số
                    if (decimal.TryParse(txtTongTien.Text.Replace(",", ""), out tongTienValue))
                    {
                        // Ghi giá trị số đã chuyển đổi vào ô Excel
                        wsChiTiet.Cells[totalRow, thanhTienColIndex] = tongTienValue;

                        // Định dạng tiền tệ cho ô tổng tiền
                        wsChiTiet.Cells[totalRow, thanhTienColIndex].NumberFormat = "#,##0";
                    }
                    else
                    {
                        // Nếu không chuyển đổi được (ví dụ: định dạng lỗi), ghi nguyên chuỗi
                        wsChiTiet.Cells[totalRow, thanhTienColIndex] = txtTongTien.Text;
                    }

                    wsChiTiet.Cells[totalRow, thanhTienColIndex].Font.Bold = true;
                }

                // Tự động điều chỉnh độ rộng cột
                wsChiTiet.Columns.AutoFit();

                // --- 3. Lưu và Đóng ---
                objWorkbook.SaveAs(saveFile.FileName, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                objWorkbook.Close(false, Type.Missing, Type.Missing);
                objApp.Quit();

                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // --- 4. Giải phóng các đối tượng COM (RẤT QUAN TRỌNG) ---
                if (wsChiTiet != null) Marshal.ReleaseComObject(wsChiTiet);
                if (wsTongQuat != null) Marshal.ReleaseComObject(wsTongQuat);
                if (objWorkbook != null) Marshal.ReleaseComObject(objWorkbook);
                if (objApp != null) Marshal.ReleaseComObject(objApp);

                // Ép buộc dọn dẹp bộ nhớ để giải phóng Excel process
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            XuatHoaDonRaExcel_Interop();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)this.ParentForm;
            mainForm.Home(true);
            this.Close();
        }

        
    }
}
