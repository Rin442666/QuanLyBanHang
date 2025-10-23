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
        private void LoadForm(Form form)
        {
            // Ẩn UI chính
            Home(false);

            // Thiết lập form con
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Thêm vào panel
            panel1.Controls.Add(form);
            form.Show();
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void lblTieuDeMain_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            LoadForm(new QuanLyHoaDon());
        }

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

        public void Home(bool Visible )
        {
            panel3.Visible = Visible;
            panel2.Visible = Visible;
            gbxChucNang.Visible = Visible;
        }
    }
}
