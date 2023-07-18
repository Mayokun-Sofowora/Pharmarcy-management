namespace Pharmacy_management
{
    partial class BillingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            BillTotalLabel = new Label();
            AddBill = new Guna.UI2.WinForms.Guna2Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            Qnty = new TextBox();
            stockLabel = new Label();
            BillGridView = new DataGridView();
            MedID = new DataGridViewTextBoxColumn();
            MedName = new DataGridViewTextBoxColumn();
            MedicineQuantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            Total = new TextBox();
            PrintBill = new Guna.UI2.WinForms.Guna2Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            Homebtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)BillGridView).BeginInit();
            SuspendLayout();
            // 
            // BillTotalLabel
            // 
            BillTotalLabel.AutoSize = true;
            BillTotalLabel.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BillTotalLabel.ForeColor = Color.ForestGreen;
            BillTotalLabel.Location = new Point(369, 448);
            BillTotalLabel.Name = "BillTotalLabel";
            BillTotalLabel.Size = new Size(183, 35);
            BillTotalLabel.TabIndex = 3;
            BillTotalLabel.Text = "Total Amount";
            // 
            // AddBill
            // 
            AddBill.CustomizableEdges = customizableEdges1;
            AddBill.DisabledState.BorderColor = Color.DarkGray;
            AddBill.DisabledState.CustomBorderColor = Color.DarkGray;
            AddBill.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddBill.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddBill.FillColor = Color.ForestGreen;
            AddBill.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBill.ForeColor = Color.White;
            AddBill.Location = new Point(45, 257);
            AddBill.Name = "AddBill";
            AddBill.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AddBill.Size = new Size(128, 33);
            AddBill.TabIndex = 22;
            AddBill.Text = "ADD TO BILL";
            AddBill.Click += AddBill_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 23;
            comboBox1.Text = "Select Medicine";
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(12, 175);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 25;
            label2.Text = "Quantity";
            // 
            // Qnty
            // 
            Qnty.Location = new Point(78, 167);
            Qnty.Name = "Qnty";
            Qnty.Size = new Size(100, 23);
            Qnty.TabIndex = 24;
            Qnty.Tag = "";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.ForeColor = Color.Black;
            stockLabel.Location = new Point(45, 116);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new Size(87, 15);
            stockLabel.TabIndex = 25;
            stockLabel.Text = "Available Stock";
            stockLabel.Visible = false;
            // 
            // BillGridView
            // 
            BillGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BillGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            BillGridView.BackgroundColor = Color.Honeydew;
            BillGridView.BorderStyle = BorderStyle.None;
            BillGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.ForestGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Honeydew;
            dataGridViewCellStyle1.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BillGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BillGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillGridView.Columns.AddRange(new DataGridViewColumn[] { MedID, MedName, MedicineQuantity, UnitPrice, TotalPrice });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            BillGridView.DefaultCellStyle = dataGridViewCellStyle2;
            BillGridView.Location = new Point(369, 12);
            BillGridView.Name = "BillGridView";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.ForestGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Honeydew;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            BillGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            BillGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            BillGridView.RowTemplate.Height = 30;
            BillGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BillGridView.Size = new Size(645, 392);
            BillGridView.TabIndex = 26;
            // 
            // MedID
            // 
            MedID.HeaderText = "MedicineID";
            MedID.Name = "MedID";
            MedID.Width = 96;
            // 
            // MedName
            // 
            MedName.HeaderText = "MedicineName";
            MedName.Name = "MedName";
            MedName.Width = 116;
            // 
            // MedicineQuantity
            // 
            MedicineQuantity.HeaderText = "MedicineQuantity";
            MedicineQuantity.Name = "MedicineQuantity";
            MedicineQuantity.Width = 131;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 84;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 87;
            // 
            // Total
            // 
            Total.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Total.Location = new Point(558, 448);
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Size = new Size(123, 33);
            Total.TabIndex = 27;
            // 
            // PrintBill
            // 
            PrintBill.CustomizableEdges = customizableEdges3;
            PrintBill.DisabledState.BorderColor = Color.DarkGray;
            PrintBill.DisabledState.CustomBorderColor = Color.DarkGray;
            PrintBill.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            PrintBill.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            PrintBill.FillColor = Color.ForestGreen;
            PrintBill.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PrintBill.ForeColor = Color.White;
            PrintBill.Location = new Point(704, 450);
            PrintBill.Name = "PrintBill";
            PrintBill.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PrintBill.Size = new Size(128, 33);
            PrintBill.TabIndex = 22;
            PrintBill.Text = "PRINT BILL";
            PrintBill.Click += PrintBill_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Homebtn
            // 
            Homebtn.CustomizableEdges = customizableEdges5;
            Homebtn.DisabledState.BorderColor = Color.DarkGray;
            Homebtn.DisabledState.CustomBorderColor = Color.DarkGray;
            Homebtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Homebtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Homebtn.FillColor = Color.ForestGreen;
            Homebtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Homebtn.ForeColor = Color.White;
            Homebtn.Location = new Point(886, 450);
            Homebtn.Name = "Homebtn";
            Homebtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Homebtn.Size = new Size(128, 33);
            Homebtn.TabIndex = 22;
            Homebtn.Text = "HOME";
            Homebtn.Click += Homebtn_Click;
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 514);
            Controls.Add(Total);
            Controls.Add(BillGridView);
            Controls.Add(stockLabel);
            Controls.Add(label2);
            Controls.Add(Qnty);
            Controls.Add(comboBox1);
            Controls.Add(Homebtn);
            Controls.Add(PrintBill);
            Controls.Add(AddBill);
            Controls.Add(BillTotalLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BillingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BillingForm";
            Load += BillingForm_Load;
            ((System.ComponentModel.ISupportInitialize)BillGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BillTotalLabel;
        private Guna.UI2.WinForms.Guna2Button AddBill;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox Qnty;
        private Label stockLabel;
        private DataGridView BillGridView;
        private DataGridViewTextBoxColumn MedID;
        private DataGridViewTextBoxColumn MedName;
        private DataGridViewTextBoxColumn MedicineQuantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn TotalPrice;
        private TextBox Total;
        private Guna.UI2.WinForms.Guna2Button PrintBill;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2Button Homebtn;
    }
}