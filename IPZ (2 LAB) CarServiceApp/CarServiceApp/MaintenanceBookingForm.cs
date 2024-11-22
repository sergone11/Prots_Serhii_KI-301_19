using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class MaintenanceBookingForm : Form
    {
        public MaintenanceBookingForm()
        {
            InitializeComponent();
        }

        private void btnBookMaintenance_Click(object sender, EventArgs e)
        {
            // Логіка для запису на технічне обслуговування
            string clientName = txtClientName.Text;
            string carModel = txtCarModel.Text;
            DateTime maintenanceDate = dateTimePickerMaintenanceDate.Value;
            DateTime maintenanceTime = dateTimePickerMaintenanceTime.Value;  // час, вибраний користувачем
            string maintenanceType = comboBoxMaintenanceType.SelectedItem?.ToString();

            // Перевірка на порожні поля
            if (string.IsNullOrEmpty(clientName) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(maintenanceType))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            // Додавання запису до бази даних
            if (AddMaintenanceBookingToDatabase(clientName, carModel, maintenanceDate, maintenanceTime, maintenanceType))
            {
                MessageBox.Show($"Запис на ТО успішно створено для {clientName} на автомобіль {carModel}.\nДата ТО: {maintenanceDate.ToShortDateString()}\nЧас ТО: {maintenanceTime.ToShortTimeString()}\nТип ТО: {maintenanceType}");

                // Очищення полів після збереження
                txtClientName.Clear();
                txtCarModel.Clear();
                comboBoxMaintenanceType.SelectedIndex = -1;
                dateTimePickerMaintenanceDate.Value = DateTime.Now;  // скидаємо дату на поточну
                dateTimePickerMaintenanceTime.Value = DateTime.Now;  // скидаємо час на поточний
            }
            else
            {
                MessageBox.Show("Сталася помилка при записі на технічне обслуговування.");
            }
        }

        // Функція для збереження запису на ТО в базу даних
        private bool AddMaintenanceBookingToDatabase(string clientName, string carModel, DateTime maintenanceDate, DateTime maintenanceTime, string maintenanceType)
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=CarServiceDB;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL запит для додавання запису на ТО
                    string query = "INSERT INTO MaintenanceTable (ClientName, CarModel, MaintenanceDate, MaintenanceTime, MaintenanceType) " +
                                   "VALUES (@ClientName, @CarModel, @MaintenanceDate, @MaintenanceTime, @MaintenanceType)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Додавання параметрів для запиту
                        command.Parameters.AddWithValue("@ClientName", clientName);
                        command.Parameters.AddWithValue("@CarModel", carModel);
                        command.Parameters.AddWithValue("@MaintenanceDate", maintenanceDate);
                        command.Parameters.AddWithValue("@MaintenanceTime", maintenanceTime);
                        command.Parameters.AddWithValue("@MaintenanceType", maintenanceType);

                        int result = command.ExecuteNonQuery(); // Виконання запиту

                        // Якщо запит був успішним, повертаємо true
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні даних: {ex.Message}");
                return false;
            }
        }
    }
}
