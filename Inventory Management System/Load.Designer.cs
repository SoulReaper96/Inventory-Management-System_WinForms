namespace Inventory_Management_System
{
    partial class Load
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            circularProgressbar1 = new CircularProgressbar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 75);
            panel1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 9);
            label2.Name = "label2";
            label2.Size = new Size(490, 32);
            label2.TabIndex = 2;
            label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(124, 41);
            label1.Name = "label1";
            label1.Size = new Size(310, 23);
            label1.TabIndex = 1;
            label1.Text = "Developed by Introspect Software";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(progressBar1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 245);
            panel2.Name = "panel2";
            panel2.Size = new Size(549, 27);
            panel2.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(124, 1);
            label3.Name = "label3";
            label3.Size = new Size(310, 23);
            label3.TabIndex = 3;
            label3.Text = "Developed by Introspect Software";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Cyan;
            progressBar1.Location = new Point(139, 1);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(295, 23);
            progressBar1.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(459, 78);
            label4.Name = "label4";
            label4.Size = new Size(78, 16);
            label4.TabIndex = 3;
            label4.Text = "Version 1.0";
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // circularProgressbar1
            // 
            circularProgressbar1.BackgroundColor = Color.Gray;
            circularProgressbar1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            circularProgressbar1.Location = new Point(203, 81);
            circularProgressbar1.Name = "circularProgressbar1";
            circularProgressbar1.Progress = 0;
            circularProgressbar1.ProgressColor = Color.Blue;
            circularProgressbar1.ShowText = true;
            circularProgressbar1.Size = new Size(150, 150);
            circularProgressbar1.TabIndex = 28;
            circularProgressbar1.TextColor = Color.White;
            circularProgressbar1.TextFont = new Font("Segoe UI", 9F);
            circularProgressbar1.Thickness = 10;
            // 
            // Load
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(549, 272);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(circularProgressbar1);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Load";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Load_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private CircularProgressbar circularProgressbar1;
    }
}