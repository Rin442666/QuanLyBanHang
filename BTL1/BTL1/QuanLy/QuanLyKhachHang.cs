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
    public partial class QuanLyKhachHang : Form
    {
        SqlConnection conn;
        DataTable dtKhachHang;
        string action = "";
        public QuanLyKhachHang()
        {
            InitializeComponent();
            string connStr = ConfigurationManager.ConnectionStrings["QuanLyBanHangConnectionString"].ConnectionString;
            conn = new SqlConnection(connStr);
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            SetInputEnabled(false);
        }

        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
            dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);
            dgvKhachHang.DataSource = dtKhachHang;
        }

        private void SetInputEnabled(bool enable)
        {
            txtMaKH.Enabled = enable;
            txtTenKH.Enabled = enable;
            txtSDT.Enabled = enable;
            txtTongTieuDung.Enabled = enable;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ma = txtSearch.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhachHang WHERE MaKH LIKE @ma", conn);
            da.SelectCommand.Parameters.AddWithValue("@ma", "%" + ma + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKhachHang.DataSource = dt;

            SetInputEnabled(false);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtTongTieuDung.Text = row.Cells["TongTieuDung"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)this.ParentForm;
            mainForm.Home(true);
            this.Close();
        }
    }
}
