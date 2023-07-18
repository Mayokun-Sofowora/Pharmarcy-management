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
    public partial class CompanyForm : Form
    {
        SqlConnection conn_comp = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sofowora\Documents\PharmaCentrum_db.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            conn_comp.Open();
            string Myquery = "Select * from Companies";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, conn_comp);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            CompanyGridView.ReadOnly = true;
            CompanyGridView.DataSource = dataSet.Tables[0];
            conn_comp.Close();
        }

        public CompanyForm()
        {
            InitializeComponent();
        }

        private void AddComp_Click(object sender, EventArgs e)
        {
            if (CompanyId.Text == "" || CompanyName.Text == "" || PhoneNo.Text == "" || CompanyAddress.Text == "")
            {
                MessageBox.Show("Missing data, please fill in all the information.");
            }
            else
            {
                conn_comp.Open();
                SqlCommand command = new SqlCommand("Insert into Companies values('" + CompanyId.Text + "', '" + CompanyName.Text + "', '" + PhoneNo.Text + "', '" + CompanyAddress.Text + "')", conn_comp);
                command.ExecuteNonQuery();
                MessageBox.Show("Company Added");
                conn_comp.Close();
                populate();
            }
        }

        private void Companies_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CompanyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CompanyId.Text = CompanyGridView.SelectedRows[0].Cells[0].Value.ToString();
            CompanyName.Text = CompanyGridView.SelectedRows[0].Cells[1].Value.ToString();
            PhoneNo.Text = CompanyGridView.SelectedRows[0].Cells[2].Value.ToString();
            CompanyAddress.Text = CompanyGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void DeleteComp_Click(object sender, EventArgs e)
        {
            if (CompanyId.Text == "")
            {
                MessageBox.Show("Empty Company id in field!");
            }
            else
            {
                conn_comp.Open();
                string delete = "Delete from Companies where CompId = '" + CompanyId.Text + "';";
                SqlCommand delelte_comm = new SqlCommand(delete, conn_comp);
                delelte_comm.ExecuteNonQuery();
                MessageBox.Show("Company Deleted");
                conn_comp.Close();
                populate();
            }
        }

        private void UpdateComp_Click(object sender, EventArgs e)
        {
            conn_comp.Open();
            string update = "Update Companies SET CompName = '" + CompanyName.Text + "', CompPhone = '" + PhoneNo.Text + "', CompAddress = '" + CompanyAddress.Text + "' Where CompId = '" + CompanyId.Text + "';";
            SqlCommand update_comm = new SqlCommand(update, conn_comp);
            update_comm.ExecuteNonQuery();
            MessageBox.Show("Company Updated");
            conn_comp.Close();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
