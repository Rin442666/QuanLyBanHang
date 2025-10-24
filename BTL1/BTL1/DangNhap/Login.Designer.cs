namespace BTL1.DangNhap
{
    partial class Login
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTieuDeDN = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTK = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblTieuDeDN);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.lblTK);
            this.panel2.Controls.Add(this.lblMK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(320, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 539);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblTieuDeDN
            // 
            this.lblTieuDeDN.AutoSize = true;
            this.lblTieuDeDN.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeDN.Location = new System.Drawing.Point(90, 9);
            this.lblTieuDeDN.Name = "lblTieuDeDN";
            this.lblTieuDeDN.Size = new System.Drawing.Size(307, 53);
            this.lblTieuDeDN.TabIndex = 2;
            this.lblTieuDeDN.Text = "ĐĂNG NHẬP";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(143, 140);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(282, 27);
            this.txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(143, 204);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(282, 27);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(180, 319);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 47);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(203, 439);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 35);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Thoát";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.Location = new System.Drawing.Point(30, 141);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(94, 22);
            this.lblTK.TabIndex = 0;
            this.lblTK.Text = "Tài khoản:";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.Location = new System.Drawing.Point(30, 205);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(88, 22);
            this.lblMK.TabIndex = 1;
            this.lblMK.Text = "Mật khẩu:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 539);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BTL1.Properties.Resources._437927798_404093782372543_6879839883003334778_n;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(790, 539);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(790, 539);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTieuDeDN;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}