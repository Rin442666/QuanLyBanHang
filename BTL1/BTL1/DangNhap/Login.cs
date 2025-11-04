using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace BTL1.DangNhap
{
    public partial class Login : Form
    {
        private List<User> users;

        public User LoggedInUser { get; private set; }

        public Login()
        {
            InitializeComponent();
            LoadUserData();
            this.LoggedInUser = null;
        }

        private void LoadUserData()
        {
            try
            {
                string json = File.ReadAllText("UserList.json");
                users = JsonSerializer.Deserialize<List<User>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải file UserList.json: {ex.Message}");
                users = new List<User>();
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();
            var user = users.FirstOrDefault(u => u.UserName == username && u.Password == password);

            if (user != null)
            {
                this.LoggedInUser = user;
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Đăng nhập thất bại");
                this.LoggedInUser = null; 
                this.DialogResult = DialogResult.None;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.LoggedInUser = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }


        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

    }
}