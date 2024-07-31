using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class Orders : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Documents\Inventory.mdf;Integrated Security = True; Connect Timeout = 30");

        private DataTable OrderTable;
        private int Num = 0;
        private int Flag = 0;
        private int Stock = 0;
        private decimal Uprice = 10.95m;
        private string Product = "Sample Product";

        public Orders()
        {
            InitializeComponent();
            InitializeOrderTable();
            ShowCustomerData();
            ShowProductsData();
            FillCategory();
        }

        private void InitializeOrderTable()
        {
            OrderTable = new DataTable("OrderTable");

            // Define columns
            OrderTable.Columns.Add("ItemNumber", typeof(int));
            OrderTable.Columns.Add("Product", typeof(string));
            OrderTable.Columns.Add("Quantity", typeof(int));
            OrderTable.Columns.Add("UnitPrice", typeof(decimal));
            OrderTable.Columns.Add("TotalPrice", typeof(decimal));
        }

        private void ShowCustomerData()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * from CustomerTable";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Customer_dgv.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowProductsData()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * from ProductsTable";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Products_dgv.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillCategory()
        {
            string Query = "SELECT * FROM CategoryTable";
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataReader dr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                ProdCat_cmb.ValueMember = "CategoryName";
                ProdCat_cmb.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateProduct()
        {
            int ID = Convert.ToInt32(Products_dgv.SelectedRows[0].Cells[0].Value.ToString());
            int NewQty = Stock - Convert.ToInt32(OrderQty_tb.Text);
            if (NewQty < 0)
            {
                MessageBox.Show("There is no available stock. Operation failed.");
            }
            else
            {
                Con.Open();
                string Query = "UPDATE ProductsTable SET ProdQty = " + NewQty + " where ProdId = " + ID + "";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                ShowProductsData();
            }
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

                if (selectedRow.Cells.Count >= 2)
                {
                    CustomerID_tb.Text = selectedRow.Cells[0].Value?.ToString() ?? "";
                    CustomerName_tb.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
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

        private void Products_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Product = Products_dgv.SelectedRows[0].Cells[1].Value.ToString();
                Stock = Convert.ToInt32(Products_dgv.SelectedRows[0].Cells[2].Value.ToString());
                Uprice = Convert.ToInt32(Products_dgv.SelectedRows[0].Cells[3].Value.ToString());
                Flag = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddItems_btn_Click(object sender, EventArgs e)
        {
            if (OrderQty_tb.Text == string.Empty)
            {
                MessageBox.Show("Enter the quantity of products.");
            }
            else if (Flag == 0)
            {
                MessageBox.Show("Select the product.");
            }
            else if (Convert.ToInt32(OrderQty_tb.Text) > Stock)
            {
                MessageBox.Show("Not enough available stock.");
            }
            else
            {
                Num = Num + 1;
                int Quantity;
                try
                {
                    Quantity = Convert.ToInt32(OrderQty_tb.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid number for quantity.");
                    return;
                }

                decimal Totalprice = Quantity * Uprice;
                OrderTable.Rows.Add(Num, Product, Quantity, Uprice, Totalprice);
                Orders_dgv.DataSource = OrderTable;
                Orders_dgv.Refresh();
                GrandTotal_lbl.Text = Totalprice.ToString();
                Flag = 0;
                UpdateProduct();
            }
        }

        private void RemoveItems_btn_Click(object sender, EventArgs e)
        {

        }

        private void ProdCat_cmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Query = "SELECT * FROM ProductsTable WHERE ProdCat = '" + ProdCat_cmb.SelectedIndex.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Products_dgv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Orders_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InsertOrder_btn_Click(object sender, EventArgs e)
        {
            if (OrderID_tb.Text == string.Empty || CustomerID_tb.Text == string.Empty || CustomerName_tb.Text == string.Empty || GrandTotal_lbl.Text == string.Empty)
            {
                MessageBox.Show("Please fill in the data correctly.");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO OrderTable values('" + OrderID_tb.Text + "','" + CustomerID_tb.Text + "','" + CustomerName_tb.Text + "','" + Orders_dtp.Value.Date + "','" + GrandTotal_lbl.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully.");
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void VwOrder_btn_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrders = new ViewOrders();
            viewOrders.Show(); 
            this.Hide();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
