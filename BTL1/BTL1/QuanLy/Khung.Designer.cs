namespace BTL1.QuanLy
{
    partial class Khung
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLHDB = new System.Windows.Forms.Button();
            this.btnQLHDN = new System.Windows.Forms.Button();
            this.btnQLHH = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PageLoad_Panel = new TransparentPanel();
            this.loading_panel = new TransparentPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 178);
            this.panel1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(704, 139);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(60, 22);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "label1";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 172);
            this.splitter2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1210, 6);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(521, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "jpdiada";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.ErrorImage = null;
            this.Logo.Image = global::BTL1.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(-3, -19);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(244, 208);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.btnQLNV);
            this.panel2.Controls.Add(this.btnQLKH);
            this.panel2.Controls.Add(this.btnQLHDB);
            this.panel2.Controls.Add(this.btnQLHDN);
            this.panel2.Controls.Add(this.btnQLHH);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 178);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 519);
            this.panel2.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHome.Image = global::BTL1.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(0, 451);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(235, 68);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Enabled = false;
            this.btnQLNV.Image = global::BTL1.Properties.Resources.cashier;
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLNV.Location = new System.Drawing.Point(10, 309);
            this.btnQLNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(215, 65);
            this.btnQLNV.TabIndex = 5;
            this.btnQLNV.Text = "Nhân Viên";
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Image = global::BTL1.Properties.Resources.buyer;
            this.btnQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLKH.Location = new System.Drawing.Point(10, 236);
            this.btnQLKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(215, 65);
            this.btnQLKH.TabIndex = 4;
            this.btnQLKH.Text = "Khách Hàng";
            this.btnQLKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLHDB
            // 
            this.btnQLHDB.Image = global::BTL1.Properties.Resources.cargo;
            this.btnQLHDB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLHDB.Location = new System.Drawing.Point(10, 164);
            this.btnQLHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQLHDB.Name = "btnQLHDB";
            this.btnQLHDB.Size = new System.Drawing.Size(215, 65);
            this.btnQLHDB.TabIndex = 3;
            this.btnQLHDB.Text = "Hóa Đơn Bán";
            this.btnQLHDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLHDB.UseVisualStyleBackColor = true;
            this.btnQLHDB.Click += new System.EventHandler(this.btnQLHDB_Click);
            // 
            // btnQLHDN
            // 
            this.btnQLHDN.Image = global::BTL1.Properties.Resources.purchase_order;
            this.btnQLHDN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLHDN.Location = new System.Drawing.Point(10, 91);
            this.btnQLHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQLHDN.Name = "btnQLHDN";
            this.btnQLHDN.Size = new System.Drawing.Size(215, 65);
            this.btnQLHDN.TabIndex = 2;
            this.btnQLHDN.Text = "Hóa Đơn Nhập";
            this.btnQLHDN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLHDN.UseVisualStyleBackColor = true;
            this.btnQLHDN.Click += new System.EventHandler(this.btnQLHDN_Click);
            // 
            // btnQLHH
            // 
            this.btnQLHH.Image = global::BTL1.Properties.Resources.store;
            this.btnQLHH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQLHH.Location = new System.Drawing.Point(10, 18);
            this.btnQLHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQLHH.Name = "btnQLHH";
            this.btnQLHH.Size = new System.Drawing.Size(215, 65);
            this.btnQLHH.TabIndex = 1;
            this.btnQLHH.Text = "Hàng Hóa";
            this.btnQLHH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLHH.UseVisualStyleBackColor = true;
            this.btnQLHH.Click += new System.EventHandler(this.btnQLHH_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(235, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 519);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(519, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(510, 348);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PageLoad_Panel
            // 
            this.PageLoad_Panel.AutoSize = true;
            this.PageLoad_Panel.BackColor = System.Drawing.Color.LightCyan;
            this.PageLoad_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageLoad_Panel.Location = new System.Drawing.Point(241, 178);
            this.PageLoad_Panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PageLoad_Panel.Name = "PageLoad_Panel";
            this.PageLoad_Panel.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.PageLoad_Panel.Size = new System.Drawing.Size(969, 519);
            this.PageLoad_Panel.TabIndex = 3;
            // 
            // loading_panel
            // 
            this.loading_panel.BackColor = System.Drawing.Color.Transparent;
            this.loading_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading_panel.Location = new System.Drawing.Point(214, 150);
            this.loading_panel.Name = "loading_panel";
            this.loading_panel.Size = new System.Drawing.Size(1568, 803);
            this.loading_panel.TabIndex = 4;
            this.loading_panel.Visible = false;
            // 
            // Khung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1210, 697);
            this.Controls.Add(this.PageLoad_Panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Khung";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Quản Lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Khung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private TransparentPanel PageLoad_Panel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private TransparentPanel loading_panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnQLHH;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLHDB;
        private System.Windows.Forms.Button btnQLHDN;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblWelcome;
    }
}