namespace CarServiceApp
{
    partial class MainMenuForm
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

        private void InitializeComponent()
        {
            btnRepairBooking = new Button();
            btnMaintenanceBooking = new Button();
            btnProfile = new Button();
            SuspendLayout();
            // 
            // btnRepairBooking
            // 
            btnRepairBooking.Location = new Point(50, 50);
            btnRepairBooking.Name = "btnRepairBooking";
            btnRepairBooking.Size = new Size(183, 40);
            btnRepairBooking.TabIndex = 0;
            btnRepairBooking.Text = "Запис на ремонт";
            btnRepairBooking.UseVisualStyleBackColor = true;
            btnRepairBooking.Click += btnRepairBooking_Click;
            // 
            // btnMaintenanceBooking
            // 
            btnMaintenanceBooking.Location = new Point(50, 100);
            btnMaintenanceBooking.Name = "btnMaintenanceBooking";
            btnMaintenanceBooking.Size = new Size(183, 40);
            btnMaintenanceBooking.TabIndex = 1;
            btnMaintenanceBooking.Text = "Запис на ТО";
            btnMaintenanceBooking.UseVisualStyleBackColor = true;
            btnMaintenanceBooking.Click += btnMaintenanceBooking_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(50, 150);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(183, 40);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Профіль";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // MainMenuForm
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(btnProfile);
            Controls.Add(btnMaintenanceBooking);
            Controls.Add(btnRepairBooking);
            Name = "MainMenuForm";
            Text = "Основне меню";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnRepairBooking;
        private System.Windows.Forms.Button btnMaintenanceBooking;
        private System.Windows.Forms.Button btnProfile;
    }
}
