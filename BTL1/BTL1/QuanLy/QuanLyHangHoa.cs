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
    public partial class QuanLyHangHoa : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        string action = "";
        public QuanLyHangHoa()
        {
            InitializeComponent();
            string connStr = ConfigurationManager.ConnectionStrings["QuanLyBanHangConnectionString"].ConnectionString;
            conn = new SqlConnection(connStr);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)this.ParentForm;
            mainForm.Home(true);
            this.Close();
        }

        private void QuanLyHangHoa_Load(object sender, EventArgs e)
        {
            LoadData();
            SetInputEnabled(false);
            btnConfirm.Visible = false;
        }
        private void LoadData()
        {
            da = new SqlDataAdapter("SELECT * FROM HangHoa", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvHangHoa.DataSource = dt;
        }

        private void SetInputEnabled(bool enable)
        {
            txtMaHang.Enabled = enable;
            txtTenHang.Enabled = enable;
            txtDonGia.Enabled = enable;
            txtSoLuong.Enabled = enable;
            txtDonVi.Enabled = enable;
            txtMoTa.Enabled = enable;
        }

        private void ClearInput()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtDonVi.Clear();
            txtMoTa.Clear();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaHang.Text) ||
                string.IsNullOrWhiteSpace(txtTenHang.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(txtDonVi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hàng hóa!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            action = "ADD";
            ClearInput();
            SetInputEnabled(true);
            btnConfirm.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hàng cần sửa!");
                return;
            }
            action = "EDIT";
            SetInputEnabled(true);
            txtMaHang.Enabled = false; // khóa mã hàng khi sửa
            btnConfirm.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa!");
                return;
            }
            action = "DELETE";
            btnConfirm.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            action = "SEARCH";
            SetInputEnabled(false);
            btnConfirm.Visible = false;

            string keyword = txtSearch.Text.Trim();
            da = new SqlDataAdapter("SELECT * FROM HangHoa WHERE MaHH LIKE @MaHH", conn);
            da.SelectCommand.Parameters.AddWithValue("@MaHH", "%" + keyword + "%");
            dt = new DataTable();
            da.Fill(dt);
            dgvHangHoa.DataSource = dt;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (action == "ADD")
            {
                if (!ValidateInput()) return;

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO HangHoa (MaHH, TenHH, SLTon, Gia, MoTa, DonVi) VALUES (@MaHH, @TenHH, @SLTon, @Gia, @MoTa, @DonVi)", conn);
                cmd.Parameters.AddWithValue("@MaHH", txtMaHang.Text);
                cmd.Parameters.AddWithValue("@TenHH", txtTenHang.Text);
                cmd.Parameters.AddWithValue("@SLTon", int.Parse(txtSoLuong.Text));
                cmd.Parameters.AddWithValue("@Gia", decimal.Parse(txtDonGia.Text));
                cmd.Parameters.AddWithValue("@MoTa", txtMoTa.Text);
                cmd.Parameters.AddWithValue("@DonVi", txtDonVi.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm hàng hóa thành công!");
            }
            else if (action == "EDIT")
            {
                if (!ValidateInput()) return;

                SqlCommand cmd = new SqlCommand(
                    "UPDATE HangHoa SET TenHH=@TenHH, SLTon=@SLTon, Gia=@Gia, MoTa=@MoTa, DonVi=@DonVi WHERE MaHH=@MaHH", conn);
                cmd.Parameters.AddWithValue("@MaHH", txtMaHang.Text);
                cmd.Parameters.AddWithValue("@TenHH", txtTenHang.Text);
                cmd.Parameters.AddWithValue("@SLTon", int.Parse(txtSoLuong.Text));
                cmd.Parameters.AddWithValue("@Gia", decimal.Parse(txtDonGia.Text));
                cmd.Parameters.AddWithValue("@MoTa", txtMoTa.Text);
                cmd.Parameters.AddWithValue("@DonVi", txtDonVi.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sửa hàng hóa thành công!");
            }
            else if (action == "DELETE")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM HangHoa WHERE MaHH=@MaHH", conn);
                    cmd.Parameters.AddWithValue("@MaHH", txtMaHang.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa hàng hóa thành công!");
                }
            }

            LoadData();
            SetInputEnabled(false);
            btnConfirm.Visible = false;
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];
                txtMaHang.Text = row.Cells["MaHH"].Value.ToString();
                txtTenHang.Text = row.Cells["TenHH"].Value.ToString();
                txtDonGia.Text = row.Cells["Gia"].Value.ToString();
                txtSoLuong.Text = row.Cells["SLTon"].Value.ToString();
                txtDonVi.Text = row.Cells["DonVi"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
            }
        }
    }
}
