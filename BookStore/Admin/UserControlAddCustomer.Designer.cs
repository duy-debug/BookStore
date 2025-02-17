namespace BookStore.Admin
{
    partial class UserControlAddCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitleAddCustomer = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelTitleAddCustomer
            // 
            labelTitleAddCustomer.AutoSize = true;
            labelTitleAddCustomer.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitleAddCustomer.Location = new Point(30, 41);
            labelTitleAddCustomer.Name = "labelTitleAddCustomer";
            labelTitleAddCustomer.Size = new Size(221, 26);
            labelTitleAddCustomer.TabIndex = 0;
            labelTitleAddCustomer.Text = "Thêm khách hàng mới";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F);
            button1.Location = new Point(1006, 502);
            button1.Name = "button1";
            button1.Size = new Size(103, 36);
            button1.TabIndex = 1;
            button1.Text = "Hủy bỏ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F);
            button2.Location = new Point(857, 502);
            button2.Name = "button2";
            button2.Size = new Size(134, 36);
            button2.TabIndex = 1;
            button2.Text = "Lưu thông tin";
            button2.UseVisualStyleBackColor = true;
            // 
            // UserControlAddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelTitleAddCustomer);
            Name = "UserControlAddCustomer";
            Size = new Size(1158, 560);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitleAddCustomer;
        private Button button1;
        private Button button2;
    }
}
