using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Documents\Inventory.mdf;Integrated Security = True; Connect Timeout = 30");

        public Login()
        {
            InitializeComponent();
            ShowPassw_chk.Checked = false;
            Password_tb.UseSystemPasswordChar = true;
        }

        private void ShowPassw_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassw_chk.Checked == false)
            {
                Password_tb.UseSystemPasswordChar = true;
            }
            else
            {
                Password_tb.UseSystemPasswordChar = false;
            }
        }

        private void Clear_lbl_Click(object sender, EventArgs e)
        {
            Username_tb.Text = "";
            Password_tb.Text = "";
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserTable WHERE UserName = '" + Username_tb.Text + "' AND Password = '" + Password_tb.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }
    }
}
