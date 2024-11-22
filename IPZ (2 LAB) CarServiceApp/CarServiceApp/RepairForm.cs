using System;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class RepairForm : Form
    {
        public RepairForm()
        {
            InitializeComponent();
        }

        private void btnBookRepair_Click(object sender, EventArgs e)
        {
            // Логіка для запису на ремонт
            string carModel = txtCarModel.Text;
            string repairType = cmbRepairType.SelectedItem?.ToString();
            DateTime repairDate = dtpRepairDate.Value;

            if (string.IsNullOrEmpty(carModel) || repairType == null)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
            }
            else
            {
                // Тут можна додати логіку для обробки запису на ремонт
                MessageBox.Show($"Запис на ремонт для {carModel} на {repairDate.ToShortDateString()} з типом ремонту: {repairType}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрити форму
        }
    }
}
