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
    public partial class BillingForm : Form
    {
        SqlConnection conn_bill = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sofowora\Documents\PharmaCentrum_db.mdf;Integrated Security=True;Connect Timeout=30");
        int num = 0, quantity, unitPrice, GrossTotal;
        Bitmap bitmap;

        public void populate()
        {
            string Myquery = "Select * from Medicine";
            SqlCommand command = new SqlCommand(Myquery, conn_bill);
            try
            {
                conn_bill.Open();
                DataTable data = new DataTable();
                data.Columns.Add("MedicineName", typeof(string));
                SqlDataReader reader = command.ExecuteReader();
                data.Load(reader);
                comboBox1.ValueMember = "MedicineName";
                comboBox1.DataSource = data;
                conn_bill.Close();
            }
            catch
            {

            }
        }

        public void fetchQuantity()
        {
            conn_bill.Open();
            string MySql = "Select * from Medicine where MedicineName = '" + comboBox1.SelectedValue.ToString() + "';";
            SqlCommand command = new SqlCommand(@MySql, conn_bill);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            foreach (DataRow row in data.Rows)
            {
                quantity = Convert.ToInt32(row["MedicineQuantity"].ToString());
                unitPrice = Convert.ToInt32(row["SellingPrice"].ToString());
                stockLabel.Text = "Available Stock : " + row["MedicineQuantity"].ToString();
                stockLabel.Visible = true;
            }
            conn_bill.Close();
        }

        public BillingForm()
        {
            InitializeComponent();
        }

        public void update()
        {
            conn_bill.Open();
            int NewQuantity = quantity - Convert.ToInt32(Qnty.Text);
            string update = "Update Medicine SET MedicineQuantity = '" + NewQuantity + "' Where MedicineName = '" + comboBox1.SelectedValue.ToString() + "';";
            SqlCommand update_comm = new SqlCommand(update, conn_bill);
            update_comm.ExecuteNonQuery();
            conn_bill.Close();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchQuantity();
        }

        private void AddBill_Click(object sender, EventArgs e)
        {
            if (Qnty.Text == "" || Convert.ToInt32(Qnty.Text) > quantity)
            {
                MessageBox.Show("Not Enough in Stock, Please Check Available Stock.");
            }
            else
            {
                int total = Convert.ToInt32(Qnty.Text) * unitPrice;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(BillGridView);
                row.Cells[0].Value = num + 1;
                row.Cells[1].Value = comboBox1.SelectedValue.ToString();
                row.Cells[2].Value = Qnty.Text;
                row.Cells[3].Value = unitPrice;
                row.Cells[4].Value = unitPrice * Convert.ToInt32(Qnty.Text);
                BillGridView.Rows.Add(row);
                GrossTotal += total;
                Total.Text = GrossTotal + " EUR";
            }
        }

        private void PrintBill_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            update();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
