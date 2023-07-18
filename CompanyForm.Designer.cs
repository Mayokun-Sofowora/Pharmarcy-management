namespace Pharmacy_management
{
    partial class CompanyForm
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
            Company = new Label();
            CompId = new Label();
            CompanyId = new TextBox();
            CompName = new Label();
            CompanyName = new TextBox();
            CompAddress = new Label();
            CompanyAddress = new TextBox();
            EmpPhoneNo = new Label();
            PhoneNo = new TextBox();
            CompanyGridView = new DataGridView();
            DeleteComp = new Guna.UI2.WinForms.Guna2Button();
            Back = new Guna.UI2.WinForms.Guna2Button();
            UpdateComp = new Guna.UI2.WinForms.Guna2Button();
            AddComp = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)CompanyGridView).BeginInit();
            SuspendLayout();
            // 
            // Company
            // 
            Company.AutoSize = true;
            Company.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Company.ForeColor = Color.ForestGreen;
            Company.Location = new Point(12, 9);
            Company.Name = "Company";
            Company.Size = new Size(271, 29);
            Company.TabIndex = 3;
            Company.Text = "Medicine Manufacturer";
            // 
            // CompId
            // 
            CompId.AutoSize = true;
            CompId.ForeColor = Color.ForestGreen;
            CompId.Location = new Point(12, 89);
            CompId.Name = "CompId";
            CompId.Size = new Size(73, 15);
            CompId.TabIndex = 16;
            CompId.Text = "Company ID";
            // 
            // CompanyId
            // 
            CompanyId.Location = new Point(104, 81);
            CompanyId.Name = "CompanyId";
            CompanyId.Size = new Size(41, 23);
            CompanyId.TabIndex = 15;
            CompanyId.Tag = "Company ID";
            // 
            // CompName
            // 
            CompName.AutoSize = true;
            CompName.ForeColor = Color.ForestGreen;
            CompName.Location = new Point(12, 142);
            CompName.Name = "CompName";
            CompName.Size = new Size(94, 15);
            CompName.TabIndex = 18;
            CompName.Text = "Company Name";
            // 
            // CompanyName
            // 
            CompanyName.Location = new Point(112, 134);
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(129, 23);
            CompanyName.TabIndex = 17;
            CompanyName.Tag = "Company Name";
            // 
            // CompAddress
            // 
            CompAddress.AutoSize = true;
            CompAddress.ForeColor = Color.ForestGreen;
            CompAddress.Location = new Point(12, 260);
            CompAddress.Name = "CompAddress";
            CompAddress.Size = new Size(49, 15);
            CompAddress.TabIndex = 20;
            CompAddress.Text = "Address";
            // 
            // CompanyAddress
            // 
            CompanyAddress.Location = new Point(67, 252);
            CompanyAddress.Name = "CompanyAddress";
            CompanyAddress.Size = new Size(234, 23);
            CompanyAddress.TabIndex = 19;
            CompanyAddress.Tag = "Company Address";
            // 
            // EmpPhoneNo
            // 
            EmpPhoneNo.AutoSize = true;
            EmpPhoneNo.ForeColor = Color.ForestGreen;
            EmpPhoneNo.Location = new Point(12, 198);
            EmpPhoneNo.Name = "EmpPhoneNo";
            EmpPhoneNo.Size = new Size(86, 15);
            EmpPhoneNo.TabIndex = 22;
            EmpPhoneNo.Text = "Phone number";
            // 
            // PhoneNo
            // 
            PhoneNo.AllowDrop = true;
            PhoneNo.Location = new Point(104, 190);
            PhoneNo.Name = "PhoneNo";
            PhoneNo.Size = new Size(127, 23);
            PhoneNo.TabIndex = 21;
            PhoneNo.Tag = "Company Phone number";
            // 
            // CompanyGridView
            // 
            CompanyGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CompanyGridView.BackgroundColor = Color.Honeydew;
            CompanyGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.ForestGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Honeydew;
            dataGridViewCellStyle1.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CompanyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CompanyGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CompanyGridView.DefaultCellStyle = dataGridViewCellStyle2;
            CompanyGridView.Location = new Point(369, 9);
            CompanyGridView.Name = "CompanyGridView";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.ForestGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Honeydew;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CompanyGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            CompanyGridView.RowHeadersWidth = 30;
            CompanyGridView.RowTemplate.Height = 30;
            CompanyGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CompanyGridView.Size = new Size(645, 493);
            CompanyGridView.TabIndex = 23;
            CompanyGridView.CellContentClick += CompanyGridView_CellContentClick;
            // 
            // DeleteComp
            // 
            DeleteComp.CustomizableEdges = customizableEdges1;
            DeleteComp.DisabledState.BorderColor = Color.DarkGray;
            DeleteComp.DisabledState.CustomBorderColor = Color.DarkGray;
            DeleteComp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DeleteComp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DeleteComp.FillColor = Color.ForestGreen;
            DeleteComp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteComp.ForeColor = Color.White;
            DeleteComp.Location = new Point(136, 371);
            DeleteComp.Name = "DeleteComp";
            DeleteComp.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DeleteComp.Size = new Size(84, 33);
            DeleteComp.TabIndex = 24;
            DeleteComp.Text = "DELETE";
            DeleteComp.Click += DeleteComp_Click;
            // 
            // Back
            // 
            Back.CustomizableEdges = customizableEdges3;
            Back.DisabledState.BorderColor = Color.DarkGray;
            Back.DisabledState.CustomBorderColor = Color.DarkGray;
            Back.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Back.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Back.FillColor = Color.ForestGreen;
            Back.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Back.ForeColor = Color.White;
            Back.Location = new Point(136, 450);
            Back.Name = "Back";
            Back.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Back.Size = new Size(84, 33);
            Back.TabIndex = 25;
            Back.Text = "BACK";
            Back.Click += Back_Click;
            // 
            // UpdateComp
            // 
            UpdateComp.CustomizableEdges = customizableEdges5;
            UpdateComp.DisabledState.BorderColor = Color.DarkGray;
            UpdateComp.DisabledState.CustomBorderColor = Color.DarkGray;
            UpdateComp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            UpdateComp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            UpdateComp.FillColor = Color.ForestGreen;
            UpdateComp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateComp.ForeColor = Color.White;
            UpdateComp.Location = new Point(254, 371);
            UpdateComp.Name = "UpdateComp";
            UpdateComp.ShadowDecoration.CustomizableEdges = customizableEdges6;
            UpdateComp.Size = new Size(92, 33);
            UpdateComp.TabIndex = 26;
            UpdateComp.Text = "UPDATE";
            UpdateComp.Click += UpdateComp_Click;
            // 
            // AddComp
            // 
            AddComp.CustomizableEdges = customizableEdges7;
            AddComp.DisabledState.BorderColor = Color.DarkGray;
            AddComp.DisabledState.CustomBorderColor = Color.DarkGray;
            AddComp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddComp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddComp.FillColor = Color.ForestGreen;
            AddComp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddComp.ForeColor = Color.White;
            AddComp.Location = new Point(23, 371);
            AddComp.Name = "AddComp";
            AddComp.ShadowDecoration.CustomizableEdges = customizableEdges8;
            AddComp.Size = new Size(81, 33);
            AddComp.TabIndex = 27;
            AddComp.Text = "ADD";
            AddComp.Click += AddComp_Click;
            // 
            // CompanyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 514);
            Controls.Add(DeleteComp);
            Controls.Add(Back);
            Controls.Add(UpdateComp);
            Controls.Add(AddComp);
            Controls.Add(CompanyGridView);
            Controls.Add(EmpPhoneNo);
            Controls.Add(PhoneNo);
            Controls.Add(CompAddress);
            Controls.Add(CompanyAddress);
            Controls.Add(CompName);
            Controls.Add(CompanyName);
            Controls.Add(CompId);
            Controls.Add(CompanyId);
            Controls.Add(Company);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CompanyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Companies_Load;
            ((System.ComponentModel.ISupportInitialize)CompanyGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Company;
        private Label CompId;
        private TextBox CompanyId;
        private Label CompName;
        private TextBox CompanyName;
        private Label CompAddress;
        private TextBox CompanyAddress;
        private Label EmpPhoneNo;
        private TextBox PhoneNo;
        private DataGridView CompanyGridView;
        private Guna.UI2.WinForms.Guna2Button DeleteComp;
        private Guna.UI2.WinForms.Guna2Button Back;
        private Guna.UI2.WinForms.Guna2Button UpdateComp;
        private Guna.UI2.WinForms.Guna2Button AddComp;
    }
}