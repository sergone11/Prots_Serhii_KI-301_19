namespace CarServiceApp
{
    partial class RepairForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnBookRepair;
        private Button btnCancel;
        private TextBox txtCarModel;
        private ComboBox cmbRepairType;
        private DateTimePicker dtpRepairDate;

        private void InitializeComponent()
        {
            btnBookRepair = new Button();
            btnCancel = new Button();
            txtCarModel = new TextBox();
            cmbRepairType = new ComboBox();
            dtpRepairDate = new DateTimePicker();
            SuspendLayout();
            // 
            // btnBookRepair
            // 
            btnBookRepair.Location = new Point(100, 150);
            btnBookRepair.Name = "btnBookRepair";
            btnBookRepair.Size = new Size(150, 34);
            btnBookRepair.TabIndex = 0;
            btnBookRepair.Text = "Записати на ремонт";
            btnBookRepair.UseVisualStyleBackColor = true;
            btnBookRepair.Click += btnBookRepair_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(100, 190);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtCarModel
            // 
            txtCarModel.Location = new Point(100, 50);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.PlaceholderText = "Модель автомобіля";
            txtCarModel.Size = new Size(150, 31);
            txtCarModel.TabIndex = 2;
            // 
            // cmbRepairType
            // 
            cmbRepairType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRepairType.FormattingEnabled = true;
            cmbRepairType.Items.AddRange(new object[] { "Ремонт двигуна", "Ремонт трансмісії", "Ремонт гальм" });
            cmbRepairType.Location = new Point(100, 90);
            cmbRepairType.Name = "cmbRepairType";
            cmbRepairType.Size = new Size(150, 33);
            cmbRepairType.TabIndex = 3;
            // 
            // dtpRepairDate
            // 
            dtpRepairDate.Location = new Point(100, 120);
            dtpRepairDate.Name = "dtpRepairDate";
            dtpRepairDate.Size = new Size(200, 31);
            dtpRepairDate.TabIndex = 4;
            // 
            // RepairForm
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(dtpRepairDate);
            Controls.Add(cmbRepairType);
            Controls.Add(txtCarModel);
            Controls.Add(btnCancel);
            Controls.Add(btnBookRepair);
            Name = "RepairForm";
            Text = "Запис на ремонт";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
