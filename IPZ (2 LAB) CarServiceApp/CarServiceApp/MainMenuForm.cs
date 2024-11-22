using System;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        // Обробник події для кнопки запису на ремонт
        private void btnRepairBooking_Click(object sender, EventArgs e)
        {
            try
            {
                // Відкриваємо форму запису на ремонт
                RepairBookingForm repairForm = new RepairBookingForm();
                repairForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при відкритті форми запису на ремонт: " + ex.Message);
            }
        }

        // Обробник події для кнопки запису на ТО
        private void btnMaintenanceBooking_Click(object sender, EventArgs e)
        {
            try
            {
                // Відкриваємо форму запису на ТО
                MaintenanceBookingForm maintenanceForm = new MaintenanceBookingForm();
                maintenanceForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при відкритті форми запису на ТО: " + ex.Message);
            }
        }

        // Обробник події для кнопки профілю
        private void btnProfile_Click(object sender, EventArgs e)
        {
            try
            {
                // Відкриваємо форму профілю
                ProfileForm profileForm = new ProfileForm();
                profileForm.Show();
                // Сховуємо поточну форму
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при відкритті форми профілю: " + ex.Message);
            }
        }
    }
}
