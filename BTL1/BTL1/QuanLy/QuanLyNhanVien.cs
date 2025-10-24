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
    public partial class QuanLyNhanVien : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        string action = "";
        public QuanLyNhanVien()
        {
            InitializeComponent();
            string connStr = ConfigurationManager.ConnectionStrings["QuanLyBanHangConnectionString"].ConnectionString;
            conn = new SqlConnection(connStr);
        }

        
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            SetInputEnabled(false);
            btnConfirm.Visible = false;
        }

        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvNhanVien.DataSource = dt;
        }

        private void SetInputEnabled(bool enable)
        {
            txtMaNV.Enabled = enable;
            txtTenNV.Enabled = enable;
            txtChucVu.Enabled = enable;
            txtMail.Enabled = enable;
            txtSDT.Enabled = enable;
            txtQue.Enabled = enable;
            dtNgaySinh.Enabled = enable;
        }

        private void ClearInput()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtChucVu.Clear();
            txtMail.Clear();
            txtSDT.Clear();
            txtQue.Clear();
            dtNgaySinh.Value = DateTime.Now;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value.ToString();
                txtMail.Text = row.Cells["Email"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtQue.Text = row.Cells["Que"].Value.ToString();
                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                    dtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                btnEdit.Enabled = true;
                btnClear.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ma = txtSearch.Text.Trim();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien WHERE MaNV LIKE @ma", conn);
            da.SelectCommand.Parameters.AddWithValue("@ma", "%" + ma + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNhanVien.DataSource = dt;

            SetInputEnabled(false);
            btnConfirm.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            action = "add";
            ClearInput();
            SetInputEnabled(true);
            btnConfirm.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Hãy chọn nhân viên để sửa.");
                return;
            }

            action = "edit";
            SetInputEnabled(true);
            txtMaNV.Enabled = false;
            btnConfirm.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Hãy chọn nhân viên để xóa.");
                return;
            }

            action = "delete";
            btnConfirm.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {
                if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
                    string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                    string.IsNullOrWhiteSpace(txtChucVu.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên.");
                    return;
                }

                SqlCommand cmd = new SqlCommand(@"INSERT INTO NhanVien (MaNV, ChucVu, TenNV, Que, NgaySinh, Email, SDT)
                                                  VALUES (@MaNV, @ChucVu, @TenNV, @Que, @NgaySinh, @Email, @SDT)", conn);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@ChucVu", txtChucVu.Text);
                cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                cmd.Parameters.AddWithValue("@Que", txtQue.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                cmd.Parameters.AddWithValue("@Email", txtMail.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Thêm nhân viên thành công!");
            }
            else if (action == "edit")
            {
                SqlCommand cmd = new SqlCommand(@"UPDATE NhanVien SET 
                    ChucVu=@ChucVu, TenNV=@TenNV, Que=@Que, NgaySinh=@NgaySinh, Email=@Email, SDT=@SDT
                    WHERE MaNV=@MaNV", conn);

                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@ChucVu", txtChucVu.Text);
                cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                cmd.Parameters.AddWithValue("@Que", txtQue.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                cmd.Parameters.AddWithValue("@Email", txtMail.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cập nhật nhân viên thành công!");
            }
            else if (action == "delete")
            {
                SqlCommand cmd = new SqlCommand(@"UPDATE NhanVien SET 
                    ChucVu=NULL, TenNV=NULL, Que=NULL, NgaySinh=NULL, Email=NULL, SDT=NULL
                    WHERE MaNV=@MaNV", conn);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đã xóa (ẩn) thông tin nhân viên!");
            }

            LoadData();
            SetInputEnabled(false);
            btnConfirm.Visible = false;
            action = "";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)this.ParentForm;
            mainForm.Home(true);
            this.Close();
        }
    }
}
