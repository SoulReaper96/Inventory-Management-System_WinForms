namespace Inventory_Management_System
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel1 = new Panel();
            CloseApp_lbl = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            Categories_pb = new PictureBox();
            Users_pb = new PictureBox();
            Orders_pb = new PictureBox();
            Products_pb = new PictureBox();
            Customers_pb = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Logout_pb = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Categories_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Users_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Orders_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Products_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Customers_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logout_pb).BeginInit();
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
            panel1.Size = new Size(675, 100);
            panel1.TabIndex = 24;
            // 
            // CloseApp_lbl
            // 
            CloseApp_lbl.AutoSize = true;
            CloseApp_lbl.Font = new Font("Arial", 20F);
            CloseApp_lbl.ForeColor = Color.White;
            CloseApp_lbl.Location = new Point(639, 5);
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
            label2.Location = new Point(32, 9);
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
            label1.Location = new Point(246, 55);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 1;
            label1.Text = "Main Menu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 496);
            panel2.Name = "panel2";
            panel2.Size = new Size(675, 14);
            panel2.TabIndex = 25;
            // 
            // Categories_pb
            // 
            Categories_pb.BorderStyle = BorderStyle.FixedSingle;
            Categories_pb.Image = (Image)resources.GetObject("Categories_pb.Image");
            Categories_pb.Location = new Point(15, 145);
            Categories_pb.Name = "Categories_pb";
            Categories_pb.Size = new Size(120, 120);
            Categories_pb.SizeMode = PictureBoxSizeMode.Zoom;
            Categories_pb.TabIndex = 4;
            Categories_pb.TabStop = false;
            Categories_pb.Click += Categories_pb_Click;
            // 
            // Users_pb
            // 
            Users_pb.BorderStyle = BorderStyle.FixedSingle;
            Users_pb.Image = (Image)resources.GetObject("Users_pb.Image");
            Users_pb.Location = new Point(287, 336);
            Users_pb.Name = "Users_pb";
            Users_pb.Size = new Size(120, 120);
            Users_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Users_pb.TabIndex = 26;
            Users_pb.TabStop = false;
            Users_pb.Click += Users_pb_Click;
            // 
            // Orders_pb
            // 
            Orders_pb.BorderStyle = BorderStyle.FixedSingle;
            Orders_pb.Image = (Image)resources.GetObject("Orders_pb.Image");
            Orders_pb.Location = new Point(543, 145);
            Orders_pb.Name = "Orders_pb";
            Orders_pb.Size = new Size(120, 120);
            Orders_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Orders_pb.TabIndex = 27;
            Orders_pb.TabStop = false;
            Orders_pb.Click += Orders_pb_Click;
            // 
            // Products_pb
            // 
            Products_pb.BorderStyle = BorderStyle.FixedSingle;
            Products_pb.Image = (Image)resources.GetObject("Products_pb.Image");
            Products_pb.Location = new Point(287, 145);
            Products_pb.Name = "Products_pb";
            Products_pb.Size = new Size(120, 120);
            Products_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Products_pb.TabIndex = 28;
            Products_pb.TabStop = false;
            Products_pb.Click += Products_pb_Click;
            // 
            // Customers_pb
            // 
            Customers_pb.BorderStyle = BorderStyle.FixedSingle;
            Customers_pb.Image = (Image)resources.GetObject("Customers_pb.Image");
            Customers_pb.Location = new Point(15, 336);
            Customers_pb.Name = "Customers_pb";
            Customers_pb.Size = new Size(120, 120);
            Customers_pb.SizeMode = PictureBoxSizeMode.Zoom;
            Customers_pb.TabIndex = 29;
            Customers_pb.TabStop = false;
            Customers_pb.Click += Customers_pb_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(287, 110);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 4;
            label3.Text = "Products";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(566, 108);
            label4.Name = "label4";
            label4.Size = new Size(97, 32);
            label4.TabIndex = 30;
            label4.Text = "Orders";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 20F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(15, 300);
            label5.Name = "label5";
            label5.Size = new Size(146, 32);
            label5.TabIndex = 31;
            label5.Text = "Customers";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 20F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(306, 300);
            label6.Name = "label6";
            label6.Size = new Size(85, 32);
            label6.TabIndex = 32;
            label6.Text = "Users";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 20F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 109);
            label7.Name = "label7";
            label7.Size = new Size(146, 32);
            label7.TabIndex = 33;
            label7.Text = "Categories";
            // 
            // Logout_pb
            // 
            Logout_pb.BorderStyle = BorderStyle.FixedSingle;
            Logout_pb.Image = (Image)resources.GetObject("Logout_pb.Image");
            Logout_pb.Location = new Point(633, 436);
            Logout_pb.Name = "Logout_pb";
            Logout_pb.Size = new Size(37, 54);
            Logout_pb.SizeMode = PictureBoxSizeMode.Zoom;
            Logout_pb.TabIndex = 34;
            Logout_pb.TabStop = false;
            Logout_pb.Click += Logout_pb_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 510);
            Controls.Add(Logout_pb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Customers_pb);
            Controls.Add(Products_pb);
            Controls.Add(Orders_pb);
            Controls.Add(Users_pb);
            Controls.Add(Categories_pb);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Categories_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Users_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Orders_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Products_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Customers_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logout_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label CloseApp_lbl;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox Categories_pb;
        private PictureBox Users_pb;
        private PictureBox Orders_pb;
        private PictureBox Products_pb;
        private PictureBox Customers_pb;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox Logout_pb;
    }
}