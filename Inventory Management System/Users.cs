using System;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class Users : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Documents\Inventory.mdf;Integrated Security = True; Connect Timeout = 30");
        public Users()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            try
            {
                Con.Open();
                string Query = "SELECT * from UsersTable";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                Users_dgv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            Username_tb.Text = string.Empty;
            Fullname_tb.Text = string.Empty;
            Password_tb.Text = string.Empty;
            Telephone_tb.Text = string.Empty;
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
                SqlCommand cmd = new SqlCommand("INSERT INTO UsersTable values('" + Username_tb.Text + "','" + Fullname_tb.Text + "','" + Password_tb.Text + "','" + Telephone_tb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User added successfully.");
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
                SqlCommand cmd = new SqlCommand("UPDATE UsersTable set Uname = '" + Username_tb.Text + "', Ufullname = '" + Fullname_tb.Text + "', Upassword = '" + Password_tb.Text + "' where Uphone = '" + Telephone_tb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User added successfully.");
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
            if (Telephone_tb.Text == "")
            {
                MessageBox.Show("Enter a valid users phone number.");
            }
            else
            {
                Con.Open();
                string Query = "DELETE FROM UsersTable where Upassword = '" + Telephone_tb.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User deleted successfully.");
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

        private void Users_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Username_tb.Text = Users_dgv.SelectedRows[0].Cells[0].Value.ToString();
                Fullname_tb.Text = Users_dgv.SelectedRows[0].Cells[1].Value.ToString();
                Password_tb.Text = Users_dgv.SelectedRows[0].Cells[2].Value.ToString();
                Telephone_tb.Text = Users_dgv.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
