namespace CarServiceApp
{
    partial class TOForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnBookTO;
        private Button btnCancel;
        private TextBox txtCarModel;
        private ComboBox cmbServiceType;
        private DateTimePicker dtpServiceDate;

        private void InitializeComponent()
        {
            this.btnBookTO = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnBookTO
            // 
            this.btnBookTO.Location = new System.Drawing.Point(100, 150);
            this.btnBookTO.Name = "btnBookTO";
            this.btnBookTO.Size = new System.Drawing.Size(150, 23);
            this.btnBookTO.TabIndex = 0;
            this.btnBookTO.Text = "Записати на ТО";
            this.btnBookTO.UseVisualStyleBackColor = true;
            this.btnBookTO.Click += new System.EventHandler(this.btnBookTO_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(100, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(100, 50);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(150, 20);
            this.txtCarModel.TabIndex = 2;
            this.txtCarModel.PlaceholderText = "Модель автомобіля";
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Items.AddRange(new object[] {
            "Заміна масла",
            "Заміна шин",
            "Перевірка гальм"});
            this.cmbServiceType.Location = new System.Drawing.Point(100, 90);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(150, 21);
            this.cmbServiceType.TabIndex = 3;
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Location = new System.Drawing.Point(100, 120);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(200, 20);
            this.dtpServiceDate.TabIndex = 4;
            // 
            // TOForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dtpServiceDate);
            this.Controls.Add(this.cmbServiceType);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBookTO);
            this.Name = "TOForm";
            this.Text = "Запис на ТО";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
