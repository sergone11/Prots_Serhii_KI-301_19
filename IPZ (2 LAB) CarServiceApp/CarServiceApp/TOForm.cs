using System;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class TOForm : Form
    {
        public TOForm()
        {
            InitializeComponent();
        }

        private void btnBookTO_Click(object sender, EventArgs e)
        {
            // Логіка для запису на технічне обслуговування
            string carModel = txtCarModel.Text;
            string serviceType = cmbServiceType.SelectedItem?.ToString();
            DateTime serviceDate = dtpServiceDate.Value;

            if (string.IsNullOrEmpty(carModel) || serviceType == null)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
            }
            else
            {
                // Тут можна додати логіку для обробки запису на ТО
                MessageBox.Show($"Запис на ТО для {carModel} на {serviceDate.ToShortDateString()} з типом обслуговування: {serviceType}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрити форму
        }
    }
}
