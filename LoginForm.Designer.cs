namespace Pharmacy_management
{
    partial class LoginForm
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
            TextBox Password;
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            UserID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            Password = new TextBox();
            SuspendLayout();
            // 
            // Password
            // 
            Password.Location = new Point(121, 204);
            Password.Name = "Password";
            Password.Size = new Size(198, 23);
            Password.TabIndex = 4;
            Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Hv BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(174, 39);
            label1.Name = "label1";
            label1.Size = new Size(81, 29);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // UserID
            // 
            UserID.AutoCompleteMode = AutoCompleteMode.Suggest;
            UserID.Location = new Point(121, 120);
            UserID.Name = "UserID";
            UserID.Size = new Size(198, 23);
            UserID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(48, 211);
            label3.Name = "label3";
            label3.Size = new Size(63, 16);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(48, 127);
            label2.Name = "label2";
            label2.Size = new Size(45, 16);
            label2.TabIndex = 1;
            label2.Text = "UserID";
            // 
            // LoginBtn
            // 
            LoginBtn.BorderRadius = 23;
            LoginBtn.CustomizableEdges = customizableEdges1;
            LoginBtn.DisabledState.BorderColor = Color.DarkGray;
            LoginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginBtn.FillColor = Color.ForestGreen;
            LoginBtn.Font = new Font("Swis721 BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.Honeydew;
            LoginBtn.Location = new Point(121, 293);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LoginBtn.Size = new Size(198, 45);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "LOGIN";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(418, 375);
            Controls.Add(LoginBtn);
            Controls.Add(Password);
            Controls.Add(UserID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UserID;
        private TextBox Password;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button LoginBtn;
    }
}