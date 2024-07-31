using System;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class Customers : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Documents\Inventory.mdf;Integrated Security = True; Connect Timeout = 30");

        public Customers()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            try
            {
                Con.Open();
                string Query = "SELECT * from CustomerTable";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                Customer_dgv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            CustomerID_tb.Text = string.Empty;
            CustomerName_tb.Text = string.Empty;
            CustomerPhone_tb.Text = string.Empty;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CustomerTable values('" + CustomerID_tb.Text + "','" + CustomerName_tb.Text + "','" + CustomerPhone_tb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully.");
                Con.Close();
                ShowData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CustomerTable set CustName = '" + CustomerName_tb.Text + "', CustPhone = '" + CustomerPhone_tb.Text + "' where CustId = '" + CustomerID_tb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer data edited successfully.");
                Con.Close();
                ShowData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (CustomerID_tb.Text == "")
            {
                MessageBox.Show("Enter a valid customers phone number.");
            }
            else
            {
                Con.Open();
                string Query = "DELETE FROM CustomerTable where CustId = '" + CustomerID_tb.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer deleted successfully.");
                Con.Close();
                ShowData();
                Clear();
            }
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void CloseApp_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customer_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Customer_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Customer_dgv.SelectedRows[0];

                if (selectedRow.Cells.Count >= 3)
                {
                    Con.Open();
                    CustomerID_tb.Text = selectedRow.Cells[0].Value?.ToString() ?? "";
                    CustomerName_tb.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                    CustomerPhone_tb.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM OrderTable WHERE CustId = '" + CustomerID_tb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    OrdersCnt_lbl.Text = dt.Rows[0][0].ToString();
                    SqlDataAdapter sda1 = new SqlDataAdapter("SELECT SUM(TotalAmnt) FROM OrderTable WHERE CustId = '" + CustomerID_tb.Text + "'", Con);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    OrdersAmnt_lbl.Text = dt1.Rows[0][0].ToString();
                    SqlDataAdapter sda2 = new SqlDataAdapter("SELECT MAX(OrderDate) FROM OrderTable WHERE CustId = '" + CustomerID_tb.Text + "'", Con);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    OrdersLastD_lbl.Text = dt2.Rows[0][0].ToString();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Selected row does not have enough cells.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
