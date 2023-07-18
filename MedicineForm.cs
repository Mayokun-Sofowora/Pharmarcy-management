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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy_management
{
    public partial class MedicineForm : Form
    {
        SqlConnection conn_med = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sofowora\Documents\PharmaCentrum_db.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            conn_med.Open();
            string Myquery = "Select * from Medicine";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, conn_med);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            MedicineGridView.ReadOnly = true;
            MedicineGridView.DataSource = dataSet.Tables[0];
            conn_med.Close();
        }

        public void populateCompany()
        {
            string Myquery = "Select CompName from Companies";
            SqlCommand command = new SqlCommand(Myquery, conn_med);
            try
            {
                conn_med.Open();
                DataTable data = new DataTable();
                data.Columns.Add("CompName", typeof(string));
                SqlDataReader reader = command.ExecuteReader();
                data.Load(reader);
                Companylist.ValueMember = "CompName";
                Companylist.DataSource = data;
                conn_med.Close();
            }
            catch
            {

            }
        }

        public MedicineForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MedicineName.Text == "" || BuyingPrice.Text == "" || SellingPrice.Text == "" || Quantity.Text == "" || ExpiringDate.Text == "" || Companylist.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Missing data, please fill in all the information.");
            }
            else
            {
                conn_med.Open();
                SqlCommand command = new SqlCommand("Insert into Medicine values('" + MedicineName.Text + "', '" + BuyingPrice.Text + "', '" + SellingPrice.Text + "', '" + Quantity.Text + "', '" + ExpiringDate.Text + "', '" + Companylist.SelectedItem.ToString() + "')", conn_med);
                command.ExecuteNonQuery();
                MessageBox.Show("Medicine Added");
                conn_med.Close();
                populate();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            conn_med.Open();
            string update = "Update Medicine SET BuyingPrice = '" + BuyingPrice.Text + "', SellingPrice = '" + SellingPrice.Text + "', MedicineQuantity = '" + Quantity.Text + "', ExpirationDate = '" + ExpiringDate.Text + "', Company = '" + Companylist.SelectedText.ToString() + "' Where MedicineName = '" + MedicineName.Text + "';";
            SqlCommand update_comm = new SqlCommand(update, conn_med);
            update_comm.ExecuteNonQuery();
            MessageBox.Show("Medicine Updated");
            conn_med.Close();
            populate();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (MedicineName.Text == "")
            {
                MessageBox.Show("Empty medicine name in field!");
            }
            else
            {
                conn_med.Open();
                string delete = "Delete from Medicine where MedicineName = '" + MedicineName.Text + "';";
                SqlCommand delelte_comm = new SqlCommand(delete, conn_med);
                delelte_comm.ExecuteNonQuery();
                MessageBox.Show("Medicine Deleted");
                conn_med.Close();
                populate();
            }
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            populate();
            populateCompany();
        }

        private void MedicineGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicineName.Text = MedicineGridView.SelectedRows[0].Cells[0].Value.ToString();
            BuyingPrice.Text = MedicineGridView.SelectedRows[0].Cells[1].Value.ToString();
            SellingPrice.Text = MedicineGridView.SelectedRows[0].Cells[2].Value.ToString();
            Quantity.Text = MedicineGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
