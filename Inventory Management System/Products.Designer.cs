namespace Inventory_Management_System
{
    partial class Products
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
            label3 = new Label();
            Products_dgv = new DataGridView();
            panel2 = new Panel();
            Home_btn = new Button();
            Delete_btn = new Button();
            Edit_btn = new Button();
            Add_btn = new Button();
            ProdPrice_tb = new TextBox();
            ProdQty_tb = new TextBox();
            ProdName_tb = new TextBox();
            ProdId_tb = new TextBox();
            ProdDesc_tb = new TextBox();
            ProdCat_cmb = new ComboBox();
            Search_cmb = new ComboBox();
            Search_btn = new Button();
            Refresh_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Products_dgv).BeginInit();
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
            panel1.Size = new Size(914, 100);
            panel1.TabIndex = 13;
            // 
            // CloseApp_lbl
            // 
            CloseApp_lbl.AutoSize = true;
            CloseApp_lbl.Font = new Font("Arial", 20F);
            CloseApp_lbl.ForeColor = Color.White;
            CloseApp_lbl.Location = new Point(880, 1);
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
            label1.Size = new Size(227, 32);
            label1.TabIndex = 1;
            label1.Text = "Manage Products";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20F);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(477, 120);
            label3.Name = "label3";
            label3.Size = new Size(172, 32);
            label3.TabIndex = 15;
            label3.Text = "Products List";
            // 
            // Products_dgv
            // 
            Products_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Products_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            Products_dgv.BackgroundColor = Color.Gainsboro;
            Products_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Products_dgv.Location = new Point(263, 206);
            Products_dgv.Name = "Products_dgv";
            Products_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Products_dgv.Size = new Size(639, 344);
            Products_dgv.TabIndex = 24;
            Products_dgv.CellContentClick += Products_dgv_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 556);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 14);
            panel2.TabIndex = 23;
            // 
            // Home_btn
            // 
            Home_btn.BackColor = Color.Crimson;
            Home_btn.FlatStyle = FlatStyle.Flat;
            Home_btn.ForeColor = Color.White;
            Home_btn.Location = new Point(84, 442);
            Home_btn.Name = "Home_btn";
            Home_btn.Size = new Size(66, 30);
            Home_btn.TabIndex = 22;
            Home_btn.Text = "Home";
            Home_btn.UseVisualStyleBackColor = false;
            Home_btn.Click += Home_btn_Click;
            // 
            // Delete_btn
            // 
            Delete_btn.BackColor = Color.Crimson;
            Delete_btn.FlatStyle = FlatStyle.Flat;
            Delete_btn.ForeColor = Color.White;
            Delete_btn.Location = new Point(156, 406);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(66, 30);
            Delete_btn.TabIndex = 21;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = false;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Edit_btn
            // 
            Edit_btn.BackColor = Color.Crimson;
            Edit_btn.FlatStyle = FlatStyle.Flat;
            Edit_btn.ForeColor = Color.White;
            Edit_btn.Location = new Point(84, 406);
            Edit_btn.Name = "Edit_btn";
            Edit_btn.Size = new Size(66, 30);
            Edit_btn.TabIndex = 20;
            Edit_btn.Text = "Edit";
            Edit_btn.UseVisualStyleBackColor = false;
            Edit_btn.Click += Edit_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.BackColor = Color.Crimson;
            Add_btn.FlatStyle = FlatStyle.Flat;
            Add_btn.ForeColor = Color.White;
            Add_btn.Location = new Point(12, 406);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(66, 30);
            Add_btn.TabIndex = 19;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // ProdPrice_tb
            // 
            ProdPrice_tb.BackColor = Color.Crimson;
            ProdPrice_tb.Font = new Font("Arial", 13F);
            ProdPrice_tb.ForeColor = Color.White;
            ProdPrice_tb.Location = new Point(12, 227);
            ProdPrice_tb.Name = "ProdPrice_tb";
            ProdPrice_tb.Size = new Size(169, 27);
            ProdPrice_tb.TabIndex = 18;
            ProdPrice_tb.Text = "Product Price";
            // 
            // ProdQty_tb
            // 
            ProdQty_tb.BackColor = Color.Crimson;
            ProdQty_tb.Font = new Font("Arial", 13F);
            ProdQty_tb.ForeColor = Color.White;
            ProdQty_tb.Location = new Point(12, 194);
            ProdQty_tb.Name = "ProdQty_tb";
            ProdQty_tb.Size = new Size(169, 27);
            ProdQty_tb.TabIndex = 17;
            ProdQty_tb.Text = "Product Quantity";
            // 
            // ProdName_tb
            // 
            ProdName_tb.BackColor = Color.Crimson;
            ProdName_tb.Font = new Font("Arial", 13F);
            ProdName_tb.ForeColor = Color.White;
            ProdName_tb.Location = new Point(12, 161);
            ProdName_tb.Name = "ProdName_tb";
            ProdName_tb.Size = new Size(169, 27);
            ProdName_tb.TabIndex = 16;
            ProdName_tb.Text = "Product Name";
            // 
            // ProdId_tb
            // 
            ProdId_tb.BackColor = Color.Crimson;
            ProdId_tb.Font = new Font("Arial", 13F);
            ProdId_tb.ForeColor = Color.White;
            ProdId_tb.Location = new Point(12, 128);
            ProdId_tb.Name = "ProdId_tb";
            ProdId_tb.Size = new Size(169, 27);
            ProdId_tb.TabIndex = 14;
            ProdId_tb.Text = "Product ID";
            // 
            // ProdDesc_tb
            // 
            ProdDesc_tb.BackColor = Color.Crimson;
            ProdDesc_tb.Font = new Font("Arial", 13F);
            ProdDesc_tb.ForeColor = Color.White;
            ProdDesc_tb.Location = new Point(12, 260);
            ProdDesc_tb.Multiline = true;
            ProdDesc_tb.Name = "ProdDesc_tb";
            ProdDesc_tb.Size = new Size(169, 83);
            ProdDesc_tb.TabIndex = 25;
            ProdDesc_tb.Text = "Product Description";
            // 
            // ProdCat_cmb
            // 
            ProdCat_cmb.BackColor = Color.Crimson;
            ProdCat_cmb.FlatStyle = FlatStyle.Flat;
            ProdCat_cmb.ForeColor = Color.White;
            ProdCat_cmb.FormattingEnabled = true;
            ProdCat_cmb.Location = new Point(12, 349);
            ProdCat_cmb.Name = "ProdCat_cmb";
            ProdCat_cmb.Size = new Size(169, 25);
            ProdCat_cmb.TabIndex = 26;
            ProdCat_cmb.Text = "Category";
            // 
            // Search_cmb
            // 
            Search_cmb.BackColor = Color.Crimson;
            Search_cmb.FlatStyle = FlatStyle.Flat;
            Search_cmb.ForeColor = Color.White;
            Search_cmb.FormattingEnabled = true;
            Search_cmb.Location = new Point(425, 175);
            Search_cmb.Name = "Search_cmb";
            Search_cmb.Size = new Size(169, 25);
            Search_cmb.TabIndex = 27;
            Search_cmb.Text = "Category";
            // 
            // Search_btn
            // 
            Search_btn.BackColor = Color.Crimson;
            Search_btn.FlatStyle = FlatStyle.Flat;
            Search_btn.ForeColor = Color.White;
            Search_btn.Location = new Point(600, 170);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(70, 30);
            Search_btn.TabIndex = 28;
            Search_btn.Text = "Search";
            Search_btn.UseVisualStyleBackColor = false;
            Search_btn.Click += Search_btn_Click;
            // 
            // Refresh_btn
            // 
            Refresh_btn.BackColor = Color.Crimson;
            Refresh_btn.FlatStyle = FlatStyle.Flat;
            Refresh_btn.ForeColor = Color.White;
            Refresh_btn.Location = new Point(676, 170);
            Refresh_btn.Name = "Refresh_btn";
            Refresh_btn.Size = new Size(70, 30);
            Refresh_btn.TabIndex = 29;
            Refresh_btn.Text = "Refresh";
            Refresh_btn.UseVisualStyleBackColor = false;
            Refresh_btn.Click += Refresh_btn_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 570);
            Controls.Add(Refresh_btn);
            Controls.Add(Search_btn);
            Controls.Add(Search_cmb);
            Controls.Add(ProdCat_cmb);
            Controls.Add(ProdDesc_tb);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(Products_dgv);
            Controls.Add(panel2);
            Controls.Add(Home_btn);
            Controls.Add(Delete_btn);
            Controls.Add(Edit_btn);
            Controls.Add(Add_btn);
            Controls.Add(ProdPrice_tb);
            Controls.Add(ProdQty_tb);
            Controls.Add(ProdName_tb);
            Controls.Add(ProdId_tb);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Products_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label CloseApp_lbl;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView Products_dgv;
        private Panel panel2;
        private Button Home_btn;
        private Button Delete_btn;
        private Button Edit_btn;
        private Button Add_btn;
        private TextBox ProdPrice_tb;
        private TextBox ProdQty_tb;
        private TextBox ProdName_tb;
        private TextBox ProdId_tb;
        private TextBox ProdDesc_tb;
        private ComboBox ProdCat_cmb;
        private ComboBox Search_cmb;
        private Button Search_btn;
        private Button Refresh_btn;
    }
}