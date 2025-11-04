namespace BTL1
{
    partial class QuanLyKhachHang
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grbKhachHang = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTieuDung = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.grbKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 200);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(900, 334);
            this.dgvKhachHang.TabIndex = 5;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnSearch);
            this.grbChucNang.Controls.Add(this.label6);
            this.grbChucNang.Controls.Add(this.txtSearch);
            this.grbChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbChucNang.Location = new System.Drawing.Point(0, 125);
            this.grbChucNang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbChucNang.Size = new System.Drawing.Size(900, 75);
            this.grbChucNang.TabIndex = 4;
            this.grbChucNang.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(499, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(179, 35);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.BackColor = System.Drawing.Color.LightBlue;
            this.grbKhachHang.Controls.Add(this.label3);
            this.grbKhachHang.Controls.Add(this.txtTongTieuDung);
            this.grbKhachHang.Controls.Add(this.txtSDT);
            this.grbKhachHang.Controls.Add(this.txtTenKH);
            this.grbKhachHang.Controls.Add(this.label7);
            this.grbKhachHang.Controls.Add(this.txtMaKH);
            this.grbKhachHang.Controls.Add(this.label4);
            this.grbKhachHang.Controls.Add(this.label2);
            this.grbKhachHang.Controls.Add(this.label1);
            this.grbKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbKhachHang.Location = new System.Drawing.Point(0, 0);
            this.grbKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbKhachHang.Size = new System.Drawing.Size(900, 125);
            this.grbKhachHang.TabIndex = 3;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "Thông tin khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(733, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đồng";
            // 
            // txtTongTieuDung
            // 
            this.txtTongTieuDung.Location = new System.Drawing.Point(611, 76);
            this.txtTongTieuDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTieuDung.Name = "txtTongTieuDung";
            this.txtTongTieuDung.Size = new System.Drawing.Size(168, 27);
            this.txtTongTieuDung.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(611, 29);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(168, 27);
            this.txtSDT.TabIndex = 8;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(179, 76);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(203, 27);
            this.txtTenKH.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tổng tiêu dùng:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(179, 29);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(203, 27);
            this.txtMaKH.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng:";
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbKhachHang);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            this.grbChucNang.PerformLayout();
            this.grbKhachHang.ResumeLayout(false);
            this.grbKhachHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTieuDung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
    }
}