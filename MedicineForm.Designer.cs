namespace Pharmacy_management
{
    partial class MedicineForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            MedicineGridView = new DataGridView();
            MedicineName = new TextBox();
            BuyingPrice = new TextBox();
            SellingPrice = new TextBox();
            Quantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Companylist = new Guna.UI2.WinForms.Guna2ComboBox();
            Add = new Guna.UI2.WinForms.Guna2Button();
            Update = new Guna.UI2.WinForms.Guna2Button();
            Delete = new Guna.UI2.WinForms.Guna2Button();
            Back = new Guna.UI2.WinForms.Guna2Button();
            ExpiringDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)MedicineGridView).BeginInit();
            SuspendLayout();
            // 
            // MedicineGridView
            // 
            MedicineGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MedicineGridView.BackgroundColor = Color.Honeydew;
            MedicineGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.ForestGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Honeydew;
            dataGridViewCellStyle1.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MedicineGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MedicineGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            MedicineGridView.DefaultCellStyle = dataGridViewCellStyle2;
            MedicineGridView.Location = new Point(369, 9);
            MedicineGridView.Name = "MedicineGridView";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.ForestGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Honeydew;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            MedicineGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            MedicineGridView.RowHeadersWidth = 30;
            MedicineGridView.RowTemplate.Height = 30;
            MedicineGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MedicineGridView.Size = new Size(645, 493);
            MedicineGridView.TabIndex = 2;
            MedicineGridView.CellContentClick += MedicineGridView_CellContentClick;
            // 
            // MedicineName
            // 
            MedicineName.Location = new Point(109, 68);
            MedicineName.Name = "MedicineName";
            MedicineName.Size = new Size(100, 23);
            MedicineName.TabIndex = 3;
            MedicineName.Tag = "Medicine Name";
            // 
            // BuyingPrice
            // 
            BuyingPrice.Location = new Point(322, 63);
            BuyingPrice.Name = "BuyingPrice";
            BuyingPrice.Size = new Size(41, 23);
            BuyingPrice.TabIndex = 3;
            BuyingPrice.Tag = "Buying Price";
            // 
            // SellingPrice
            // 
            SellingPrice.Location = new Point(322, 152);
            SellingPrice.Name = "SellingPrice";
            SellingPrice.Size = new Size(41, 23);
            SellingPrice.TabIndex = 3;
            SellingPrice.Tag = "Selling Price";
            // 
            // Quantity
            // 
            Quantity.AllowDrop = true;
            Quantity.Location = new Point(320, 237);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(43, 23);
            Quantity.TabIndex = 3;
            Quantity.Tag = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 29);
            label1.TabIndex = 1;
            label1.Text = "Medicine Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 5;
            label2.Text = "Medicine Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(245, 160);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 5;
            label3.Text = "Selling Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(261, 245);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 5;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(243, 71);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 5;
            label5.Text = "Buying Price";
            // 
            // Companylist
            // 
            Companylist.AccessibleDescription = "";
            Companylist.AccessibleName = "";
            Companylist.BackColor = Color.Transparent;
            Companylist.CustomizableEdges = customizableEdges1;
            Companylist.DrawMode = DrawMode.OwnerDrawFixed;
            Companylist.DropDownStyle = ComboBoxStyle.DropDownList;
            Companylist.FocusedColor = Color.FromArgb(94, 148, 255);
            Companylist.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Companylist.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Companylist.ForeColor = Color.FromArgb(68, 88, 112);
            Companylist.ItemHeight = 30;
            Companylist.Location = new Point(12, 245);
            Companylist.Name = "Companylist";
            Companylist.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Companylist.Size = new Size(140, 36);
            Companylist.TabIndex = 8;
            // 
            // Add
            // 
            Add.CustomizableEdges = customizableEdges3;
            Add.DisabledState.BorderColor = Color.DarkGray;
            Add.DisabledState.CustomBorderColor = Color.DarkGray;
            Add.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Add.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Add.FillColor = Color.ForestGreen;
            Add.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Add.ForeColor = Color.White;
            Add.Location = new Point(12, 374);
            Add.Name = "Add";
            Add.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Add.Size = new Size(81, 33);
            Add.TabIndex = 7;
            Add.Text = "ADD";
            Add.Click += guna2Button1_Click;
            // 
            // Update
            // 
            Update.CustomizableEdges = customizableEdges5;
            Update.DisabledState.BorderColor = Color.DarkGray;
            Update.DisabledState.CustomBorderColor = Color.DarkGray;
            Update.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Update.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Update.FillColor = Color.ForestGreen;
            Update.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Update.ForeColor = Color.White;
            Update.Location = new Point(243, 374);
            Update.Name = "Update";
            Update.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Update.Size = new Size(92, 33);
            Update.TabIndex = 7;
            Update.Text = "UPDATE";
            Update.Click += guna2Button2_Click;
            // 
            // Delete
            // 
            Delete.CustomizableEdges = customizableEdges7;
            Delete.DisabledState.BorderColor = Color.DarkGray;
            Delete.DisabledState.CustomBorderColor = Color.DarkGray;
            Delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Delete.FillColor = Color.ForestGreen;
            Delete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.ForeColor = Color.White;
            Delete.Location = new Point(125, 374);
            Delete.Name = "Delete";
            Delete.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Delete.Size = new Size(84, 33);
            Delete.TabIndex = 7;
            Delete.Text = "DELETE";
            Delete.Click += guna2Button3_Click;
            // 
            // Back
            // 
            Back.CustomizableEdges = customizableEdges9;
            Back.DisabledState.BorderColor = Color.DarkGray;
            Back.DisabledState.CustomBorderColor = Color.DarkGray;
            Back.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Back.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Back.FillColor = Color.ForestGreen;
            Back.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Back.ForeColor = Color.White;
            Back.Location = new Point(125, 453);
            Back.Name = "Back";
            Back.ShadowDecoration.CustomizableEdges = customizableEdges10;
            Back.Size = new Size(84, 33);
            Back.TabIndex = 7;
            Back.Text = "BACK";
            Back.Click += Back_Click;
            // 
            // ExpiringDate
            // 
            ExpiringDate.BackgroundImageLayout = ImageLayout.None;
            ExpiringDate.Checked = true;
            ExpiringDate.CustomizableEdges = customizableEdges11;
            ExpiringDate.FillColor = Color.ForestGreen;
            ExpiringDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ExpiringDate.ForeColor = Color.Honeydew;
            ExpiringDate.Format = DateTimePickerFormat.Long;
            ExpiringDate.Location = new Point(12, 152);
            ExpiringDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            ExpiringDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            ExpiringDate.Name = "ExpiringDate";
            ExpiringDate.ShadowDecoration.CustomizableEdges = customizableEdges12;
            ExpiringDate.Size = new Size(200, 36);
            ExpiringDate.TabIndex = 9;
            ExpiringDate.Value = new DateTime(2023, 7, 12, 20, 46, 28, 79);
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1026, 514);
            Controls.Add(ExpiringDate);
            Controls.Add(Companylist);
            Controls.Add(Delete);
            Controls.Add(Back);
            Controls.Add(Update);
            Controls.Add(Add);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Quantity);
            Controls.Add(SellingPrice);
            Controls.Add(BuyingPrice);
            Controls.Add(MedicineName);
            Controls.Add(MedicineGridView);
            Controls.Add(label1);
            ForeColor = Color.ForestGreen;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MedicineForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedicineForm";
            Load += MedicineForm_Load;
            ((System.ComponentModel.ISupportInitialize)MedicineGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox MedicineName;
        private TextBox BuyingPrice;
        private TextBox SellingPrice;
        private TextBox Quantity;
        private DataGridView MedicineGridView;
        private Guna.UI2.WinForms.Guna2Button Add;
        private Guna.UI2.WinForms.Guna2Button Update;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private Guna.UI2.WinForms.Guna2Button Back;
        private Guna.UI2.WinForms.Guna2ComboBox Companylist;
        private Guna.UI2.WinForms.Guna2DateTimePicker ExpiringDate;
    }
}