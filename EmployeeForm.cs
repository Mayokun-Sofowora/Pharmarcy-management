using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_management
{
    public partial class EmployeeForm : Form
    {
        SqlConnection conn_emp = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sofowora\Documents\PharmaCentrum_db.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            conn_emp.Open();
            string Myquery = "Select * from Employees";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, conn_emp);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            EmployeesGridView.ReadOnly = true;
            EmployeesGridView.DataSource = dataSet.Tables[0];
            conn_emp.Close();
        }

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            if (EmployeeId.Text == "" || FirstName.Text == "" || lastName.Text == "" || Age.Text == "" || salary.Text == "" || PhoneNo.Text == "" || Password.Text == "" || EmpGender.SelectedItem == null)
            {
                MessageBox.Show("Missing data, please fill in all the information.");
            }
            else
            {
                conn_emp.Open();
                SqlCommand command = new SqlCommand("Insert into Employees values('" + EmployeeId.Text + "', '" + FirstName.Text + "', '" + lastName.Text + "', '" + Age.Text + "', '" + salary.Text + "', '" + PhoneNo.Text + "', '" + Password.Text + "', '" + EmpGender.SelectedItem + "')", conn_emp);
                command.ExecuteNonQuery();
                MessageBox.Show("Employee Added");
                conn_emp.Close();
                populate();
            }
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void EmployeesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeId.Text = EmployeesGridView.SelectedRows[0].Cells[0].Value.ToString();
            FirstName.Text = EmployeesGridView.SelectedRows[0].Cells[1].Value.ToString();
            lastName.Text = EmployeesGridView.SelectedRows[0].Cells[2].Value.ToString();
            Age.Text = EmployeesGridView.SelectedRows[0].Cells[3].Value.ToString();
            salary.Text = EmployeesGridView.SelectedRows[0].Cells[4].Value.ToString();
            PhoneNo.Text = EmployeesGridView.SelectedRows[0].Cells[5].Value.ToString();
            Password.Text = EmployeesGridView.SelectedRows[0].Cells[6].Value.ToString();
            EmpGender.Text = EmployeesGridView.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void DeleteEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmployeeId.Text))
            {
                MessageBox.Show("Empty Employee ID field!");
            }
            else
            {
                conn_emp.Open();
                string delete = "DELETE FROM Employees WHERE EmployeeId = '" + EmployeeId.Text + "';";
                SqlCommand delete_comm = new SqlCommand(delete, conn_emp);
                delete_comm.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted");
                conn_emp.Close();
                populate();
            }
        }


        private void UpdateEmp_Click(object sender, EventArgs e)
        {
            conn_emp.Open();
            string update = "Update Employees SET FirstName = '" + FirstName.Text + "', LastName = '" + lastName.Text + "', Age = '" + Age.Text + "', Salary = '" + salary.Text + "', PhoneNumber = '" + PhoneNo.Text + "', Password = '" + Password.Text + "', Gender = '" + EmpGender.SelectedText.ToString() + "' Where EmployeeId = '" + EmployeeId.Text + "';";
            SqlCommand update_comm = new SqlCommand(update, conn_emp);
            update_comm.ExecuteNonQuery();
            MessageBox.Show("Employee Updated");
            conn_emp.Close();
            populate();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
