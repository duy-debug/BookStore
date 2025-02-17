namespace BookStore
{
    partial class Authentication
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
            labelLogin = new Label();
            labelTenDangNhap = new Label();
            textBoxUsername = new TextBox();
            labelMatkhau = new Label();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            labelAlert = new Label();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(12, 22);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(201, 26);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Đăng nhập hệ thống";
            // 
            // labelTenDangNhap
            // 
            labelTenDangNhap.AutoSize = true;
            labelTenDangNhap.Font = new Font("Segoe UI", 12F);
            labelTenDangNhap.Location = new Point(12, 107);
            labelTenDangNhap.Name = "labelTenDangNhap";
            labelTenDangNhap.Size = new Size(140, 28);
            labelTenDangNhap.TabIndex = 1;
            labelTenDangNhap.Text = "Tên đăng nhập";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F);
            textBoxUsername.Location = new Point(12, 138);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(280, 34);
            textBoxUsername.TabIndex = 1;
            // 
            // labelMatkhau
            // 
            labelMatkhau.AutoSize = true;
            labelMatkhau.Font = new Font("Segoe UI", 12F);
            labelMatkhau.Location = new Point(12, 175);
            labelMatkhau.Name = "labelMatkhau";
            labelMatkhau.Size = new Size(94, 28);
            labelMatkhau.TabIndex = 1;
            labelMatkhau.Text = "Mật khẩu";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F);
            textBoxPassword.Location = new Point(12, 206);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(280, 34);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(12, 260);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(125, 41);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Đăng nhập";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelAlert
            // 
            labelAlert.AutoSize = true;
            labelAlert.ForeColor = Color.Red;
            labelAlert.Location = new Point(12, 76);
            labelAlert.Name = "labelAlert";
            labelAlert.Size = new Size(0, 20);
            labelAlert.TabIndex = 4;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(labelAlert);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelMatkhau);
            Controls.Add(labelTenDangNhap);
            Controls.Add(labelLogin);
            Name = "Authentication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosed += Authentication_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelTenDangNhap;
        private TextBox textBoxUsername;
        private Label labelMatkhau;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Label labelAlert;
    }
}