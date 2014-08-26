namespace GFF
{
    partial class ProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateExpiryProductListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classifyProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkExpiryProductListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailySalesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklySalesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductSalesPriceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSalesReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductsFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.productToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProductsFormToolStripMenuItem,
            this.addNewProductToolStripMenuItem,
            this.updateProductsToolStripMenuItem,
            this.deleteProductsToolStripMenuItem,
            this.classifyProductsToolStripMenuItem,
            this.checkExpiryProductListsToolStripMenuItem,
            this.updateExpiryProductListsToolStripMenuItem});
            this.productToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.addNewProductToolStripMenuItem.Text = "Add New Product";
            // 
            // updateProductsToolStripMenuItem
            // 
            this.updateProductsToolStripMenuItem.Name = "updateProductsToolStripMenuItem";
            this.updateProductsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.updateProductsToolStripMenuItem.Text = "Update Products";
            // 
            // deleteProductsToolStripMenuItem
            // 
            this.deleteProductsToolStripMenuItem.Name = "deleteProductsToolStripMenuItem";
            this.deleteProductsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.deleteProductsToolStripMenuItem.Text = "Delete Products";
            // 
            // updateExpiryProductListsToolStripMenuItem
            // 
            this.updateExpiryProductListsToolStripMenuItem.Name = "updateExpiryProductListsToolStripMenuItem";
            this.updateExpiryProductListsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.updateExpiryProductListsToolStripMenuItem.Text = "Update Expiry Product Lists";
            // 
            // classifyProductsToolStripMenuItem
            // 
            this.classifyProductsToolStripMenuItem.Name = "classifyProductsToolStripMenuItem";
            this.classifyProductsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.classifyProductsToolStripMenuItem.Text = "Classify Products";
            // 
            // checkExpiryProductListsToolStripMenuItem
            // 
            this.checkExpiryProductListsToolStripMenuItem.Name = "checkExpiryProductListsToolStripMenuItem";
            this.checkExpiryProductListsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.checkExpiryProductListsToolStripMenuItem.Text = "Check Expiry Product Lists";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseOrderToolStripMenuItem,
            this.purchaseInvoiceToolStripMenuItem,
            this.purchaseReturnToolStripMenuItem});
            this.purchaseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            // 
            // purchaseInvoiceToolStripMenuItem
            // 
            this.purchaseInvoiceToolStripMenuItem.Name = "purchaseInvoiceToolStripMenuItem";
            this.purchaseInvoiceToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.purchaseInvoiceToolStripMenuItem.Text = "Purchase Invoice";
            // 
            // purchaseReturnToolStripMenuItem
            // 
            this.purchaseReturnToolStripMenuItem.Name = "purchaseReturnToolStripMenuItem";
            this.purchaseReturnToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.purchaseReturnToolStripMenuItem.Text = "Purchase Return";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSalesReceiptToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.salesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailySalesReportToolStripMenuItem,
            this.weeklySalesReportToolStripMenuItem,
            this.viewProductSalesPriceReportToolStripMenuItem,
            this.viewSalesReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // dailySalesReportToolStripMenuItem
            // 
            this.dailySalesReportToolStripMenuItem.Name = "dailySalesReportToolStripMenuItem";
            this.dailySalesReportToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.dailySalesReportToolStripMenuItem.Text = "View Daily Sales Report";
            // 
            // weeklySalesReportToolStripMenuItem
            // 
            this.weeklySalesReportToolStripMenuItem.Name = "weeklySalesReportToolStripMenuItem";
            this.weeklySalesReportToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.weeklySalesReportToolStripMenuItem.Text = "View Weekly Sales Report";
            // 
            // viewProductSalesPriceReportToolStripMenuItem
            // 
            this.viewProductSalesPriceReportToolStripMenuItem.Name = "viewProductSalesPriceReportToolStripMenuItem";
            this.viewProductSalesPriceReportToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.viewProductSalesPriceReportToolStripMenuItem.Text = "View Product Sales Price Report";
            // 
            // viewSalesReportToolStripMenuItem
            // 
            this.viewSalesReportToolStripMenuItem.Name = "viewSalesReportToolStripMenuItem";
            this.viewSalesReportToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.viewSalesReportToolStripMenuItem.Text = "View Sales Report";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help?";
            // 
            // createSalesReceiptToolStripMenuItem
            // 
            this.createSalesReceiptToolStripMenuItem.Name = "createSalesReceiptToolStripMenuItem";
            this.createSalesReceiptToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.createSalesReceiptToolStripMenuItem.Text = "Create Sales Receipt";
            // 
            // viewProductsFormToolStripMenuItem
            // 
            this.viewProductsFormToolStripMenuItem.Name = "viewProductsFormToolStripMenuItem";
            this.viewProductsFormToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.viewProductsFormToolStripMenuItem.Text = "View Products Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Code : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplier Name : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(390, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(390, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productname,
            this.category,
            this.productweight,
            this.unit_price,
            this.quantity,
            this.discount,
            this.description,
            this.select});
            this.dataGridView1.Location = new System.Drawing.Point(29, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 188);
            this.dataGridView1.TabIndex = 9;
            // 
            // productname
            // 
            this.productname.HeaderText = "Product Name";
            this.productname.Name = "productname";
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            // 
            // productweight
            // 
            this.productweight.HeaderText = "Product Weight";
            this.productweight.Name = "productweight";
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "Unit Price";
            this.unit_price.Name = "unit_price";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // discount
            // 
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 25);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 25);
            this.button4.TabIndex = 13;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // select
            // 
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 434);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateExpiryProductListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classifyProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkExpiryProductListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailySalesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklySalesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductSalesPriceReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSalesReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductsFormToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn productweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
    }
}