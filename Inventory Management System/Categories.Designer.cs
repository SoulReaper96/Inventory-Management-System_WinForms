namespace Inventory_Management_System
{
    partial class Categories
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
            Categories_dgv = new DataGridView();
            panel2 = new Panel();
            Home_btn = new Button();
            Delete_btn = new Button();
            Edit_btn = new Button();
            Add_btn = new Button();
            CategoryName_tb = new TextBox();
            CategoryID_tb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Categories_dgv).BeginInit();
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
            panel1.TabIndex = 25;
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
            label1.Size = new Size(252, 32);
            label1.TabIndex = 1;
            label1.Text = "Manage Categories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20F);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(482, 120);
            label3.Name = "label3";
            label3.Size = new Size(252, 32);
            label3.TabIndex = 27;
            label3.Text = "Manage Categories";
            // 
            // Categories_dgv
            // 
            Categories_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Categories_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            Categories_dgv.BackgroundColor = Color.Gainsboro;
            Categories_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Categories_dgv.Location = new Point(263, 161);
            Categories_dgv.Name = "Categories_dgv";
            Categories_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Categories_dgv.Size = new Size(639, 344);
            Categories_dgv.TabIndex = 35;
            Categories_dgv.CellContentClick += Categories_dgv_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 511);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 14);
            panel2.TabIndex = 34;
            // 
            // Home_btn
            // 
            Home_btn.BackColor = Color.Crimson;
            Home_btn.FlatStyle = FlatStyle.Flat;
            Home_btn.ForeColor = Color.White;
            Home_btn.Location = new Point(84, 249);
            Home_btn.Name = "Home_btn";
            Home_btn.Size = new Size(66, 30);
            Home_btn.TabIndex = 33;
            Home_btn.Text = "Home";
            Home_btn.UseVisualStyleBackColor = false;
            Home_btn.Click += Home_btn_Click;
            // 
            // Delete_btn
            // 
            Delete_btn.BackColor = Color.Crimson;
            Delete_btn.FlatStyle = FlatStyle.Flat;
            Delete_btn.ForeColor = Color.White;
            Delete_btn.Location = new Point(156, 213);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(66, 30);
            Delete_btn.TabIndex = 32;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = false;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Edit_btn
            // 
            Edit_btn.BackColor = Color.Crimson;
            Edit_btn.FlatStyle = FlatStyle.Flat;
            Edit_btn.ForeColor = Color.White;
            Edit_btn.Location = new Point(84, 213);
            Edit_btn.Name = "Edit_btn";
            Edit_btn.Size = new Size(66, 30);
            Edit_btn.TabIndex = 31;
            Edit_btn.Text = "Edit";
            Edit_btn.UseVisualStyleBackColor = false;
            Edit_btn.Click += Edit_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.BackColor = Color.Crimson;
            Add_btn.FlatStyle = FlatStyle.Flat;
            Add_btn.ForeColor = Color.White;
            Add_btn.Location = new Point(12, 213);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(66, 30);
            Add_btn.TabIndex = 30;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // CategoryName_tb
            // 
            CategoryName_tb.BackColor = Color.Crimson;
            CategoryName_tb.Font = new Font("Arial", 13F);
            CategoryName_tb.ForeColor = Color.White;
            CategoryName_tb.Location = new Point(12, 161);
            CategoryName_tb.Name = "CategoryName_tb";
            CategoryName_tb.Size = new Size(169, 27);
            CategoryName_tb.TabIndex = 28;
            CategoryName_tb.Text = "Category Name";
            // 
            // CategoryID_tb
            // 
            CategoryID_tb.BackColor = Color.Crimson;
            CategoryID_tb.Font = new Font("Arial", 13F);
            CategoryID_tb.ForeColor = Color.White;
            CategoryID_tb.Location = new Point(12, 128);
            CategoryID_tb.Name = "CategoryID_tb";
            CategoryID_tb.Size = new Size(169, 27);
            CategoryID_tb.TabIndex = 26;
            CategoryID_tb.Text = "Category ID";
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 525);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(Categories_dgv);
            Controls.Add(panel2);
            Controls.Add(Home_btn);
            Controls.Add(Delete_btn);
            Controls.Add(Edit_btn);
            Controls.Add(Add_btn);
            Controls.Add(CategoryName_tb);
            Controls.Add(CategoryID_tb);
            Font = new Font("Arial", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Categories_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label CloseApp_lbl;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView Categories_dgv;
        private Panel panel2;
        private Button Home_btn;
        private Button Delete_btn;
        private Button Edit_btn;
        private Button Add_btn;
        private TextBox CategoryName_tb;
        private TextBox CategoryID_tb;
    }
}