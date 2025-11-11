namespace BTL1
{
    partial class addHDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnTong = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbHoaDonBan = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachHang = new System.Windows.Forms.DataGridView();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dtpBan = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbChiTietHDB = new System.Windows.Forms.GroupBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTong.SuspendLayout();
            this.grbHoaDonBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHang)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbChiTietHDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTong
            // 
            this.pnTong.BackColor = System.Drawing.Color.Transparent;
            this.pnTong.Controls.Add(this.lblTongTien);
            this.pnTong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnTong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTong.Location = new System.Drawing.Point(3, 754);
            this.pnTong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnTong.Name = "pnTong";
            this.pnTong.Size = new System.Drawing.Size(664, 57);
            this.pnTong.TabIndex = 6;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(7, 15);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(129, 33);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(519, 179);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(130, 32);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Xác nhận";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(93, 128);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 27);
            this.txtSearch.TabIndex = 13;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(14, 132);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(79, 19);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(293, 125);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 32);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // grbHoaDonBan
            // 
            this.grbHoaDonBan.AutoSize = true;
            this.grbHoaDonBan.Controls.Add(this.dgvDanhSachHang);
            this.grbHoaDonBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbHoaDonBan.Location = new System.Drawing.Point(0, 241);
            this.grbHoaDonBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbHoaDonBan.Name = "grbHoaDonBan";
            this.grbHoaDonBan.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbHoaDonBan.Size = new System.Drawing.Size(670, 577);
            this.grbHoaDonBan.TabIndex = 5;
            this.grbHoaDonBan.TabStop = false;
            this.grbHoaDonBan.Text = "Danh Sách Hàng Hóa";
            // 
            // dgvDanhSachHang
            // 
            this.dgvDanhSachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachHang.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDanhSachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHang.Location = new System.Drawing.Point(3, 24);
            this.dgvDanhSachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachHang.Name = "dgvDanhSachHang";
            this.dgvDanhSachHang.RowHeadersWidth = 51;
            this.dgvDanhSachHang.RowTemplate.Height = 24;
            this.dgvDanhSachHang.Size = new System.Drawing.Size(664, 549);
            this.dgvDanhSachHang.TabIndex = 0;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(431, 78);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(116, 27);
            this.txtMaKH.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Khách hàng: ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(431, 38);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(116, 27);
            this.txtMaNV.TabIndex = 5;
            // 
            // dtpBan
            // 
            this.dtpBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBan.Location = new System.Drawing.Point(126, 78);
            this.dtpBan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpBan.Name = "dtpBan";
            this.dtpBan.Size = new System.Drawing.Size(120, 27);
            this.dtpBan.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grbChiTietHDB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1352, 826);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // grbChiTietHDB
            // 
            this.grbChiTietHDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChiTietHDB.AutoSize = true;
            this.grbChiTietHDB.Controls.Add(this.pnTong);
            this.grbChiTietHDB.Controls.Add(this.dgvGioHang);
            this.grbChiTietHDB.Location = new System.Drawing.Point(679, 5);
            this.grbChiTietHDB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grbChiTietHDB.Name = "grbChiTietHDB";
            this.grbChiTietHDB.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grbChiTietHDB.Size = new System.Drawing.Size(670, 816);
            this.grbChiTietHDB.TabIndex = 4;
            this.grbChiTietHDB.TabStop = false;
            this.grbChiTietHDB.Text = "Giỏ Hàng";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.Location = new System.Drawing.Point(3, 25);
            this.dgvGioHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.RowTemplate.Height = 24;
            this.dgvGioHang.Size = new System.Drawing.Size(664, 786);
            this.dgvGioHang.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbHoaDonBan);
            this.panel1.Controls.Add(this.grbThongtin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 818);
            this.panel1.TabIndex = 8;
            // 
            // grbThongtin
            // 
            this.grbThongtin.AutoSize = true;
            this.grbThongtin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbThongtin.Controls.Add(this.btnXoa);
            this.grbThongtin.Controls.Add(this.btnThem);
            this.grbThongtin.Controls.Add(this.label4);
            this.grbThongtin.Controls.Add(this.btnHuy);
            this.grbThongtin.Controls.Add(this.nudSoLuong);
            this.grbThongtin.Controls.Add(this.btnLuu);
            this.grbThongtin.Controls.Add(this.txtSearch);
            this.grbThongtin.Controls.Add(this.lblSearch);
            this.grbThongtin.Controls.Add(this.btnSearch);
            this.grbThongtin.Controls.Add(this.txtMaKH);
            this.grbThongtin.Controls.Add(this.label6);
            this.grbThongtin.Controls.Add(this.dtpBan);
            this.grbThongtin.Controls.Add(this.txtMaNV);
            this.grbThongtin.Controls.Add(this.txtMaHDB);
            this.grbThongtin.Controls.Add(this.label3);
            this.grbThongtin.Controls.Add(this.label2);
            this.grbThongtin.Controls.Add(this.label1);
            this.grbThongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongtin.Location = new System.Drawing.Point(0, 0);
            this.grbThongtin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grbThongtin.Size = new System.Drawing.Size(670, 241);
            this.grbThongtin.TabIndex = 3;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin chung";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(402, 179);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 32);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(276, 179);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 32);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số lượng: ";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(519, 123);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(130, 32);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(93, 185);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(135, 27);
            this.nudSoLuong.TabIndex = 16;
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Location = new System.Drawing.Point(126, 38);
            this.txtMaHDB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.ReadOnly = true;
            this.txtMaHDB.Size = new System.Drawing.Size(120, 27);
            this.txtMaHDB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên bán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // addHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 826);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addHDB";
            this.Text = "addHDB";
            this.Load += new System.EventHandler(this.addHDN_Load);
            this.pnTong.ResumeLayout(false);
            this.pnTong.PerformLayout();
            this.grbHoaDonBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHang)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grbChiTietHDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbThongtin.ResumeLayout(false);
            this.grbThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grbHoaDonBan;
        private System.Windows.Forms.DataGridView dgvDanhSachHang;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DateTimePicker dtpBan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grbChiTietHDB;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label3;
    }
}