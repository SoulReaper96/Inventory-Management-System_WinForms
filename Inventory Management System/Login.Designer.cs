namespace Inventory_Management_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            ShowPassw_chk = new CheckBox();
            Clear_lbl = new Label();
            Login_btn = new Button();
            label4 = new Label();
            label3 = new Label();
            Password_tb = new TextBox();
            Username_tb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(ShowPassw_chk);
            panel1.Controls.Add(Clear_lbl);
            panel1.Controls.Add(Login_btn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Password_tb);
            panel1.Controls.Add(Username_tb);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(36, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 359);
            panel1.TabIndex = 0;
            // 
            // ShowPassw_chk
            // 
            ShowPassw_chk.AutoSize = true;
            ShowPassw_chk.BackColor = Color.Crimson;
            ShowPassw_chk.ForeColor = Color.White;
            ShowPassw_chk.Location = new Point(132, 293);
            ShowPassw_chk.Name = "ShowPassw_chk";
            ShowPassw_chk.Size = new Size(134, 21);
            ShowPassw_chk.TabIndex = 9;
            ShowPassw_chk.Text = "Show Password";
            ShowPassw_chk.UseVisualStyleBackColor = false;
            ShowPassw_chk.CheckedChanged += ShowPassw_chk_CheckedChanged;
            // 
            // Clear_lbl
            // 
            Clear_lbl.AutoSize = true;
            Clear_lbl.BackColor = Color.Transparent;
            Clear_lbl.Font = new Font("Arial", 11F);
            Clear_lbl.ForeColor = Color.White;
            Clear_lbl.Location = new Point(25, 293);
            Clear_lbl.Name = "Clear_lbl";
            Clear_lbl.Size = new Size(43, 17);
            Clear_lbl.TabIndex = 8;
            Clear_lbl.Text = "Clear";
            Clear_lbl.Click += Clear_lbl_Click;
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.DodgerBlue;
            Login_btn.FlatStyle = FlatStyle.Flat;
            Login_btn.ForeColor = Color.White;
            Login_btn.Location = new Point(86, 178);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(121, 39);
            Login_btn.TabIndex = 7;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 13F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 113);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 13F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 51);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // Password_tb
            // 
            Password_tb.BackColor = Color.Crimson;
            Password_tb.BorderStyle = BorderStyle.FixedSingle;
            Password_tb.ForeColor = Color.White;
            Password_tb.Location = new Point(28, 137);
            Password_tb.Name = "Password_tb";
            Password_tb.Size = new Size(238, 24);
            Password_tb.TabIndex = 4;
            // 
            // Username_tb
            // 
            Username_tb.BackColor = Color.Crimson;
            Username_tb.BorderStyle = BorderStyle.FixedSingle;
            Username_tb.ForeColor = Color.White;
            Username_tb.Location = new Point(25, 75);
            Username_tb.Name = "Username_tb";
            Username_tb.Size = new Size(241, 24);
            Username_tb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 16F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(108, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 33);
            label1.Name = "label1";
            label1.Size = new Size(358, 23);
            label1.TabIndex = 1;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(367, 469);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox Password_tb;
        private TextBox Username_tb;
        private Button Login_btn;
        private Label Clear_lbl;
        private CheckBox ShowPassw_chk;
        private Label label3;
    }
}
