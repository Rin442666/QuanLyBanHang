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
        }

        private void LoadData()
        {
            try
            {
                da = new SqlDataAdapter("SELECT MaHDB, MaKH, NgayBan, MaNV, TongTien FROM HoaDonBan", conn);
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

                txtMaHDB.Text = row.Cells["MaHDB"].Value.ToString();
                txtMaNV.Text = row.Cells["MaNV"].Value == DBNull.Value ? "" : row.Cells["MaNV"].Value.ToString();
                txtMaKH.Text = row.Cells["MaKH"].Value == DBNull.Value ? "" : row.Cells["MaKH"].Value.ToString();

                if (row.Cells["NgayBan"].Value != DBNull.Value)
                {
                    dtpBan.Value = Convert.ToDateTime(row.Cells["NgayBan"].Value);
                }
                else
                {
                    dtpBan.Value = DateTime.Now;
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
                dgvChiTietHDB.DataSource = null;
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            string maHDN = txtMaHDB.Text;

            string query = "SELECT MaHDB, MaHH, SLBan FROM ChiTietHDB WHERE MaHDB = @MaHDB";

            SqlDataAdapter daChiTiet = new SqlDataAdapter(query, conn);
            daChiTiet.SelectCommand.Parameters.AddWithValue("@MaHDB", maHDN);

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
            string query = "SELECT MaHDB, MaKH, NgayBan, MaNV, TongTien FROM HoaDonBan WHERE MaHDB LIKE @keyword OR MaNV LIKE @keyword";

            da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            dt = new DataTable();
            da.Fill(dt);
            dgvHDB.DataSource = dt;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)this.ParentForm;
            mainForm.Home(true);
            this.Close();
        }
    }
}
