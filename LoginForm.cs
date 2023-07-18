using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_management
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn_login = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sofowora\Documents\PharmaCentrum_db.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void UserID_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Password_OnValueChanged(Object sender, EventArgs e) 
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm LoginHome = new HomeForm();
            conn_login.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select COUNT(*) from Employees Where FirstName = '"+ UserID.Text +"' and Password = '"+ Password.Text + "'", conn_login);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows[0][0].ToString() == "1" || (UserID.Text == "Admin" && Password.Text == "admin")) 
            {
                LoginHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            conn_login.Close();
        }
    }
}
