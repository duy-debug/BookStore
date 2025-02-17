namespace BookStore.Staff
{
    partial class UserControlStaffHome
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
            tabControlStaff = new TabControl();
            tab = new TabPage();
            tabPagelnvoice = new TabPage();
            dataGridViewListProduct = new DataGridView();
            textBoxSearchProduct = new TextBox();
            labelListProduct = new Label();
            dataGridViewBuyProduct = new DataGridView();
            label1 = new Label();
            buttonPayment = new Button();
            buttonPayPoint = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            dataGridViewvoice = new DataGridView();
            textBoxSearchlnvoice = new TextBox();
            tabControlStaff.SuspendLayout();
            tab.SuspendLayout();
            tabPagelnvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuyProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewvoice).BeginInit();
            SuspendLayout();
            // 
            // tabControlStaff
            // 
            tabControlStaff.Controls.Add(tab);
            tabControlStaff.Controls.Add(tabPagelnvoice);
            tabControlStaff.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControlStaff.Location = new Point(3, 3);
            tabControlStaff.Name = "tabControlStaff";
            tabControlStaff.SelectedIndex = 0;
            tabControlStaff.Size = new Size(1152, 554);
            tabControlStaff.TabIndex = 0;
            // 
            // tab
            // 
            tab.Controls.Add(comboBox1);
            tab.Controls.Add(buttonPayPoint);
            tab.Controls.Add(buttonPayment);
            tab.Controls.Add(dataGridViewBuyProduct);
            tab.Controls.Add(label2);
            tab.Controls.Add(label1);
            tab.Controls.Add(labelListProduct);
            tab.Controls.Add(textBoxSearchProduct);
            tab.Controls.Add(dataGridViewListProduct);
            tab.Location = new Point(4, 32);
            tab.Name = "tab";
            tab.Padding = new Padding(3);
            tab.Size = new Size(1144, 518);
            tab.TabIndex = 0;
            tab.Text = "Bán hàng";
            tab.UseVisualStyleBackColor = true;
            // 
            // tabPagelnvoice
            // 
            tabPagelnvoice.Controls.Add(textBoxSearchlnvoice);
            tabPagelnvoice.Controls.Add(dataGridViewvoice);
            tabPagelnvoice.Location = new Point(4, 32);
            tabPagelnvoice.Name = "tabPagelnvoice";
            tabPagelnvoice.Padding = new Padding(3);
            tabPagelnvoice.Size = new Size(1144, 518);
            tabPagelnvoice.TabIndex = 1;
            tabPagelnvoice.Text = "Danh sách hóa đơn";
            tabPagelnvoice.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListProduct
            // 
            dataGridViewListProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListProduct.Location = new Point(418, 48);
            dataGridViewListProduct.Name = "dataGridViewListProduct";
            dataGridViewListProduct.RowHeadersWidth = 51;
            dataGridViewListProduct.Size = new Size(720, 467);
            dataGridViewListProduct.TabIndex = 0;
            // 
            // textBoxSearchProduct
            // 
            textBoxSearchProduct.Location = new Point(418, 14);
            textBoxSearchProduct.Name = "textBoxSearchProduct";
            textBoxSearchProduct.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBoxSearchProduct.Size = new Size(720, 30);
            textBoxSearchProduct.TabIndex = 1;
            // 
            // labelListProduct
            // 
            labelListProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelListProduct.Location = new Point(310, 446);
            labelListProduct.Name = "labelListProduct";
            labelListProduct.Size = new Size(102, 25);
            labelListProduct.TabIndex = 3;
            labelListProduct.Text = "Tổng tiền";
            labelListProduct.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridViewBuyProduct
            // 
            dataGridViewBuyProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuyProduct.Location = new Point(6, 48);
            dataGridViewBuyProduct.Name = "dataGridViewBuyProduct";
            dataGridViewBuyProduct.RowHeadersWidth = 51;
            dataGridViewBuyProduct.Size = new Size(406, 366);
            dataGridViewBuyProduct.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 442);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 3;
            label1.Text = "Tổng tiền";
            // 
            // buttonPayment
            // 
            buttonPayment.Location = new Point(7, 473);
            buttonPayment.Name = "buttonPayment";
            buttonPayment.Size = new Size(128, 39);
            buttonPayment.TabIndex = 5;
            buttonPayment.Text = "Thanh toán";
            buttonPayment.UseVisualStyleBackColor = true;
            // 
            // buttonPayPoint
            // 
            buttonPayPoint.Location = new Point(141, 473);
            buttonPayPoint.Name = "buttonPayPoint";
            buttonPayPoint.Size = new Size(271, 39);
            buttonPayPoint.TabIndex = 5;
            buttonPayPoint.Text = "Thanh toán tích điểm";
            buttonPayPoint.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 417);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 3;
            label2.Text = "Giảm giá";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(261, 417);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 31);
            comboBox1.TabIndex = 6;
            // 
            // dataGridViewvoice
            // 
            dataGridViewvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewvoice.Location = new Point(3, 55);
            dataGridViewvoice.Name = "dataGridViewvoice";
            dataGridViewvoice.RowHeadersWidth = 51;
            dataGridViewvoice.Size = new Size(1132, 457);
            dataGridViewvoice.TabIndex = 0;
            // 
            // textBoxSearchlnvoice
            // 
            textBoxSearchlnvoice.Location = new Point(6, 13);
            textBoxSearchlnvoice.Name = "textBoxSearchlnvoice";
            textBoxSearchlnvoice.PlaceholderText = "Tìm kiếm hóa đơn";
            textBoxSearchlnvoice.Size = new Size(1129, 30);
            textBoxSearchlnvoice.TabIndex = 2;
            // 
            // UserControlStaffHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlStaff);
            Name = "UserControlStaffHome";
            Size = new Size(1158, 560);
            tabControlStaff.ResumeLayout(false);
            tab.ResumeLayout(false);
            tab.PerformLayout();
            tabPagelnvoice.ResumeLayout(false);
            tabPagelnvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuyProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewvoice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlStaff;
        private TabPage tab;
        private TabPage tabPagelnvoice;
        private ListView listView1;
        private TextBox textBoxSearchProduct;
        private DataGridView dataGridViewListProduct;
        private DataGridView dataGridViewBuyProduct;
        private Label labelListProduct;
        private Label label1;
        private Button buttonPayment;
        private ComboBox comboBox1;
        private Button buttonPayPoint;
        private Label label2;
        private DataGridView dataGridViewvoice;
        private TextBox textBoxSearchlnvoice;
    }
}
