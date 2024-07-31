namespace Inventory_Management_System
{
    partial class Customers
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
            Customer_dgv = new DataGridView();
            panel2 = new Panel();
            Home_btn = new Button();
            Delete_btn = new Button();
            Edit_btn = new Button();
            Add_btn = new Button();
            CustomerPhone_tb = new TextBox();
            CustomerName_tb = new TextBox();
            CustomerID_tb = new TextBox();
            panel3 = new Panel();
            OrdersCnt_lbl = new Label();
            label4 = new Label();
            panel4 = new Panel();
            OrdersAmnt_lbl = new Label();
            label7 = new Label();
            panel5 = new Panel();
            OrdersLastD_lbl = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Customer_dgv).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.Size = new Size(840, 100);
            panel1.TabIndex = 13;
            // 
            // CloseApp_lbl
            // 
            CloseApp_lbl.AutoSize = true;
            CloseApp_lbl.Font = new Font("Arial", 20F);
            CloseApp_lbl.ForeColor = Color.White;
            CloseApp_lbl.Location = new Point(804, 5);
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
            label1.Size = new Size(252, 32);
            label1.TabIndex = 1;
            label1.Text = "Manage Customers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20F);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(445, 121);
            label3.Name = "label3";
            label3.Size = new Size(197, 32);
            label3.TabIndex = 15;
            label3.Text = "Customers List";
            // 
            // Customer_dgv
            // 
            Customer_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Customer_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            Customer_dgv.BackgroundColor = Color.Gainsboro;
            Customer_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Customer_dgv.Location = new Point(263, 161);
            Customer_dgv.Name = "Customer_dgv";
            Customer_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Customer_dgv.Size = new Size(558, 344);
            Customer_dgv.TabIndex = 24;
            Customer_dgv.CellContentClick += Customer_dgv_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 611);
            panel2.Name = "panel2";
            panel2.Size = new Size(840, 14);
            panel2.TabIndex = 23;
            // 
            // Home_btn
            // 
            Home_btn.BackColor = Color.Crimson;
            Home_btn.FlatStyle = FlatStyle.Flat;
            Home_btn.ForeColor = Color.White;
            Home_btn.Location = new Point(84, 477);
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
            Delete_btn.Location = new Point(156, 441);
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
            Edit_btn.Location = new Point(84, 441);
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
            Add_btn.Location = new Point(12, 441);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(66, 30);
            Add_btn.TabIndex = 19;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // CustomerPhone_tb
            // 
            CustomerPhone_tb.BackColor = Color.Crimson;
            CustomerPhone_tb.Font = new Font("Arial", 13F);
            CustomerPhone_tb.ForeColor = Color.White;
            CustomerPhone_tb.Location = new Point(35, 378);
            CustomerPhone_tb.Name = "CustomerPhone_tb";
            CustomerPhone_tb.Size = new Size(169, 27);
            CustomerPhone_tb.TabIndex = 18;
            CustomerPhone_tb.Text = "Customer Phone";
            // 
            // CustomerName_tb
            // 
            CustomerName_tb.BackColor = Color.Crimson;
            CustomerName_tb.Font = new Font("Arial", 13F);
            CustomerName_tb.ForeColor = Color.White;
            CustomerName_tb.Location = new Point(35, 316);
            CustomerName_tb.Name = "CustomerName_tb";
            CustomerName_tb.Size = new Size(169, 27);
            CustomerName_tb.TabIndex = 16;
            CustomerName_tb.Text = "Customer Name";
            // 
            // CustomerID_tb
            // 
            CustomerID_tb.BackColor = Color.Crimson;
            CustomerID_tb.Font = new Font("Arial", 13F);
            CustomerID_tb.ForeColor = Color.White;
            CustomerID_tb.Location = new Point(35, 258);
            CustomerID_tb.Name = "CustomerID_tb";
            CustomerID_tb.Size = new Size(169, 27);
            CustomerID_tb.TabIndex = 14;
            CustomerID_tb.Text = "Customer ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleVioletRed;
            panel3.Controls.Add(OrdersCnt_lbl);
            panel3.Controls.Add(label4);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(263, 515);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 90);
            panel3.TabIndex = 25;
            // 
            // OrdersCnt_lbl
            // 
            OrdersCnt_lbl.AutoSize = true;
            OrdersCnt_lbl.Font = new Font("Arial", 13F);
            OrdersCnt_lbl.ForeColor = Color.White;
            OrdersCnt_lbl.Location = new Point(54, 43);
            OrdersCnt_lbl.Name = "OrdersCnt_lbl";
            OrdersCnt_lbl.Size = new Size(65, 21);
            OrdersCnt_lbl.TabIndex = 5;
            OrdersCnt_lbl.Text = "Orders";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11F, FontStyle.Bold | FontStyle.Underline);
            label4.ForeColor = Color.White;
            label4.Location = new Point(4, 4);
            label4.Name = "label4";
            label4.Size = new Size(105, 18);
            label4.TabIndex = 4;
            label4.Text = "Orders Count";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SeaGreen;
            panel4.Controls.Add(OrdersAmnt_lbl);
            panel4.Controls.Add(label7);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(452, 515);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 90);
            panel4.TabIndex = 26;
            // 
            // OrdersAmnt_lbl
            // 
            OrdersAmnt_lbl.AutoSize = true;
            OrdersAmnt_lbl.Font = new Font("Arial", 13F);
            OrdersAmnt_lbl.ForeColor = Color.White;
            OrdersAmnt_lbl.Location = new Point(54, 43);
            OrdersAmnt_lbl.Name = "OrdersAmnt_lbl";
            OrdersAmnt_lbl.Size = new Size(70, 21);
            OrdersAmnt_lbl.TabIndex = 5;
            OrdersAmnt_lbl.Text = "Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11F, FontStyle.Bold | FontStyle.Underline);
            label7.ForeColor = Color.White;
            label7.Location = new Point(4, 4);
            label7.Name = "label7";
            label7.Size = new Size(114, 18);
            label7.TabIndex = 4;
            label7.Text = "Orders Amount";
            // 
            // panel5
            // 
            panel5.BackColor = Color.RoyalBlue;
            panel5.Controls.Add(OrdersLastD_lbl);
            panel5.Controls.Add(label9);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(641, 515);
            panel5.Name = "panel5";
            panel5.Size = new Size(180, 90);
            panel5.TabIndex = 26;
            // 
            // OrdersLastD_lbl
            // 
            OrdersLastD_lbl.AutoSize = true;
            OrdersLastD_lbl.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdersLastD_lbl.ForeColor = Color.White;
            OrdersLastD_lbl.Location = new Point(16, 43);
            OrdersLastD_lbl.Name = "OrdersLastD_lbl";
            OrdersLastD_lbl.Size = new Size(146, 18);
            OrdersLastD_lbl.TabIndex = 5;
            OrdersLastD_lbl.Text = "yyyy/mm/dd 00:00:00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11F, FontStyle.Bold | FontStyle.Underline);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 4);
            label9.Name = "label9";
            label9.Size = new Size(121, 18);
            label9.TabIndex = 4;
            label9.Text = "Last Order Date";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 625);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(Customer_dgv);
            Controls.Add(panel2);
            Controls.Add(Home_btn);
            Controls.Add(Delete_btn);
            Controls.Add(Edit_btn);
            Controls.Add(Add_btn);
            Controls.Add(CustomerPhone_tb);
            Controls.Add(CustomerName_tb);
            Controls.Add(CustomerID_tb);
            Font = new Font("Arial", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Customer_dgv).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label CloseApp_lbl;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView Customer_dgv;
        private Panel panel2;
        private Button Home_btn;
        private Button Delete_btn;
        private Button Edit_btn;
        private Button Add_btn;
        private TextBox CustomerPhone_tb;
        private TextBox CustomerName_tb;
        private TextBox CustomerID_tb;
        private Panel panel3;
        private Label OrdersCnt_lbl;
        private Label label4;
        private Panel panel4;
        private Label OrdersAmnt_lbl;
        private Label label7;
        private Panel panel5;
        private Label OrdersLastD_lbl;
        private Label label9;
    }
}