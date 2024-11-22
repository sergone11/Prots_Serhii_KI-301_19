namespace CarServiceApp
{
    partial class RepairBookingForm
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
            txtClientName = new TextBox();
            txtCarModel = new TextBox();
            txtProblemDescription = new TextBox();
            dateTimePickerRepairDate = new DateTimePicker();
            dateTimePickerRepairTime = new DateTimePicker();  // нове поле для часу
            btnBookRepair = new Button();
            btnBackToMainMenu = new Button();
            lblClientName = new Label();
            lblCarModel = new Label();
            lblProblemDescription = new Label();
            lblRepairDate = new Label();
            lblRepairTime = new Label();  // нова етикетка для часу
            SuspendLayout();
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(50, 37);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(200, 31);
            txtClientName.TabIndex = 0;
            // 
            // txtCarModel
            // 
            txtCarModel.Location = new Point(50, 99);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(200, 31);
            txtCarModel.TabIndex = 1;
            // 
            // txtProblemDescription
            // 
            txtProblemDescription.Location = new Point(50, 158);
            txtProblemDescription.Multiline = true;
            txtProblemDescription.Name = "txtProblemDescription";
            txtProblemDescription.Size = new Size(200, 50);
            txtProblemDescription.TabIndex = 2;
            // 
            // dateTimePickerRepairDate
            // 
            dateTimePickerRepairDate.Location = new Point(50, 247);
            dateTimePickerRepairDate.Name = "dateTimePickerRepairDate";
            dateTimePickerRepairDate.Size = new Size(200, 31);
            dateTimePickerRepairDate.TabIndex = 3;
            // 
            // dateTimePickerRepairTime
            // 
            dateTimePickerRepairTime.Format = DateTimePickerFormat.Time;  // формат для часу
            dateTimePickerRepairTime.Location = new Point(50, 320);
            dateTimePickerRepairTime.Name = "dateTimePickerRepairTime";
            dateTimePickerRepairTime.Size = new Size(200, 31);
            dateTimePickerRepairTime.TabIndex = 4;
            // 
            // btnBookRepair
            // 
            btnBookRepair.Location = new Point(50, 357);
            btnBookRepair.Name = "btnBookRepair";
            btnBookRepair.Size = new Size(200, 40);
            btnBookRepair.TabIndex = 5;
            btnBookRepair.Text = "Записатися на ремонт";
            btnBookRepair.UseVisualStyleBackColor = true;
            btnBookRepair.Click += btnBookRepair_Click;
            // 
            // btnBackToMainMenu
            // 
            btnBackToMainMenu.Location = new Point(50, 402);
            btnBackToMainMenu.Name = "btnBackToMainMenu";
            btnBackToMainMenu.Size = new Size(200, 40);
            btnBackToMainMenu.TabIndex = 10;
            btnBackToMainMenu.Text = "Повернутися в головне меню";
            btnBackToMainMenu.UseVisualStyleBackColor = true;
            btnBackToMainMenu.Click += btnBackToMainMenu_Click;
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(50, 9);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(108, 25);
            lblClientName.TabIndex = 6;
            lblClientName.Text = "Ім'я клієнта:";
            // 
            // lblCarModel
            // 
            lblCarModel.AutoSize = true;
            lblCarModel.Location = new Point(50, 71);
            lblCarModel.Name = "lblCarModel";
            lblCarModel.Size = new Size(122, 25);
            lblCarModel.TabIndex = 7;
            lblCarModel.Text = "Модель авто:";
            // 
            // lblProblemDescription
            // 
            lblProblemDescription.AutoSize = true;
            lblProblemDescription.Location = new Point(50, 130);
            lblProblemDescription.Name = "lblProblemDescription";
            lblProblemDescription.Size = new Size(226, 25);
            lblProblemDescription.TabIndex = 8;
            lblProblemDescription.Text = "Опис проблеми/поломки:";
            // 
            // lblRepairDate
            // 
            lblRepairDate.AutoSize = true;
            lblRepairDate.Location = new Point(50, 219);
            lblRepairDate.Name = "lblRepairDate";
            lblRepairDate.Size = new Size(128, 25);
            lblRepairDate.TabIndex = 9;
            lblRepairDate.Text = "Дата ремонту:";
            // 
            // lblRepairTime
            // 
            lblRepairTime.AutoSize = true;
            lblRepairTime.Location = new Point(50, 292);
            lblRepairTime.Name = "lblRepairTime";
            lblRepairTime.Size = new Size(115, 25);
            lblRepairTime.TabIndex = 10;
            lblRepairTime.Text = "Час ремонту:";
            // 
            // RepairBookingForm
            // 
            ClientSize = new Size(353, 462);
            Controls.Add(btnBackToMainMenu);
            Controls.Add(btnBookRepair);
            Controls.Add(lblRepairTime);
            Controls.Add(dateTimePickerRepairTime);
            Controls.Add(lblRepairDate);
            Controls.Add(dateTimePickerRepairDate);
            Controls.Add(lblProblemDescription);
            Controls.Add(txtProblemDescription);
            Controls.Add(lblCarModel);
            Controls.Add(txtCarModel);
            Controls.Add(lblClientName);
            Controls.Add(txtClientName);
            Name = "RepairBookingForm";
            Text = "Запис на ремонт";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtProblemDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerRepairDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerRepairTime;  // нове поле для часу
        private System.Windows.Forms.Button btnBookRepair;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblProblemDescription;
        private System.Windows.Forms.Label lblRepairDate;
        private System.Windows.Forms.Label lblRepairTime;  // нова етикетка для часу

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            // Закриваємо поточну форму і відкриваємо головне меню
            this.Close();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }
    }
}