namespace Inventory_Management_System
{
    partial class ViewOrders
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
            panel2 = new Panel();
            panel1 = new Panel();
            CloseApp_lbl = new Label();
            label2 = new Label();
            label1 = new Label();
            Orders_dgv = new DataGridView();
            Back_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Orders_dgv).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 574);
            panel2.Name = "panel2";
            panel2.Size = new Size(862, 14);
            panel2.TabIndex = 32;
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
            panel1.Size = new Size(862, 100);
            panel1.TabIndex = 31;
            // 
            // CloseApp_lbl
            // 
            CloseApp_lbl.AutoSize = true;
            CloseApp_lbl.Font = new Font("Arial", 20F);
            CloseApp_lbl.ForeColor = Color.White;
            CloseApp_lbl.Location = new Point(827, 4);
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
            label1.Size = new Size(162, 32);
            label1.TabIndex = 1;
            label1.Text = "View Orders";
            // 
            // Orders_dgv
            // 
            Orders_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Orders_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Orders_dgv.BackgroundColor = Color.Gainsboro;
            Orders_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Orders_dgv.Location = new Point(34, 135);
            Orders_dgv.Name = "Orders_dgv";
            Orders_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Orders_dgv.Size = new Size(794, 395);
            Orders_dgv.TabIndex = 57;
            // 
            // Back_btn
            // 
            Back_btn.BackColor = Color.Crimson;
            Back_btn.FlatStyle = FlatStyle.Flat;
            Back_btn.Font = new Font("Arial", 10F);
            Back_btn.ForeColor = Color.White;
            Back_btn.Location = new Point(372, 541);
            Back_btn.Name = "Back_btn";
            Back_btn.Size = new Size(100, 27);
            Back_btn.TabIndex = 59;
            Back_btn.Text = "Back";
            Back_btn.UseVisualStyleBackColor = false;
            Back_btn.Click += Back_btn_Click;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 588);
            Controls.Add(Back_btn);
            Controls.Add(Orders_dgv);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrders";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Orders_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label CloseApp_lbl;
        private Label label2;
        private Label label1;
        private DataGridView Orders_dgv;
        private Button Back_btn;
    }
}