namespace Pharmacy_management
{
    partial class EmployeeForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            EmpGender = new Guna.UI2.WinForms.Guna2ComboBox();
            EmpPhoneNo = new Label();
            EmpId = new Label();
            EmpAge = new Label();
            EmpFirstName = new Label();
            PhoneNo = new TextBox();
            Age = new TextBox();
            EmployeeId = new TextBox();
            FirstName = new TextBox();
            EmpSal = new Label();
            salary = new TextBox();
            DeleteEmp = new Guna.UI2.WinForms.Guna2Button();
            Back = new Guna.UI2.WinForms.Guna2Button();
            UpdateEmp = new Guna.UI2.WinForms.Guna2Button();
            AddEmp = new Guna.UI2.WinForms.Guna2Button();
            EmployeesGridView = new DataGridView();
            lastName = new TextBox();
            EmpLastName = new Label();
            Password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)EmployeesGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
            label1.TabIndex = 2;
            label1.Text = "Employees";
            // 
            // EmpGender
            // 
            EmpGender.AccessibleDescription = "EmpGender";
            EmpGender.AccessibleName = "EmpGender";
            EmpGender.BackColor = Color.Transparent;
            EmpGender.CustomizableEdges = customizableEdges1;
            EmpGender.DrawMode = DrawMode.OwnerDrawFixed;
            EmpGender.DropDownStyle = ComboBoxStyle.DropDownList;
            EmpGender.FocusedColor = Color.FromArgb(94, 148, 255);
            EmpGender.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            EmpGender.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            EmpGender.ForeColor = Color.FromArgb(68, 88, 112);
            EmpGender.ItemHeight = 30;
            EmpGender.Items.AddRange(new object[] { "Male", "Female" });
            EmpGender.Location = new Point(223, 68);
            EmpGender.Name = "EmpGender";
            EmpGender.ShadowDecoration.CustomizableEdges = customizableEdges2;
            EmpGender.Size = new Size(140, 36);
            EmpGender.TabIndex = 17;
            // 
            // EmpPhoneNo
            // 
            EmpPhoneNo.AutoSize = true;
            EmpPhoneNo.ForeColor = Color.ForestGreen;
            EmpPhoneNo.Location = new Point(125, 307);
            EmpPhoneNo.Name = "EmpPhoneNo";
            EmpPhoneNo.Size = new Size(86, 15);
            EmpPhoneNo.TabIndex = 13;
            EmpPhoneNo.Text = "Phone number";
            // 
            // EmpId
            // 
            EmpId.AutoSize = true;
            EmpId.ForeColor = Color.ForestGreen;
            EmpId.Location = new Point(12, 87);
            EmpId.Name = "EmpId";
            EmpId.Size = new Size(73, 15);
            EmpId.TabIndex = 14;
            EmpId.Text = "Employee ID";
            // 
            // EmpAge
            // 
            EmpAge.AutoSize = true;
            EmpAge.ForeColor = Color.ForestGreen;
            EmpAge.Location = new Point(12, 307);
            EmpAge.Name = "EmpAge";
            EmpAge.Size = new Size(28, 15);
            EmpAge.TabIndex = 15;
            EmpAge.Text = "Age";
            // 
            // EmpFirstName
            // 
            EmpFirstName.AutoSize = true;
            EmpFirstName.ForeColor = Color.ForestGreen;
            EmpFirstName.Location = new Point(12, 166);
            EmpFirstName.Name = "EmpFirstName";
            EmpFirstName.Size = new Size(64, 15);
            EmpFirstName.TabIndex = 16;
            EmpFirstName.Text = "First Name";
            // 
            // PhoneNo
            // 
            PhoneNo.AllowDrop = true;
            PhoneNo.Location = new Point(217, 299);
            PhoneNo.Name = "PhoneNo";
            PhoneNo.Size = new Size(127, 23);
            PhoneNo.TabIndex = 9;
            PhoneNo.Tag = "Employee Phone number";
            // 
            // Age
            // 
            Age.Location = new Point(46, 299);
            Age.Name = "Age";
            Age.Size = new Size(41, 23);
            Age.TabIndex = 10;
            Age.Tag = "Employee Age";
            // 
            // EmployeeId
            // 
            EmployeeId.Location = new Point(91, 81);
            EmployeeId.Name = "EmployeeId";
            EmployeeId.Size = new Size(41, 23);
            EmployeeId.TabIndex = 11;
            EmployeeId.Tag = "Employee ID";
            // 
            // FirstName
            // 
            FirstName.Location = new Point(82, 158);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(129, 23);
            FirstName.TabIndex = 12;
            FirstName.Tag = "Employees First Name";
            // 
            // EmpSal
            // 
            EmpSal.AutoSize = true;
            EmpSal.ForeColor = Color.ForestGreen;
            EmpSal.Location = new Point(250, 237);
            EmpSal.Name = "EmpSal";
            EmpSal.Size = new Size(38, 15);
            EmpSal.TabIndex = 16;
            EmpSal.Text = "Salary";
            // 
            // salary
            // 
            salary.Location = new Point(294, 229);
            salary.Name = "salary";
            salary.Size = new Size(69, 23);
            salary.TabIndex = 12;
            salary.Tag = "Employee Salary";
            // 
            // DeleteEmp
            // 
            DeleteEmp.CustomizableEdges = customizableEdges3;
            DeleteEmp.DisabledState.BorderColor = Color.DarkGray;
            DeleteEmp.DisabledState.CustomBorderColor = Color.DarkGray;
            DeleteEmp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DeleteEmp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DeleteEmp.FillColor = Color.ForestGreen;
            DeleteEmp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteEmp.ForeColor = Color.White;
            DeleteEmp.Location = new Point(134, 374);
            DeleteEmp.Name = "DeleteEmp";
            DeleteEmp.ShadowDecoration.CustomizableEdges = customizableEdges4;
            DeleteEmp.Size = new Size(84, 33);
            DeleteEmp.TabIndex = 18;
            DeleteEmp.Text = "DELETE";
            DeleteEmp.Click += DeleteEmp_Click;
            // 
            // Back
            // 
            Back.CustomizableEdges = customizableEdges5;
            Back.DisabledState.BorderColor = Color.DarkGray;
            Back.DisabledState.CustomBorderColor = Color.DarkGray;
            Back.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Back.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Back.FillColor = Color.ForestGreen;
            Back.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Back.ForeColor = Color.White;
            Back.Location = new Point(134, 453);
            Back.Name = "Back";
            Back.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Back.Size = new Size(84, 33);
            Back.TabIndex = 19;
            Back.Text = "BACK";
            Back.Click += Back_Click;
            // 
            // UpdateEmp
            // 
            UpdateEmp.CustomizableEdges = customizableEdges7;
            UpdateEmp.DisabledState.BorderColor = Color.DarkGray;
            UpdateEmp.DisabledState.CustomBorderColor = Color.DarkGray;
            UpdateEmp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            UpdateEmp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            UpdateEmp.FillColor = Color.ForestGreen;
            UpdateEmp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateEmp.ForeColor = Color.White;
            UpdateEmp.Location = new Point(252, 374);
            UpdateEmp.Name = "UpdateEmp";
            UpdateEmp.ShadowDecoration.CustomizableEdges = customizableEdges8;
            UpdateEmp.Size = new Size(92, 33);
            UpdateEmp.TabIndex = 20;
            UpdateEmp.Text = "UPDATE";
            UpdateEmp.Click += UpdateEmp_Click;
            // 
            // AddEmp
            // 
            AddEmp.CustomizableEdges = customizableEdges9;
            AddEmp.DisabledState.BorderColor = Color.DarkGray;
            AddEmp.DisabledState.CustomBorderColor = Color.DarkGray;
            AddEmp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddEmp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddEmp.FillColor = Color.ForestGreen;
            AddEmp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddEmp.ForeColor = Color.White;
            AddEmp.Location = new Point(21, 374);
            AddEmp.Name = "AddEmp";
            AddEmp.ShadowDecoration.CustomizableEdges = customizableEdges10;
            AddEmp.Size = new Size(81, 33);
            AddEmp.TabIndex = 21;
            AddEmp.Text = "ADD";
            AddEmp.Click += AddEmp_Click;
            // 
            // EmployeesGridView
            // 
            EmployeesGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmployeesGridView.BackgroundColor = Color.Honeydew;
            EmployeesGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.ForestGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Honeydew;
            dataGridViewCellStyle1.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EmployeesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EmployeesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EmployeesGridView.DefaultCellStyle = dataGridViewCellStyle2;
            EmployeesGridView.Location = new Point(369, 12);
            EmployeesGridView.Name = "EmployeesGridView";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.ForestGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Honeydew;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            EmployeesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            EmployeesGridView.RowHeadersWidth = 30;
            EmployeesGridView.RowTemplate.Height = 30;
            EmployeesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeesGridView.Size = new Size(645, 493);
            EmployeesGridView.TabIndex = 22;
            EmployeesGridView.CellContentClick += EmployeesGridView_CellContentClick;
            // 
            // lastName
            // 
            lastName.Location = new Point(82, 229);
            lastName.Name = "lastName";
            lastName.Size = new Size(129, 23);
            lastName.TabIndex = 12;
            lastName.Tag = "Employees Last Name";
            // 
            // EmpLastName
            // 
            EmpLastName.AutoSize = true;
            EmpLastName.ForeColor = Color.ForestGreen;
            EmpLastName.Location = new Point(12, 237);
            EmpLastName.Name = "EmpLastName";
            EmpLastName.Size = new Size(63, 15);
            EmpLastName.TabIndex = 16;
            EmpLastName.Text = "Last Name";
            // 
            // Password
            // 
            Password.ForeColor = Color.ForestGreen;
            Password.Location = new Point(234, 158);
            Password.Name = "Password";
            Password.Size = new Size(129, 23);
            Password.TabIndex = 12;
            Password.Tag = "Pass";
            Password.Text = "Password";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 514);
            Controls.Add(EmployeesGridView);
            Controls.Add(DeleteEmp);
            Controls.Add(Back);
            Controls.Add(UpdateEmp);
            Controls.Add(AddEmp);
            Controls.Add(EmpGender);
            Controls.Add(EmpPhoneNo);
            Controls.Add(EmpId);
            Controls.Add(EmpAge);
            Controls.Add(EmpSal);
            Controls.Add(EmpLastName);
            Controls.Add(EmpFirstName);
            Controls.Add(PhoneNo);
            Controls.Add(Age);
            Controls.Add(EmployeeId);
            Controls.Add(salary);
            Controls.Add(lastName);
            Controls.Add(Password);
            Controls.Add(FirstName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            Load += Employees_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox EmpGender;
        private Label EmpPhoneNo;
        private Label EmpId;
        private Label EmpAge;
        private Label EmpFirstName;
        private Label EmpLastName;
        private Label EmpSal;
        private TextBox PhoneNo;
        private TextBox Age;
        private TextBox EmployeeId;
        private TextBox FirstName;
        private TextBox salary;
        private TextBox lastName;
        private Guna.UI2.WinForms.Guna2Button DeleteEmp;
        private Guna.UI2.WinForms.Guna2Button Back;
        private Guna.UI2.WinForms.Guna2Button UpdateEmp;
        private Guna.UI2.WinForms.Guna2Button AddEmp;
        private DataGridView EmployeesGridView;
        private TextBox Password;
    }
}