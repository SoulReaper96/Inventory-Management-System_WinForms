namespace Inventory_Management_System
{
    partial class Users
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
            Username_tb = new TextBox();
            Fullname_tb = new TextBox();
            Password_tb = new TextBox();
            Telephone_tb = new TextBox();
            Add_btn = new Button();
            Edit_btn = new Button();
            Delete_btn = new Button();
            Home_btn = new Button();
            panel2 = new Panel();
            Users_dgv = new DataGridView();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Users_dgv).BeginInit();
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
            panel1.TabIndex = 0;
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
            label1.Size = new Size(191, 32);
            label1.TabIndex = 1;
            label1.Text = "Manage Users";
            // 
            // Username_tb
            // 
            Username_tb.BackColor = Color.Crimson;
            Username_tb.Font = new Font("Arial", 13F);
            Username_tb.ForeColor = Color.White;
            Username_tb.Location = new Point(12, 128);
            Username_tb.Name = "Username_tb";
            Username_tb.Size = new Size(169, 27);
            Username_tb.TabIndex = 3;
            Username_tb.Text = "Username";
            // 
            // Fullname_tb
            // 
            Fullname_tb.BackColor = Color.Crimson;
            Fullname_tb.Font = new Font("Arial", 13F);
            Fullname_tb.ForeColor = Color.White;
            Fullname_tb.Location = new Point(12, 161);
            Fullname_tb.Name = "Fullname_tb";
            Fullname_tb.Size = new Size(169, 27);
            Fullname_tb.TabIndex = 4;
            Fullname_tb.Text = "Full name(s)";
            // 
            // Password_tb
            // 
            Password_tb.BackColor = Color.Crimson;
            Password_tb.Font = new Font("Arial", 13F);
            Password_tb.ForeColor = Color.White;
            Password_tb.Location = new Point(12, 194);
            Password_tb.Name = "Password_tb";
            Password_tb.Size = new Size(169, 27);
            Password_tb.TabIndex = 5;
            Password_tb.Text = "Password";
            // 
            // Telephone_tb
            // 
            Telephone_tb.BackColor = Color.Crimson;
            Telephone_tb.Font = new Font("Arial", 13F);
            Telephone_tb.ForeColor = Color.White;
            Telephone_tb.Location = new Point(12, 227);
            Telephone_tb.Name = "Telephone_tb";
            Telephone_tb.Size = new Size(169, 27);
            Telephone_tb.TabIndex = 6;
            Telephone_tb.Text = "Telephone";
            // 
            // Add_btn
            // 
            Add_btn.BackColor = Color.Crimson;
            Add_btn.FlatStyle = FlatStyle.Flat;
            Add_btn.ForeColor = Color.White;
            Add_btn.Location = new Point(12, 287);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(66, 30);
            Add_btn.TabIndex = 7;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // Edit_btn
            // 
            Edit_btn.BackColor = Color.Crimson;
            Edit_btn.FlatStyle = FlatStyle.Flat;
            Edit_btn.ForeColor = Color.White;
            Edit_btn.Location = new Point(84, 287);
            Edit_btn.Name = "Edit_btn";
            Edit_btn.Size = new Size(66, 30);
            Edit_btn.TabIndex = 8;
            Edit_btn.Text = "Edit";
            Edit_btn.UseVisualStyleBackColor = false;
            Edit_btn.Click += Edit_btn_Click;
            // 
            // Delete_btn
            // 
            Delete_btn.BackColor = Color.Crimson;
            Delete_btn.FlatStyle = FlatStyle.Flat;
            Delete_btn.ForeColor = Color.White;
            Delete_btn.Location = new Point(156, 287);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(66, 30);
            Delete_btn.TabIndex = 9;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = false;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Home_btn
            // 
            Home_btn.BackColor = Color.Crimson;
            Home_btn.FlatStyle = FlatStyle.Flat;
            Home_btn.ForeColor = Color.White;
            Home_btn.Location = new Point(84, 323);
            Home_btn.Name = "Home_btn";
            Home_btn.Size = new Size(66, 30);
            Home_btn.TabIndex = 10;
            Home_btn.Text = "Home";
            Home_btn.UseVisualStyleBackColor = false;
            Home_btn.Click += Home_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 511);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 14);
            panel2.TabIndex = 11;
            // 
            // Users_dgv
            // 
            Users_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Users_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            Users_dgv.BackgroundColor = Color.Gainsboro;
            Users_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Users_dgv.Location = new Point(263, 161);
            Users_dgv.Name = "Users_dgv";
            Users_dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Users_dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            Users_dgv.Size = new Size(639, 344);
            Users_dgv.TabIndex = 12;
            Users_dgv.CellContentClick += Users_dgv_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20F);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(482, 120);
            label3.Name = "label3";
            label3.Size = new Size(191, 32);
            label3.TabIndex = 4;
            label3.Text = "Manage Users";
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 525);
            Controls.Add(label3);
            Controls.Add(Users_dgv);
            Controls.Add(panel2);
            Controls.Add(Home_btn);
            Controls.Add(Delete_btn);
            Controls.Add(Edit_btn);
            Controls.Add(Add_btn);
            Controls.Add(Telephone_tb);
            Controls.Add(Password_tb);
            Controls.Add(Fullname_tb);
            Controls.Add(Username_tb);
            Controls.Add(panel1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Users_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox Username_tb;
        private TextBox Fullname_tb;
        private TextBox Password_tb;
        private TextBox Telephone_tb;
        private Button Add_btn;
        private Button Edit_btn;
        private Button Delete_btn;
        private Button Home_btn;
        private Panel panel2;
        private DataGridView Users_dgv;
        private Label CloseApp_lbl;
        private Label label3;
    }
}