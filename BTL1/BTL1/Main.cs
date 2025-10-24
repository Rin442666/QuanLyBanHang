using BTL1.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL1
{
    public partial class Main : Form
    {
        private User loggedInUser;

        public Main()
        {
            InitializeComponent();
        }

        public Main(User User)
        {
            InitializeComponent();
            this.loggedInUser = User;
            NotLogged();
        }

        private void LoadForm(Form form)
        {
            Home(false);

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel1.Controls.Add(form);
            form.Show();
        }

        private void NotLogged()
        {
            if (loggedInUser == null)
            {
                lblTen.Visible = false;
                lblUserName.Visible = false;
                lblUserName.Text = "";
                btnQLHDB.Enabled = false;
                btnQLHDN.Enabled = false;
                btnQLKH.Enabled = false;
                btnQLNV.Enabled = false;
                btnQLHH.Enabled = false;
                btnLogIn.Visible = true;
                btnLogOut.Visible = false;
            }
            else
            {
                lblTen.Visible = true;
                lblUserName.Visible = true;
                lblUserName.Text = loggedInUser.Name;
                btnLogIn.Visible = false;
                btnLogOut.Visible = true;
                string quyen = loggedInUser.Authority;

                if (quyen == "Admin" || quyen == "QuanLy")
                {
                    btnQLHDB.Enabled = true;
                    btnQLKH.Enabled = true;
                    btnQLNV.Enabled = true;
                    btnQLHH.Enabled = true;
                    btnQLHDN.Enabled = true;
                }
                else if (quyen == "NhanVien")
                {
                    btnQLHDB.Enabled = true;
                    btnQLKH.Enabled = true;
                    btnQLNV.Enabled = false;
                    btnQLHH.Enabled = true;
                    btnQLHDN.Enabled = true;
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            NotLogged();
        }

        // CÁC SỰ KIỆN CLICK


        private void btnQLKH_Click(object sender, EventArgs e)
        {
            LoadForm(new QuanLyKhachHang());
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            LoadForm(new QuanLyNhanVien());
        }

        private void btnQLHH_Click(object sender, EventArgs e)
        {
            LoadForm(new QuanLyHangHoa());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Home(bool Visible)
        {
            panel3.Visible = Visible;
            panel2.Visible = Visible;
            gbxChucNang.Visible = Visible;
        }

        //LOGIN - LOGOUT
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using (var loginForm = new Login())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    this.loggedInUser = loginForm.LoggedInUser;
                    MessageBox.Show($"Xin chào {loggedInUser.UserName} ({loggedInUser.Authority})!");
                    NotLogged();
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Home(true);
            loggedInUser = null;
            MessageBox.Show("Đã đăng xuất.", "Thông báo");
            NotLogged();
        }

        private void btnQLHDB_Click(object sender, EventArgs e)
        {
            LoadForm(new HoaDonBanHang());
        }

        private void btnQLHDN_Click(object sender, EventArgs e)
        {
            LoadForm(new HoaDonNhapHang());
        }
    }
}