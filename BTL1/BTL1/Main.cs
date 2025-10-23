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
            // Ẩn các nút chức năng gốc
            btnQLHH.Visible = false;
            btnQLNV.Visible = false;
            btnQLKH.Visible = false;
            btnQLHD.Visible = false;
            panel3.Visible = false;

            // Hiển thị form con
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

public void ShowHome()
        {
            // Xóa form con khỏi panel
            panel1.Controls.Clear();

            // Hiển thị lại các nút chức năng gốc
            btnQLHH.Visible = true;
            btnQLNV.Visible = true;
            btnQLKH.Visible = true;
            btnQLHD.Visible = true;
            panel3.Visible = true;
            
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
    }
}
