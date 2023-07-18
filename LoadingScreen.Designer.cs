namespace Pharmacy_management
{
    partial class LoadingScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            Pharmacy = new Label();
            PoweredBy = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.DimGray;
            progressBar1.ForeColor = Color.Honeydew;
            progressBar1.Location = new Point(178, 206);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(266, 23);
            progressBar1.TabIndex = 0;
            // 
            // Pharmacy
            // 
            Pharmacy.AutoSize = true;
            Pharmacy.Font = new Font("Swis721 BlkCn BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Pharmacy.ForeColor = Color.White;
            Pharmacy.Location = new Point(201, 48);
            Pharmacy.Name = "Pharmacy";
            Pharmacy.Size = new Size(195, 32);
            Pharmacy.TabIndex = 1;
            Pharmacy.Text = "PharmaCentrum";
            // 
            // PoweredBy
            // 
            PoweredBy.AutoSize = true;
            PoweredBy.Font = new Font("Swis721 BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PoweredBy.ForeColor = Color.White;
            PoweredBy.Location = new Point(253, 80);
            PoweredBy.Name = "PoweredBy";
            PoweredBy.Size = new Size(143, 16);
            PoweredBy.TabIndex = 2;
            PoweredBy.Text = "Powered by The Mayor";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // LoadingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(616, 275);
            Controls.Add(PoweredBy);
            Controls.Add(Pharmacy);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label Pharmacy;
        private Label PoweredBy;
        private System.Windows.Forms.Timer timer1;
    }
}