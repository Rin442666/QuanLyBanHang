﻿namespace BTL1
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxChucNang = new System.Windows.Forms.GroupBox();
            this.panel2 = new TransparentPanel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnQLHDN = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnQLHDB = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLHH = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTieuDeMain = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbxChucNang.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbxChucNang);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 588);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gbxChucNang
            // 
            this.gbxChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxChucNang.BackgroundImage = global::BTL1.Properties.Resources.pngtree_shopping_mall_supermarket_selection_merchandise_poster_background_material_image_133225;
            this.gbxChucNang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxChucNang.Controls.Add(this.panel2);
            this.gbxChucNang.Controls.Add(this.btnQLHDN);
            this.gbxChucNang.Controls.Add(this.btnClose);
            this.gbxChucNang.Controls.Add(this.btnQLHDB);
            this.gbxChucNang.Controls.Add(this.btnQLNV);
            this.gbxChucNang.Controls.Add(this.btnQLKH);
            this.gbxChucNang.Controls.Add(this.btnQLHH);
            this.gbxChucNang.Location = new System.Drawing.Point(0, 148);
            this.gbxChucNang.Name = "gbxChucNang";
            this.gbxChucNang.Size = new System.Drawing.Size(929, 451);
            this.gbxChucNang.TabIndex = 3;
            this.gbxChucNang.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.lblTen);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnLogIn);
            this.panel2.Location = new System.Drawing.Point(501, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 66);
            this.panel2.TabIndex = 8;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(79, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 19);
            this.lblUserName.TabIndex = 3;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(30, 23);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(43, 19);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên :";
            this.lblTen.Visible = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(327, 12);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 40);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(214, 12);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(101, 40);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Đăng Nhập";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnQLHDN
            // 
            this.btnQLHDN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnQLHDN.AutoSize = true;
            this.btnQLHDN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQLHDN.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHDN.Location = new System.Drawing.Point(541, 233);
            this.btnQLHDN.MaximumSize = new System.Drawing.Size(306, 48);
            this.btnQLHDN.MinimumSize = new System.Drawing.Size(306, 48);
            this.btnQLHDN.Name = "btnQLHDN";
            this.btnQLHDN.Size = new System.Drawing.Size(306, 48);
            this.btnQLHDN.TabIndex = 7;
            this.btnQLHDN.Text = "Quản lý hóa đơn nhập";
            this.btnQLHDN.UseVisualStyleBackColor = true;
            this.btnQLHDN.Click += new System.EventHandler(this.btnQLHDN_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(812, 410);
            this.btnClose.MaximumSize = new System.Drawing.Size(140, 49);
            this.btnClose.MinimumSize = new System.Drawing.Size(116, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 32);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQLHDB
            // 
            this.btnQLHDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnQLHDB.AutoSize = true;
            this.btnQLHDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQLHDB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHDB.Location = new System.Drawing.Point(541, 163);
            this.btnQLHDB.MaximumSize = new System.Drawing.Size(306, 48);
            this.btnQLHDB.MinimumSize = new System.Drawing.Size(306, 48);
            this.btnQLHDB.Name = "btnQLHDB";
            this.btnQLHDB.Size = new System.Drawing.Size(306, 48);
            this.btnQLHDB.TabIndex = 5;
            this.btnQLHDB.Text = "Quản lý hóa đơn bán hàng";
            this.btnQLHDB.UseVisualStyleBackColor = true;
            this.btnQLHDB.Click += new System.EventHandler(this.btnQLHDB_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnQLNV.AutoSize = true;
            this.btnQLNV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQLNV.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.Location = new System.Drawing.Point(95, 314);
            this.btnQLNV.MaximumSize = new System.Drawing.Size(306, 48);
            this.btnQLNV.MinimumSize = new System.Drawing.Size(306, 48);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(306, 48);
            this.btnQLNV.TabIndex = 2;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnQLKH.AutoSize = true;
            this.btnQLKH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQLKH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.Location = new System.Drawing.Point(95, 233);
            this.btnQLKH.MaximumSize = new System.Drawing.Size(306, 48);
            this.btnQLKH.MinimumSize = new System.Drawing.Size(306, 48);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(306, 48);
            this.btnQLKH.TabIndex = 1;
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLHH
            // 
            this.btnQLHH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnQLHH.AutoSize = true;
            this.btnQLHH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQLHH.BackColor = System.Drawing.Color.Transparent;
            this.btnQLHH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHH.Location = new System.Drawing.Point(95, 163);
            this.btnQLHH.MaximumSize = new System.Drawing.Size(306, 48);
            this.btnQLHH.MinimumSize = new System.Drawing.Size(306, 48);
            this.btnQLHH.Name = "btnQLHH";
            this.btnQLHH.Size = new System.Drawing.Size(306, 48);
            this.btnQLHH.TabIndex = 0;
            this.btnQLHH.Text = "Quản lý hàng hóa";
            this.btnQLHH.UseVisualStyleBackColor = false;
            this.btnQLHH.Click += new System.EventHandler(this.btnQLHH_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblTieuDeMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(928, 147);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(494, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Căn cứ: Ngõ 120 Yên Lãng, Phường Thịnh Quang, TP Hà Nội";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email: Raumart36@cayxang.com";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(768, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "SĐT: 0361886424";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL1.Properties.Resources.istockphoto_1435513729_612x612_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "RauMart";
            // 
            // lblTieuDeMain
            // 
            this.lblTieuDeMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTieuDeMain.AutoSize = true;
            this.lblTieuDeMain.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeMain.Location = new System.Drawing.Point(318, 26);
            this.lblTieuDeMain.Name = "lblTieuDeMain";
            this.lblTieuDeMain.Size = new System.Drawing.Size(310, 53);
            this.lblTieuDeMain.TabIndex = 1;
            this.lblTieuDeMain.Text = "TRANG CHỦ";
            this.lblTieuDeMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 588);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.gbxChucNang.ResumeLayout(false);
            this.gbxChucNang.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTieuDeMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxChucNang;
        private TransparentPanel panel2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnQLHDN;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnQLHDB;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLHH;
    }
}