namespace CarServiceApp
{
    partial class MaintenanceBookingForm
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
            comboBoxMaintenanceType = new ComboBox();
            dateTimePickerMaintenanceDate = new DateTimePicker();
            dateTimePickerMaintenanceTime = new DateTimePicker();  // нове поле для часу
            btnBookMaintenance = new Button();
            btnBackToMainMenu = new Button();
            lblClientName = new Label();
            lblCarModel = new Label();
            lblMaintenanceType = new Label();
            lblMaintenanceDate = new Label();
            lblMaintenanceTime = new Label();  // нова етикетка для часу
            SuspendLayout();
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(50, 26);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(200, 31);
            txtClientName.TabIndex = 0;
            // 
            // txtCarModel
            // 
            txtCarModel.Location = new Point(50, 96);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(200, 31);
            txtCarModel.TabIndex = 1;
            // 
            // comboBoxMaintenanceType
            // 
            comboBoxMaintenanceType.FormattingEnabled = true;
            comboBoxMaintenanceType.Items.AddRange(new object[] { "ТО-1", "ТО-2", "ТО-3" });
            comboBoxMaintenanceType.Location = new Point(50, 155);
            comboBoxMaintenanceType.Name = "comboBoxMaintenanceType";
            comboBoxMaintenanceType.Size = new Size(200, 33);
            comboBoxMaintenanceType.TabIndex = 2;
            // 
            // dateTimePickerMaintenanceDate
            // 
            dateTimePickerMaintenanceDate.Location = new Point(50, 235);
            dateTimePickerMaintenanceDate.Name = "dateTimePickerMaintenanceDate";
            dateTimePickerMaintenanceDate.Size = new Size(200, 31);
            dateTimePickerMaintenanceDate.TabIndex = 3;
            // 
            // dateTimePickerMaintenanceTime
            // 
            dateTimePickerMaintenanceTime.Format = DateTimePickerFormat.Time;  // формат для часу
            dateTimePickerMaintenanceTime.Location = new Point(50, 310);
            dateTimePickerMaintenanceTime.Name = "dateTimePickerMaintenanceTime";
            dateTimePickerMaintenanceTime.Size = new Size(200, 31);
            dateTimePickerMaintenanceTime.TabIndex = 4;
            // 
            // btnBookMaintenance
            // 
            btnBookMaintenance.Location = new Point(50, 357);
            btnBookMaintenance.Name = "btnBookMaintenance";
            btnBookMaintenance.Size = new Size(200, 40);
            btnBookMaintenance.TabIndex = 5;
            btnBookMaintenance.Text = "Записатися на ТО";
            btnBookMaintenance.UseVisualStyleBackColor = true;
            btnBookMaintenance.Click += btnBookMaintenance_Click;
            // 
            // btnBackToMainMenu
            // 
            btnBackToMainMenu.Location = new Point(50, 402);
            btnBackToMainMenu.Name = "btnBackToMainMenu";
            btnBackToMainMenu.Size = new Size(239, 40);
            btnBackToMainMenu.TabIndex = 9;
            btnBackToMainMenu.Text = "Повернутися в головне меню";
            btnBackToMainMenu.UseVisualStyleBackColor = true;
            btnBackToMainMenu.Click += btnBackToMainMenu_Click;
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(50, -2);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(108, 25);
            lblClientName.TabIndex = 5;
            lblClientName.Text = "Ім'я клієнта:";
            // 
            // lblCarModel
            // 
            lblCarModel.AutoSize = true;
            lblCarModel.Location = new Point(40, 60);
            lblCarModel.Name = "lblCarModel";
            lblCarModel.Size = new Size(122, 25);
            lblCarModel.TabIndex = 6;
            lblCarModel.Text = "Модель авто:";
            // 
            // lblMaintenanceType
            // 
            lblMaintenanceType.AutoSize = true;
            lblMaintenanceType.Location = new Point(40, 129);
            lblMaintenanceType.Name = "lblMaintenanceType";
            lblMaintenanceType.Size = new Size(210, 25);
            lblMaintenanceType.TabIndex = 7;
            lblMaintenanceType.Text = "Тип тех.обслуговування:";
            // 
            // lblMaintenanceDate
            // 
            lblMaintenanceDate.AutoSize = true;
            lblMaintenanceDate.Location = new Point(50, 191);
            lblMaintenanceDate.Name = "lblMaintenanceDate";
            lblMaintenanceDate.Size = new Size(218, 25);
            lblMaintenanceDate.TabIndex = 8;
            lblMaintenanceDate.Text = "Дата тех.обслуговування:";
            // 
            // lblMaintenanceTime
            // 
            lblMaintenanceTime.AutoSize = true;
            lblMaintenanceTime.Location = new Point(50, 282);
            lblMaintenanceTime.Name = "lblMaintenanceTime";
            lblMaintenanceTime.Size = new Size(127, 25);
            lblMaintenanceTime.TabIndex = 10;
            lblMaintenanceTime.Text = "Час тех.обслуговування:";
            // 
            // MaintenanceBookingForm
            // 
            ClientSize = new Size(456, 462);
            Controls.Add(btnBackToMainMenu);
            Controls.Add(btnBookMaintenance);
            Controls.Add(lblMaintenanceTime);
            Controls.Add(dateTimePickerMaintenanceTime);
            Controls.Add(lblMaintenanceDate);
            Controls.Add(dateTimePickerMaintenanceDate);
            Controls.Add(lblMaintenanceType);
            Controls.Add(comboBoxMaintenanceType);
            Controls.Add(lblCarModel);
            Controls.Add(txtCarModel);
            Controls.Add(lblClientName);
            Controls.Add(txtClientName);
            Name = "MaintenanceBookingForm";
            Text = "Запис на ТО";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.ComboBox comboBoxMaintenanceType;
        private System.Windows.Forms.DateTimePicker dateTimePickerMaintenanceDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerMaintenanceTime;  // нове поле для часу
        private System.Windows.Forms.Button btnBookMaintenance;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblMaintenanceType;
        private System.Windows.Forms.Label lblMaintenanceDate;
        private System.Windows.Forms.Label lblMaintenanceTime;  // нова етикетка для часу

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            // Закриваємо поточну форму і відкриваємо головне меню
            this.Close();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }
    }
}