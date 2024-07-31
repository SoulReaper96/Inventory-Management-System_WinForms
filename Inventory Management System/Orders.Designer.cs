namespace Inventory_Management_System
{
    partial class Orders
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
            panel1 = new Panel();
            CloseApp_lbl = new Label();
            label2 = new Label();
            label1 = new Label();
            Customer_dgv = new DataGridView();
            label3 = new Label();
            OrderID_tb = new TextBox();
            CustomerID_tb = new TextBox();
            Orders_dtp = new DateTimePicker();
            panel2 = new Panel();
            Products_dgv = new DataGridView();
            label4 = new Label();
            CustomerName_tb = new TextBox();
            AddItems_btn = new Button();
            OrderQty_tb = new TextBox();
            label6 = new Label();
            RemoveItems_btn = new Button();
            label7 = new Label();
            GrandTotal_lbl = new Label();
            ProdCat_cmb = new ComboBox();
            Orders_dgv = new DataGridView();
            InsertOrder_btn = new Button();
            VwOrder_btn = new Button();
            Home_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Customer_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Products_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Orders_dgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(CloseApp_lbl);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 100);
            panel1.TabIndex = 14;
            // 
            // CloseApp_lbl
            // 
            CloseApp_lbl.AutoSize = true;
            CloseApp_lbl.Font = new Font("Arial", 20F);
            CloseApp_lbl.ForeColor = Color.White;
            CloseApp_lbl.Location = new Point(843, 4);
            CloseApp_lbl.Name = "CloseApp_lbl";
            CloseApp_lbl.Size = new Size(31, 32);
            CloseApp_lbl.TabIndex = 3;
            CloseApp_lbl.Text = "X";
            CloseApp_lbl.Click += CloseApp_lbl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 24F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(152, 9);
            label2.Name = "label2";
            label2.Size = new Size(572, 36);
            label2.TabIndex = 2;
            label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(331, 54);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 1;
            label1.Text = "Manage Orders";
            // 
            // Customer_dgv
            // 
            Customer_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Customer_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            Customer_dgv.BackgroundColor = Color.Gainsboro;
            Customer_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Customer_dgv.Location = new Point(12, 147);
            Customer_dgv.Name = "Customer_dgv";
            Customer_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Customer_dgv.Size = new Size(350, 180);
            Customer_dgv.TabIndex = 25;
            Customer_dgv.CellContentClick += Customer_dgv_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20F);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(75, 112);
            label3.Name = "label3";
            label3.Size = new Size(197, 32);
            label3.TabIndex = 26;
            label3.Text = "Customers List";
            // 
            // OrderID_tb
            // 
            OrderID_tb.BackColor = Color.Crimson;
            OrderID_tb.Font = new Font("Arial", 13F);
            OrderID_tb.ForeColor = Color.White;
            OrderID_tb.Location = new Point(77, 360);
            OrderID_tb.Name = "OrderID_tb";
            OrderID_tb.Size = new Size(169, 27);
            OrderID_tb.TabIndex = 27;
            OrderID_tb.Text = "Order ID";
            // 
            // CustomerID_tb
            // 
            CustomerID_tb.BackColor = Color.Crimson;
            CustomerID_tb.Font = new Font("Arial", 13F);
            CustomerID_tb.ForeColor = Color.White;
            CustomerID_tb.Location = new Point(77, 393);
            CustomerID_tb.Name = "CustomerID_tb";
            CustomerID_tb.Size = new Size(169, 27);
            CustomerID_tb.TabIndex = 28;
            CustomerID_tb.Text = "Customer ID";
            // 
            // Orders_dtp
            // 
            Orders_dtp.Format = DateTimePickerFormat.Short;
            Orders_dtp.Location = new Point(77, 503);
            Orders_dtp.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            Orders_dtp.Name = "Orders_dtp";
            Orders_dtp.Size = new Size(169, 25);
            Orders_dtp.TabIndex = 29;
            Orders_dtp.Value = new DateTime(2024, 7, 20, 0, 0, 0, 0);
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 613);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 14);
            panel2.TabIndex = 30;
            // 
            // Products_dgv
            // 
            Products_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Products_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Products_dgv.BackgroundColor = Color.Gainsboro;
            Products_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Products_dgv.Location = new Point(368, 147);
            Products_dgv.Name = "Products_dgv";
            Products_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Products_dgv.Size = new Size(500, 180);
            Products_dgv.TabIndex = 31;
            Products_dgv.CellContentClick += Products_dgv_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 13F);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(77, 479);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 33;
            label4.Text = "Order Date";
            // 
            // CustomerName_tb
            // 
            CustomerName_tb.BackColor = Color.Crimson;
            CustomerName_tb.Font = new Font("Arial", 13F);
            CustomerName_tb.ForeColor = Color.White;
            CustomerName_tb.Location = new Point(77, 426);
            CustomerName_tb.Name = "CustomerName_tb";
            CustomerName_tb.Size = new Size(169, 27);
            CustomerName_tb.TabIndex = 34;
            CustomerName_tb.Text = "Customer Name";
            // 
            // AddItems_btn
            // 
            AddItems_btn.BackColor = Color.Crimson;
            AddItems_btn.FlatStyle = FlatStyle.Flat;
            AddItems_btn.Font = new Font("Arial", 10F);
            AddItems_btn.ForeColor = Color.White;
            AddItems_btn.Location = new Point(631, 344);
            AddItems_btn.Name = "AddItems_btn";
            AddItems_btn.Size = new Size(80, 27);
            AddItems_btn.TabIndex = 36;
            AddItems_btn.Text = "Add Items";
            AddItems_btn.UseVisualStyleBackColor = false;
            AddItems_btn.Click += AddItems_btn_Click;
            // 
            // OrderQty_tb
            // 
            OrderQty_tb.BackColor = Color.Crimson;
            OrderQty_tb.BorderStyle = BorderStyle.FixedSingle;
            OrderQty_tb.Font = new Font("Arial", 13F);
            OrderQty_tb.ForeColor = Color.White;
            OrderQty_tb.Location = new Point(519, 344);
            OrderQty_tb.Name = "OrderQty_tb";
            OrderQty_tb.Size = new Size(73, 27);
            OrderQty_tb.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(405, 349);
            label6.Name = "label6";
            label6.Size = new Size(108, 18);
            label6.TabIndex = 44;
            label6.Text = "Order Quantity";
            // 
            // RemoveItems_btn
            // 
            RemoveItems_btn.BackColor = Color.Crimson;
            RemoveItems_btn.FlatStyle = FlatStyle.Flat;
            RemoveItems_btn.Font = new Font("Arial", 10F);
            RemoveItems_btn.ForeColor = Color.White;
            RemoveItems_btn.Location = new Point(717, 344);
            RemoveItems_btn.Name = "RemoveItems_btn";
            RemoveItems_btn.Size = new Size(80, 27);
            RemoveItems_btn.TabIndex = 51;
            RemoveItems_btn.Text = "Remove";
            RemoveItems_btn.UseVisualStyleBackColor = false;
            RemoveItems_btn.Click += RemoveItems_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(519, 585);
            label7.Name = "label7";
            label7.Size = new Size(87, 18);
            label7.TabIndex = 54;
            label7.Text = "Grand Total";
            // 
            // GrandTotal_lbl
            // 
            GrandTotal_lbl.BackColor = Color.Crimson;
            GrandTotal_lbl.FlatStyle = FlatStyle.Flat;
            GrandTotal_lbl.ForeColor = Color.White;
            GrandTotal_lbl.Location = new Point(612, 582);
            GrandTotal_lbl.Name = "GrandTotal_lbl";
            GrandTotal_lbl.Size = new Size(80, 25);
            GrandTotal_lbl.TabIndex = 53;
            GrandTotal_lbl.Text = "0";
            GrandTotal_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProdCat_cmb
            // 
            ProdCat_cmb.BackColor = Color.Crimson;
            ProdCat_cmb.FlatStyle = FlatStyle.Flat;
            ProdCat_cmb.ForeColor = Color.White;
            ProdCat_cmb.FormattingEnabled = true;
            ProdCat_cmb.Location = new Point(510, 116);
            ProdCat_cmb.Name = "ProdCat_cmb";
            ProdCat_cmb.Size = new Size(169, 25);
            ProdCat_cmb.TabIndex = 55;
            ProdCat_cmb.Text = "Category";
            ProdCat_cmb.SelectionChangeCommitted += ProdCat_cmb_SelectionChangeCommitted;
            // 
            // Orders_dgv
            // 
            Orders_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Orders_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Orders_dgv.BackgroundColor = Color.Gainsboro;
            Orders_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Orders_dgv.Location = new Point(368, 392);
            Orders_dgv.Name = "Orders_dgv";
            Orders_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Orders_dgv.Size = new Size(500, 180);
            Orders_dgv.TabIndex = 56;
            Orders_dgv.CellContentClick += Orders_dgv_CellContentClick;
            // 
            // InsertOrder_btn
            // 
            InsertOrder_btn.BackColor = Color.Crimson;
            InsertOrder_btn.FlatStyle = FlatStyle.Flat;
            InsertOrder_btn.Font = new Font("Arial", 10F);
            InsertOrder_btn.ForeColor = Color.White;
            InsertOrder_btn.Location = new Point(57, 572);
            InsertOrder_btn.Name = "InsertOrder_btn";
            InsertOrder_btn.Size = new Size(100, 27);
            InsertOrder_btn.TabIndex = 57;
            InsertOrder_btn.Text = "Insert Order";
            InsertOrder_btn.UseVisualStyleBackColor = false;
            InsertOrder_btn.Click += InsertOrder_btn_Click;
            // 
            // VwOrder_btn
            // 
            VwOrder_btn.BackColor = Color.Crimson;
            VwOrder_btn.FlatStyle = FlatStyle.Flat;
            VwOrder_btn.Font = new Font("Arial", 10F);
            VwOrder_btn.ForeColor = Color.White;
            VwOrder_btn.Location = new Point(163, 572);
            VwOrder_btn.Name = "VwOrder_btn";
            VwOrder_btn.Size = new Size(100, 27);
            VwOrder_btn.TabIndex = 58;
            VwOrder_btn.Text = "View Orders";
            VwOrder_btn.UseVisualStyleBackColor = false;
            VwOrder_btn.Click += VwOrder_btn_Click;
            // 
            // Home_btn
            // 
            Home_btn.BackColor = Color.Crimson;
            Home_btn.FlatStyle = FlatStyle.Flat;
            Home_btn.ForeColor = Color.White;
            Home_btn.Location = new Point(802, 577);
            Home_btn.Name = "Home_btn";
            Home_btn.Size = new Size(66, 30);
            Home_btn.TabIndex = 59;
            Home_btn.Text = "Home";
            Home_btn.UseVisualStyleBackColor = false;
            Home_btn.Click += Home_btn_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 627);
            Controls.Add(Home_btn);
            Controls.Add(VwOrder_btn);
            Controls.Add(InsertOrder_btn);
            Controls.Add(Orders_dgv);
            Controls.Add(ProdCat_cmb);
            Controls.Add(label7);
            Controls.Add(GrandTotal_lbl);
            Controls.Add(RemoveItems_btn);
            Controls.Add(label6);
            Controls.Add(OrderQty_tb);
            Controls.Add(AddItems_btn);
            Controls.Add(CustomerName_tb);
            Controls.Add(label4);
            Controls.Add(Products_dgv);
            Controls.Add(panel2);
            Controls.Add(Orders_dtp);
            Controls.Add(CustomerID_tb);
            Controls.Add(OrderID_tb);
            Controls.Add(label3);
            Controls.Add(Customer_dgv);
            Controls.Add(panel1);
            Font = new Font("Arial", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Customer_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)Products_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)Orders_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label CloseApp_lbl;
        private Label label2;
        private Label label1;
        private DataGridView Customer_dgv;
        private Label label3;
        private TextBox OrderID_tb;
        private TextBox CustomerID_tb;
        private DateTimePicker Orders_dtp;
        private Panel panel2;
        private DataGridView Products_dgv;
        private Label label4;
        private TextBox CustomerName_tb;
        private Button AddItems_btn;
        private TextBox OrderQty_tb;
        private Label label6;
        private Button RemoveItems_btn;
        private Label label7;
        private Label GrandTotal_lbl;
        private ComboBox ProdCat_cmb;
        private DataGridView Orders_dgv;
        private Button InsertOrder_btn;
        private Button VwOrder_btn;
        private Button Home_btn;
    }
}