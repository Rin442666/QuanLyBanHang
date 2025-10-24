using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void LoadData()
        {
            try
            {
                da = new SqlDataAdapter("SELECT MaHDN, NgayNhap, MaNV, TongTien FROM HoaDonNhap", conn);
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

                txtMaHDN.Text = row.Cells["MaHDN"].Value.ToString();
                txtMaNV.Text = row.Cells["MaNV"].Value == DBNull.Value ? "" : row.Cells["MaNV"].Value.ToString();

                if (row.Cells["NgayNhap"].Value != DBNull.Value)
                {
                    dtpNhap.Value = Convert.ToDateTime(row.Cells["NgayNhap"].Value);
                }
                else
                {
                    dtpNhap.Value = DateTime.Now;
                }

                if (row.Cells["TongTien"].Value != DBNull.Value)
                {
                    decimal tongTien = Convert.ToDecimal(row.Cells["TongTien"].Value);
                    txtTongTien.Text = tongTien.ToString("N0");
                }
                else
                {
                    txtTongTien.Text = "0";
                }

                btnXemChiTiet.Enabled = true;
                dgvChiTietHDN.DataSource = null;
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            string maHDN = txtMaHDN.Text;

            string query = "SELECT MaHH, SLNhap, Gia, (SLNhap * Gia) AS ThanhTien FROM ChiTietHDN WHERE MaHDN = @MaHDN";

            SqlDataAdapter daChiTiet = new SqlDataAdapter(query, conn);
            daChiTiet.SelectCommand.Parameters.AddWithValue("@MaHDN", maHDN);

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
            string query = "SELECT MaHDN, NgayNhap, MaNV, TongTien FROM HoaDonNhap WHERE MaHDN LIKE @keyword OR MaNV LIKE @keyword";

            da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            dt = new DataTable();
            da.Fill(dt);
            dgvHDN.DataSource = dt;
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {

        }

        private void btnInHD_Click(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)this.ParentForm;
            mainForm.Home(true);
            this.Close();
        }
    }
}
