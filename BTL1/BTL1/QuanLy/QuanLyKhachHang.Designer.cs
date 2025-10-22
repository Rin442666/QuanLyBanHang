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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongTieuDung = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 254);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 280);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 167);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(900, 87);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(490, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            this.txtSearch.Size = new System.Drawing.Size(203, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongTieuDung);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtHoVaTen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(900, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTongTieuDung
            // 
            this.txtTongTieuDung.Location = new System.Drawing.Point(611, 119);
            this.txtTongTieuDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTieuDung.Name = "txtTongTieuDung";
            this.txtTongTieuDung.Size = new System.Drawing.Size(168, 27);
            this.txtTongTieuDung.TabIndex = 9;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(611, 76);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(168, 27);
            this.txtAccount.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(611, 29);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 27);
            this.txtPhone.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(179, 119);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(203, 27);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(179, 76);
            this.txtHoVaTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(203, 27);
            this.txtHoVaTen.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 122);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên đăng nhập: ";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyKhachHang";
            this.Text = "QuanLyKhachHang";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTieuDung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
    }
}