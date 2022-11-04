
namespace POS_SOFTWARE
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelItems = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_total_text = new System.Windows.Forms.Label();
            this.label_tax_text = new System.Windows.Forms.Label();
            this.label_amount_text = new System.Windows.Forms.Label();
            this.button_pay = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_InvoiceNo = new System.Windows.Forms.Label();
            this.ddlItems = new System.Windows.Forms.ComboBox();
            this.ddlLookup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSalesItem = new System.Windows.Forms.DataGridView();
            this.button_customers = new System.Windows.Forms.Button();
            this.button_sales_refund = new System.Windows.Forms.Button();
            this.button_cashDrw = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_new = new System.Windows.Forms.Button();
            this.button_items = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_storeManager = new System.Windows.Forms.Button();
            this.ItemLookup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelItems.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesItem)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1476, 117);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "POS SOFTWARE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Location = new System.Drawing.Point(2, 640);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1476, 67);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(1292, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(171, 49);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelItems
            // 
            this.panelItems.BackColor = System.Drawing.Color.White;
            this.panelItems.Controls.Add(this.panel5);
            this.panelItems.Controls.Add(this.panel6);
            this.panelItems.Controls.Add(this.dataGridViewSalesItem);
            this.panelItems.Location = new System.Drawing.Point(2, 115);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(1136, 523);
            this.panelItems.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label_total_text);
            this.panel5.Controls.Add(this.label_tax_text);
            this.panel5.Controls.Add(this.label_amount_text);
            this.panel5.Controls.Add(this.button_pay);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Location = new System.Drawing.Point(803, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 523);
            this.panel5.TabIndex = 4;
            // 
            // label_total_text
            // 
            this.label_total_text.AutoSize = true;
            this.label_total_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_text.Location = new System.Drawing.Point(116, 365);
            this.label_total_text.Name = "label_total_text";
            this.label_total_text.Size = new System.Drawing.Size(24, 25);
            this.label_total_text.TabIndex = 16;
            this.label_total_text.Text = "0";
            // 
            // label_tax_text
            // 
            this.label_tax_text.AutoSize = true;
            this.label_tax_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tax_text.Location = new System.Drawing.Point(116, 286);
            this.label_tax_text.Name = "label_tax_text";
            this.label_tax_text.Size = new System.Drawing.Size(24, 25);
            this.label_tax_text.TabIndex = 15;
            this.label_tax_text.Text = "0";
            // 
            // label_amount_text
            // 
            this.label_amount_text.AutoSize = true;
            this.label_amount_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount_text.Location = new System.Drawing.Point(116, 249);
            this.label_amount_text.Name = "label_amount_text";
            this.label_amount_text.Size = new System.Drawing.Size(24, 25);
            this.label_amount_text.TabIndex = 14;
            this.label_amount_text.Text = "0";
            // 
            // button_pay
            // 
            this.button_pay.BackColor = System.Drawing.Color.Green;
            this.button_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pay.ForeColor = System.Drawing.Color.White;
            this.button_pay.Location = new System.Drawing.Point(-3, 454);
            this.button_pay.Name = "button_pay";
            this.button_pay.Size = new System.Drawing.Size(333, 69);
            this.button_pay.TabIndex = 13;
            this.button_pay.Text = "Pay Now";
            this.button_pay.UseVisualStyleBackColor = false;
            this.button_pay.Click += new System.EventHandler(this.button_pay_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total :";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(22, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 2);
            this.panel3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tax :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Amount :";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(333, 69);
            this.button8.TabIndex = 7;
            this.button8.Text = "Clear Items";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label_InvoiceNo);
            this.panel6.Controls.Add(this.ddlItems);
            this.panel6.Controls.Add(this.ddlLookup);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(803, 130);
            this.panel6.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(149, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(149, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Customer :";
            // 
            // label_InvoiceNo
            // 
            this.label_InvoiceNo.AutoSize = true;
            this.label_InvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InvoiceNo.Location = new System.Drawing.Point(149, 21);
            this.label_InvoiceNo.Name = "label_InvoiceNo";
            this.label_InvoiceNo.Size = new System.Drawing.Size(24, 25);
            this.label_InvoiceNo.TabIndex = 7;
            this.label_InvoiceNo.Text = "0";
            // 
            // ddlItems
            // 
            this.ddlItems.FormattingEnabled = true;
            this.ddlItems.Location = new System.Drawing.Point(568, 25);
            this.ddlItems.Name = "ddlItems";
            this.ddlItems.Size = new System.Drawing.Size(202, 24);
            this.ddlItems.TabIndex = 6;
            // 
            // ddlLookup
            // 
            this.ddlLookup.FormattingEnabled = true;
            this.ddlLookup.Location = new System.Drawing.Point(568, 67);
            this.ddlLookup.Name = "ddlLookup";
            this.ddlLookup.Size = new System.Drawing.Size(202, 24);
            this.ddlLookup.TabIndex = 5;
            this.ddlLookup.SelectedIndexChanged += new System.EventHandler(this.ddlLookup_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Item Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lookup Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice No. :";
            // 
            // dataGridViewSalesItem
            // 
            this.dataGridViewSalesItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemLookup,
            this.ItemDescription,
            this.Price,
            this.Tax,
            this.Quantity,
            this.Total});
            this.dataGridViewSalesItem.Location = new System.Drawing.Point(0, 129);
            this.dataGridViewSalesItem.Name = "dataGridViewSalesItem";
            this.dataGridViewSalesItem.RowHeadersWidth = 51;
            this.dataGridViewSalesItem.RowTemplate.Height = 24;
            this.dataGridViewSalesItem.Size = new System.Drawing.Size(803, 394);
            this.dataGridViewSalesItem.TabIndex = 0;
            this.dataGridViewSalesItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewSalesItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSalesItem_CellValueChanged);
            // 
            // button_customers
            // 
            this.button_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_customers.Location = new System.Drawing.Point(0, 150);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(343, 69);
            this.button_customers.TabIndex = 2;
            this.button_customers.Text = "Customers";
            this.button_customers.UseVisualStyleBackColor = true;
            this.button_customers.Click += new System.EventHandler(this.button_customers_Click);
            // 
            // button_sales_refund
            // 
            this.button_sales_refund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sales_refund.Location = new System.Drawing.Point(0, 225);
            this.button_sales_refund.Name = "button_sales_refund";
            this.button_sales_refund.Size = new System.Drawing.Size(343, 69);
            this.button_sales_refund.TabIndex = 3;
            this.button_sales_refund.Text = "Sales/Refund";
            this.button_sales_refund.UseVisualStyleBackColor = true;
            // 
            // button_cashDrw
            // 
            this.button_cashDrw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cashDrw.Location = new System.Drawing.Point(0, 300);
            this.button_cashDrw.Name = "button_cashDrw";
            this.button_cashDrw.Size = new System.Drawing.Size(343, 69);
            this.button_cashDrw.TabIndex = 4;
            this.button_cashDrw.Text = "Cash Drawer";
            this.button_cashDrw.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.button_new);
            this.panel4.Controls.Add(this.button_items);
            this.panel4.Controls.Add(this.button_settings);
            this.panel4.Controls.Add(this.button_storeManager);
            this.panel4.Controls.Add(this.button_cashDrw);
            this.panel4.Controls.Add(this.button_sales_refund);
            this.panel4.Controls.Add(this.button_customers);
            this.panel4.Location = new System.Drawing.Point(1135, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 523);
            this.panel4.TabIndex = 3;
            // 
            // button_new
            // 
            this.button_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new.Location = new System.Drawing.Point(0, 0);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(343, 69);
            this.button_new.TabIndex = 8;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_items
            // 
            this.button_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_items.Location = new System.Drawing.Point(0, 75);
            this.button_items.Name = "button_items";
            this.button_items.Size = new System.Drawing.Size(343, 69);
            this.button_items.TabIndex = 7;
            this.button_items.Text = "Items";
            this.button_items.UseVisualStyleBackColor = true;
            this.button_items.Click += new System.EventHandler(this.button_items_Click);
            // 
            // button_settings
            // 
            this.button_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_settings.Location = new System.Drawing.Point(0, 450);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(343, 69);
            this.button_settings.TabIndex = 6;
            this.button_settings.Text = "Settings";
            this.button_settings.UseVisualStyleBackColor = true;
            // 
            // button_storeManager
            // 
            this.button_storeManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_storeManager.Location = new System.Drawing.Point(0, 375);
            this.button_storeManager.Name = "button_storeManager";
            this.button_storeManager.Size = new System.Drawing.Size(343, 69);
            this.button_storeManager.TabIndex = 5;
            this.button_storeManager.Text = "Store Manager";
            this.button_storeManager.UseVisualStyleBackColor = true;
            // 
            // ItemLookup
            // 
            this.ItemLookup.DataPropertyName = "ItemName";
            this.ItemLookup.HeaderText = "Item Name";
            this.ItemLookup.MinimumWidth = 6;
            this.ItemLookup.Name = "ItemLookup";
            this.ItemLookup.ReadOnly = true;
            this.ItemLookup.Width = 125;
            // 
            // ItemDescription
            // 
            this.ItemDescription.DataPropertyName = "LookupCode";
            this.ItemDescription.HeaderText = "Item Lookup";
            this.ItemDescription.MinimumWidth = 6;
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            this.ItemDescription.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Cost";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Tax
            // 
            this.Tax.DataPropertyName = "TaxId";
            this.Tax.HeaderText = "Tax";
            this.Tax.MinimumWidth = 6;
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            this.Tax.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Price";
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 706);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelItems);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelItems.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesItem)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.DataGridView dataGridViewSalesItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox ddlItems;
        private System.Windows.Forms.ComboBox ddlLookup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_customers;
        private System.Windows.Forms.Button button_sales_refund;
        private System.Windows.Forms.Button button_cashDrw;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_storeManager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button_items;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_pay;
        private System.Windows.Forms.Label label_InvoiceNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_tax_text;
        private System.Windows.Forms.Label label_amount_text;
        private System.Windows.Forms.Label label_total_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemLookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}