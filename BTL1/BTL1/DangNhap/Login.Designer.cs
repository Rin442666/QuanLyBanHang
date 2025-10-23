namespace BTL1
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
            this.lblMK = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lblTieuDeDN = new System.Windows.Forms.Label();
            this.btnGoRegister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnGoRegister);
            this.panel2.Controls.Add(this.lblTieuDeDN);
            this.panel2.Controls.Add(this.txtTK);
            this.panel2.Controls.Add(this.txtMK);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.btnOut);
            this.panel2.Controls.Add(this.lblTK);
            this.panel2.Controls.Add(this.lblMK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(320, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 539);
            this.panel2.TabIndex = 10;
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
            this.lblMK.Click += new System.EventHandler(this.lblMK_Click);
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
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(290, 315);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(94, 35);
            this.btnOut.TabIndex = 6;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(102, 315);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(143, 204);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(282, 27);
            this.txtMK.TabIndex = 4;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(143, 140);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(282, 27);
            this.txtTK.TabIndex = 3;
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
            this.lblTieuDeDN.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnGoRegister
            // 
            this.btnGoRegister.AutoSize = true;
            this.btnGoRegister.Location = new System.Drawing.Point(153, 449);
            this.btnGoRegister.Name = "btnGoRegister";
            this.btnGoRegister.Size = new System.Drawing.Size(195, 61);
            this.btnGoRegister.TabIndex = 9;
            this.btnGoRegister.Text = "Đăng ký";
            this.btnGoRegister.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Quên mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Button btnGoRegister;
        private System.Windows.Forms.Label lblTieuDeDN;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}