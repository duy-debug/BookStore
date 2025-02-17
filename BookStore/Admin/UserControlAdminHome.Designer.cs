namespace BookStore.Admin
{
    partial class UserControlAdminHome
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
            tabControlAdmin = new TabControl();
            tabPageCustumer = new TabPage();
            tabPageEmployee = new TabPage();
            tabPageProduct = new TabPage();
            tabPageCategory = new TabPage();
            dataGridViewCategory = new DataGridView();
            dataGridViewProduct = new DataGridView();
            dataGridViewEployee = new DataGridView();
            dataGridViewCustumer = new DataGridView();
            buttonAddCustumer = new Button();
            buttonDeleteCustomer = new Button();
            textBoxSearchCustomer = new TextBox();
            textBoxSearchEmployee = new TextBox();
            buttonDeleteEmployee = new Button();
            buttonAddEmployee = new Button();
            textBoxSearchProduct = new TextBox();
            buttonDeleteProduct = new Button();
            buttonAddProduct = new Button();
            textBoxSearchCategory = new TextBox();
            button1 = new Button();
            button2 = new Button();
            tabControlAdmin.SuspendLayout();
            tabPageCustumer.SuspendLayout();
            tabPageEmployee.SuspendLayout();
            tabPageProduct.SuspendLayout();
            tabPageCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustumer).BeginInit();
            SuspendLayout();
            // 
            // tabControlAdmin
            // 
            tabControlAdmin.Controls.Add(tabPageCustumer);
            tabControlAdmin.Controls.Add(tabPageEmployee);
            tabControlAdmin.Controls.Add(tabPageProduct);
            tabControlAdmin.Controls.Add(tabPageCategory);
            tabControlAdmin.Location = new Point(16, 26);
            tabControlAdmin.Name = "tabControlAdmin";
            tabControlAdmin.SelectedIndex = 0;
            tabControlAdmin.Size = new Size(1139, 517);
            tabControlAdmin.TabIndex = 0;
            // 
            // tabPageCustumer
            // 
            tabPageCustumer.Controls.Add(textBoxSearchCustomer);
            tabPageCustumer.Controls.Add(buttonDeleteCustomer);
            tabPageCustumer.Controls.Add(buttonAddCustumer);
            tabPageCustumer.Controls.Add(dataGridViewCustumer);
            tabPageCustumer.Location = new Point(4, 29);
            tabPageCustumer.Name = "tabPageCustumer";
            tabPageCustumer.Padding = new Padding(3);
            tabPageCustumer.Size = new Size(1131, 484);
            tabPageCustumer.TabIndex = 0;
            tabPageCustumer.Text = "Danh sách khách hàng";
            tabPageCustumer.UseVisualStyleBackColor = true;
            // 
            // tabPageEmployee
            // 
            tabPageEmployee.Controls.Add(textBoxSearchEmployee);
            tabPageEmployee.Controls.Add(buttonDeleteEmployee);
            tabPageEmployee.Controls.Add(buttonAddEmployee);
            tabPageEmployee.Controls.Add(dataGridViewEployee);
            tabPageEmployee.Location = new Point(4, 29);
            tabPageEmployee.Name = "tabPageEmployee";
            tabPageEmployee.Padding = new Padding(3);
            tabPageEmployee.Size = new Size(1131, 484);
            tabPageEmployee.TabIndex = 1;
            tabPageEmployee.Text = "Danh sách nhân viên";
            tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // tabPageProduct
            // 
            tabPageProduct.Controls.Add(textBoxSearchProduct);
            tabPageProduct.Controls.Add(buttonDeleteProduct);
            tabPageProduct.Controls.Add(buttonAddProduct);
            tabPageProduct.Controls.Add(dataGridViewProduct);
            tabPageProduct.Location = new Point(4, 29);
            tabPageProduct.Name = "tabPageProduct";
            tabPageProduct.Padding = new Padding(3);
            tabPageProduct.Size = new Size(1131, 484);
            tabPageProduct.TabIndex = 2;
            tabPageProduct.Text = "Danh sách sản phẩm";
            tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // tabPageCategory
            // 
            tabPageCategory.Controls.Add(textBoxSearchCategory);
            tabPageCategory.Controls.Add(button1);
            tabPageCategory.Controls.Add(button2);
            tabPageCategory.Controls.Add(dataGridViewCategory);
            tabPageCategory.Location = new Point(4, 29);
            tabPageCategory.Name = "tabPageCategory";
            tabPageCategory.Padding = new Padding(3);
            tabPageCategory.Size = new Size(1131, 484);
            tabPageCategory.TabIndex = 3;
            tabPageCategory.Text = "Danh sách danh mục";
            tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCategory
            // 
            dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategory.Location = new Point(5, 51);
            dataGridViewCategory.Name = "dataGridViewCategory";
            dataGridViewCategory.RowHeadersWidth = 51;
            dataGridViewCategory.Size = new Size(1119, 427);
            dataGridViewCategory.TabIndex = 0;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(9, 51);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowHeadersWidth = 51;
            dataGridViewProduct.Size = new Size(1119, 427);
            dataGridViewProduct.TabIndex = 1;
            // 
            // dataGridViewEployee
            // 
            dataGridViewEployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEployee.Location = new Point(6, 48);
            dataGridViewEployee.Name = "dataGridViewEployee";
            dataGridViewEployee.RowHeadersWidth = 51;
            dataGridViewEployee.Size = new Size(1119, 430);
            dataGridViewEployee.TabIndex = 1;
            // 
            // dataGridViewCustumer
            // 
            dataGridViewCustumer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustumer.Location = new Point(6, 56);
            dataGridViewCustumer.Name = "dataGridViewCustumer";
            dataGridViewCustumer.RowHeadersWidth = 51;
            dataGridViewCustumer.Size = new Size(1119, 422);
            dataGridViewCustumer.TabIndex = 1;
            // 
            // buttonAddCustumer
            // 
            buttonAddCustumer.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddCustumer.Location = new Point(6, 11);
            buttonAddCustumer.Name = "buttonAddCustumer";
            buttonAddCustumer.Size = new Size(197, 39);
            buttonAddCustumer.TabIndex = 2;
            buttonAddCustumer.Text = "Thêm khách hàng mới";
            buttonAddCustumer.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteCustomer.Location = new Point(209, 11);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(211, 39);
            buttonDeleteCustomer.TabIndex = 3;
            buttonDeleteCustomer.Text = "Xóa khách hàng đã chọn";
            buttonDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchCustomer
            // 
            textBoxSearchCustomer.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearchCustomer.Location = new Point(426, 11);
            textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            textBoxSearchCustomer.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBoxSearchCustomer.Size = new Size(699, 37);
            textBoxSearchCustomer.TabIndex = 4;
            // 
            // textBoxSearchEmployee
            // 
            textBoxSearchEmployee.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearchEmployee.Location = new Point(426, 3);
            textBoxSearchEmployee.Name = "textBoxSearchEmployee";
            textBoxSearchEmployee.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBoxSearchEmployee.Size = new Size(699, 37);
            textBoxSearchEmployee.TabIndex = 7;
            // 
            // buttonDeleteEmployee
            // 
            buttonDeleteEmployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteEmployee.Location = new Point(209, 3);
            buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            buttonDeleteEmployee.Size = new Size(211, 39);
            buttonDeleteEmployee.TabIndex = 6;
            buttonDeleteEmployee.Text = "Xóa nhân viên đã chọn";
            buttonDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddEmployee.Location = new Point(6, 3);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(197, 39);
            buttonAddEmployee.TabIndex = 5;
            buttonAddEmployee.Text = "Thêm nhân viên mới";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchProduct
            // 
            textBoxSearchProduct.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearchProduct.Location = new Point(426, 6);
            textBoxSearchProduct.Name = "textBoxSearchProduct";
            textBoxSearchProduct.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBoxSearchProduct.Size = new Size(699, 37);
            textBoxSearchProduct.TabIndex = 10;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDeleteProduct.Location = new Point(209, 6);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(211, 39);
            buttonDeleteProduct.TabIndex = 9;
            buttonDeleteProduct.Text = "Xóa sản phẩm đã chọn";
            buttonDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddProduct.Location = new Point(6, 6);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(197, 39);
            buttonAddProduct.TabIndex = 8;
            buttonAddProduct.Text = "Thêm sản phẩm mới";
            buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchCategory
            // 
            textBoxSearchCategory.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearchCategory.Location = new Point(423, 6);
            textBoxSearchCategory.Name = "textBoxSearchCategory";
            textBoxSearchCategory.PlaceholderText = "Nhập vào đây để tìm kiếm";
            textBoxSearchCategory.Size = new Size(699, 37);
            textBoxSearchCategory.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(206, 6);
            button1.Name = "button1";
            button1.Size = new Size(211, 39);
            button1.TabIndex = 9;
            button1.Text = "Xóa danh mục đã chọn";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 6);
            button2.Name = "button2";
            button2.Size = new Size(197, 39);
            button2.TabIndex = 8;
            button2.Text = "Thêm danh mục mới";
            button2.UseVisualStyleBackColor = true;
            // 
            // UserControlAdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlAdmin);
            Name = "UserControlAdminHome";
            Size = new Size(1158, 560);
            tabControlAdmin.ResumeLayout(false);
            tabPageCustumer.ResumeLayout(false);
            tabPageCustumer.PerformLayout();
            tabPageEmployee.ResumeLayout(false);
            tabPageEmployee.PerformLayout();
            tabPageProduct.ResumeLayout(false);
            tabPageProduct.PerformLayout();
            tabPageCategory.ResumeLayout(false);
            tabPageCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustumer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAdmin;
        private TabPage tabPageCustumer;
        private TabPage tabPageEmployee;
        private TabPage tabPageProduct;
        private TabPage tabPageCategory;
        private DataGridView dataGridViewCategory;
        private Button buttonDeleteCustomer;
        private Button buttonAddCustumer;
        private DataGridView dataGridViewCustumer;
        private DataGridView dataGridViewEployee;
        private DataGridView dataGridViewProduct;
        private TextBox textBoxSearchCustomer;
        private TextBox textBoxSearchEmployee;
        private Button buttonDeleteEmployee;
        private Button buttonAddEmployee;
        private TextBox textBoxSearchProduct;
        private Button buttonDeleteProduct;
        private Button buttonAddProduct;
        private TextBox textBoxSearchCategory;
        private Button button1;
        private Button button2;
    }
}
