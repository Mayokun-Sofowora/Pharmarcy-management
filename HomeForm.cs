using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_management
{
    public partial class HomeForm : Form
    {
        MedicineForm med = new MedicineForm();
        CompanyForm comp = new CompanyForm();
        EmployeeForm emp = new EmployeeForm();
        BillingForm bills = new BillingForm();

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Medicine_Click(object sender, EventArgs e)
        {
            med.Show();
            this.Hide();
        }


        private void Pharmarcy_Click(object sender, EventArgs e)
        {
            comp.Show();
            this.Hide();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            emp.Show();
            this.Hide();
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            bills.Show();
            this.Hide();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
