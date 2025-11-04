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

namespace BTL1.QuanLy
{
    public partial class Khung : Form
    {
        private User loggedInUser;
        public Form FormToLoad { get; set; }
        private Form currentChildForm;

        public Khung(User user)
        {
            InitializeComponent();
            Login login = new Login();
            this.loggedInUser = user;
            Userload();
        }

        
        private void Khung_Load(object sender, EventArgs e)
        {
            if (FormToLoad != null)
            LoadChildForm(FormToLoad);
            
        }

        private void Userload()
        {
            if (loggedInUser.Authority == "QuanLy")
            {
                btnQLNV.Enabled = true;
            }

            string quyen;
            if (loggedInUser.Authority == "NhanVien")
                quyen = "Nhân Viên";
            else
                quyen = "Quản Lý";
            lblWelcome.Text = "Xin Chào " + quyen + " : " + loggedInUser.Name ;
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();

            lblTitle.Text = childForm.Text;
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            PageLoad_Panel.Controls.Clear();
            PageLoad_Panel.Controls.Add(childForm);
            PageLoad_Panel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            LoadChildForm(new QuanLyKhachHang());
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            LoadChildForm (new QuanLyNhanVien());
        }

        private void btnQLHH_Click(object sender, EventArgs e)
        {
            LoadChildForm(new QuanLyHangHoa());
        }

        private void btnQLHDB_Click(object sender, EventArgs e)
        {
            LoadChildForm(new HoaDonBanHang());
        }

        private void btnQLHDN_Click(object sender, EventArgs e)
        {
            LoadChildForm(new HoaDonNhapHang());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
