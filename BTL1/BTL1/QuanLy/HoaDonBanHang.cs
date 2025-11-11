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
    public partial class HoaDonBanHang : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        string action = "";
        string connStr;
        public HoaDonBanHang()
        {
            InitializeComponent();
            connStr = ConfigurationManager.ConnectionStrings["QuanLyBanHangConnectionString"].ConnectionString;
            conn = new SqlConnection(connStr);
        }
        private void HoaDonBanHang_Load(object sender, EventArgs e)
        {
            LoadData();
            SetInputEnabled(false);
            btnXemChiTiet.Enabled = false;
            dgvChiTietHDB.DataSource = null;
            pnTong.Visible = false;
            btnLuu.Visible = false;
        }

        private void LoadData()
        {
            try
            {
                da = new SqlDataAdapter("SELECT MaHDB as [Mã HĐB], MaKH as [Mã KH], NgayBan as [Ngày bán], MaNV as [Mã NV], TongTien as [Tổng tiền] FROM HoaDonBan", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgvHDB.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetInputEnabled(bool enable)
        {
            txtMaHDB.Enabled = enable;
            txtMaNV.Enabled = enable;
            dtpBan.Enabled = enable;
            txtMaKH.Enabled = enable;
        }

        private void dgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHDB.Rows[e.RowIndex];

                txtMaHDB.Text = row.Cells["Mã HĐB"].Value.ToString();
                txtMaNV.Text = row.Cells["Mã NV"].Value == DBNull.Value ? "" : row.Cells["Mã NV"].Value.ToString();
                txtMaKH.Text = row.Cells["Mã KH"].Value == DBNull.Value ? "" : row.Cells["Mã KH"].Value.ToString();

                if (row.Cells["Ngày bán"].Value != DBNull.Value)
                {
                    dtpBan.Value = Convert.ToDateTime(row.Cells["Ngày bán"].Value);
                }
                else
                {
                    dtpBan.Value = DateTime.Now;
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
                dgvChiTietHDB.DataSource = null;
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            string maHDN = txtMaHDB.Text;
            string query = "SELECT CT.MaHH as [Mã hàng], HH.TenHH as [Tên], HH.Gia as [Giá], CT.SLBan as [Số lượng], (CT.SLBan * HH.Gia) as [Thành tiền] FROM ChiTietHDB AS CT INNER JOIN HangHoa AS HH ON CT.MaHH = HH.MaHH WHERE CT.MaHDB = @MaHDB";
            SqlDataAdapter daChiTiet = new SqlDataAdapter(query, conn);
            daChiTiet.SelectCommand.Parameters.AddWithValue("@MaHDB", maHDN);
            pnTong.Visible = true;
            DataTable dtChiTiet = new DataTable();
            try
            {
                daChiTiet.Fill(dtChiTiet);
                dgvChiTietHDB.DataSource = dtChiTiet;

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
            string query = "SELECT MaHDB as [Mã HĐB], MaKH as [Mã KH], NgayBan as [Ngày bán], MaNV as [Mã NV], TongTien as [Tổng tiền] FROM HoaDonBan WHERE MaHDB LIKE @keyword OR MaNV LIKE @keyword";
            da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            dt = new DataTable();
            da.Fill(dt);
            dgvHDB.DataSource = dt;
        }

        private void XuatHoaDonRaExcel_Interop()
        {
            Excel.Application objApp = null;
            Excel.Workbook objWorkbook = null;
            Excel.Worksheet wsTongQuat = null;
            Excel.Worksheet wsChiTiet = null;
            string maHDB = txtMaHDB.Text.Trim();
            string maNV = txtMaNV.Text.Trim();
            string maKH = txtMaKH.Text.Trim();
            string ngayBan = dtpBan.Value.ToString("dd/MM/yyyy");
            if (string.IsNullOrEmpty(maHDB) || dgvChiTietHDB.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn và xem chi tiết trước khi xuất Excel.", "Cảnh báo");
                return;
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel Files|*.xlsx";
            saveFile.FileName = "HoaDonBan_" + maHDB + "_" + DateTime.Now.ToString("ddMMyyyy");
            if (saveFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
                objApp = new Excel.Application();
                objWorkbook = objApp.Workbooks.Add(Type.Missing);
                wsTongQuat = (Excel.Worksheet)objWorkbook.Sheets[1];
                wsTongQuat.Name = "ThongTinChung";
                wsTongQuat.Cells[1, 1] = "PHIẾU BÁN HÀNG";
                wsTongQuat.Range[wsTongQuat.Cells[1, 1], wsTongQuat.Cells[1, 3]].Merge();
                wsTongQuat.Cells[1, 1].Font.Bold = true;
                wsTongQuat.Cells[3, 1] = "Mã hóa đơn nhập:";
                wsTongQuat.Cells[3, 2] = maHDB;
                wsTongQuat.Cells[4, 1] = "Mã nhân viên:";
                wsTongQuat.Cells[4, 2] = maNV;
                wsTongQuat.Cells[5, 1] = "Mã khách hàng:";
                wsTongQuat.Cells[5, 2] = maKH;
                wsTongQuat.Cells[6, 1] = "Ngày bán:";
                wsTongQuat.Cells[6, 2] = ngayBan;
                wsTongQuat.Columns.AutoFit();
                objWorkbook.Sheets.Add(After: objWorkbook.Sheets[objWorkbook.Sheets.Count]);
                wsChiTiet = (Excel.Worksheet)objWorkbook.Sheets[objWorkbook.Sheets.Count];
                wsChiTiet.Name = "ChiTietHoaDon";
                int rowStart = 1;
                for (int i = 0; i < dgvChiTietHDB.Columns.Count; i++)
                {
                    wsChiTiet.Cells[rowStart, i + 1] = dgvChiTietHDB.Columns[i].HeaderText;
                    wsChiTiet.Cells[rowStart, i + 1].Font.Bold = true;
                }
                int dataRowCount = dgvChiTietHDB.Rows.Count;
                for (int i = 0; i < dgvChiTietHDB.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvChiTietHDB.Columns.Count; j++)
                    {
                        object value = dgvChiTietHDB.Rows[i].Cells[j].Value;
                        if (value != null)
                        {
                            wsChiTiet.Cells[i + rowStart + 1, j + 1] = value.ToString();
                        }
                    }
                }
                int totalRow = rowStart + dataRowCount + 1;
                int thanhTienColIndex = -1;
                for (int i = 0; i < dgvChiTietHDB.Columns.Count; i++)
                {
                    if (dgvChiTietHDB.Columns[i].HeaderText == "Thành tiền")
                    {
                        thanhTienColIndex = i + 1; 
                        break;
                    }
                }

                if (thanhTienColIndex > 0)
                {
                    wsChiTiet.Cells[totalRow, 1] = "Tổng cộng:";
                    wsChiTiet.Cells[totalRow, 1].Font.Bold = true;
                    decimal tongTienValue;
                    if (decimal.TryParse(txtTongTien.Text.Replace(",", ""), out tongTienValue))
                    {
                        wsChiTiet.Cells[totalRow, thanhTienColIndex] = tongTienValue;
                        wsChiTiet.Cells[totalRow, thanhTienColIndex].NumberFormat = "#,##0";
                    }
                    else
                    {
                        wsChiTiet.Cells[totalRow, thanhTienColIndex] = txtTongTien.Text;
                    }

                    wsChiTiet.Cells[totalRow, thanhTienColIndex].Font.Bold = true;
                }
                wsChiTiet.Columns.AutoFit();
                objWorkbook.SaveAs(saveFile.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
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
                if (wsChiTiet != null) Marshal.ReleaseComObject(wsChiTiet);
                if (wsTongQuat != null) Marshal.ReleaseComObject(wsTongQuat);
                if (objWorkbook != null) Marshal.ReleaseComObject(objWorkbook);
                if (objApp != null) Marshal.ReleaseComObject(objApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            XuatHoaDonRaExcel_Interop();
        }

        private string GetNewMaHD()
        {
            string newMa = "HDB01";
            string query = "SELECT TOP 1 MaHDB FROM HoaDonBan ORDER BY MaHDB DESC";
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
            string maHDBMoi = GetNewMaHD();
            addHDB dialogChonHang = new addHDB(maHDBMoi, connStr);
            DialogResult result = dialogChonHang.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadData();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtMaKH.Text))
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
                "INSERT INTO HoaDonBan (MaHDB, NgayBan, MaNV, MaKH) VALUES (@MaHDB, @NgayBan, @MaNV, @MaKH)", conn);
            cmd.Parameters.AddWithValue("@MaHDB", txtMaHDB.Text.Trim());
            cmd.Parameters.AddWithValue("@NgayBan", dtpBan.Value);
            cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Thêm hóa đơn bán thành công!");
            btnLuu.Visible = false;
            LoadData();
        }
    }
}
