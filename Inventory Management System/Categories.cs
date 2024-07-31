using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class Categories : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Documents\Inventory.mdf;Integrated Security = True; Connect Timeout = 30");

        public Categories()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            try
            {
                Con.Open();
                string Query = "SELECT * from CategoryTable";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                Categories_dgv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            CategoryID_tb.Text = string.Empty;
            CategoryName_tb.Text = string.Empty;
        }

        private void CloseApp_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CategoryTable values('" + CategoryID_tb.Text + "','" + CategoryName_tb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category added successfully.");
                Con.Close();
                Clear();
                ShowData();
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
                SqlCommand cmd = new SqlCommand("UPDATE CategoryTable set CategoryName = '" + CategoryName_tb.Text + "' where CategoryId = '" + CategoryID_tb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer data edited successfully.");
                Con.Close();
                Clear();
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (CategoryID_tb.Text == "")
            {
                MessageBox.Show("Enter a valid customers phone number.");
            }
            else
            {
                Con.Open();
                string Query = "DELETE FROM CategoryTable where CategoryId = '" + CategoryID_tb.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category deleted successfully.");
                Con.Close();
                Clear();
                ShowData();
            }
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void Categories_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CategoryID_tb.Text = Categories_dgv.SelectedRows[0].Cells[0].Value.ToString();
                CategoryName_tb.Text = Categories_dgv.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
