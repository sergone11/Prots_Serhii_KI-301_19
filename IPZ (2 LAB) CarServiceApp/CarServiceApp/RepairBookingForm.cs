using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarServiceApp
{
    public partial class RepairBookingForm : Form
    {
        public RepairBookingForm()
        {
            InitializeComponent();
        }

        private void btnBookRepair_Click(object sender, EventArgs e)
        {
            // Логіка для запису на ремонт
            string clientName = txtClientName.Text;
            string carModel = txtCarModel.Text;
            DateTime repairDate = dateTimePickerRepairDate.Value;
            DateTime repairTime = dateTimePickerRepairTime.Value;  // час, вибраний користувачем
            string problemDescription = txtProblemDescription.Text;

            // Перевірка на порожні поля
            if (string.IsNullOrEmpty(clientName) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(problemDescription))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            // Додавання запису до бази даних
            if (AddRepairBookingToDatabase(clientName, carModel, repairDate, repairTime, problemDescription))
            {
                MessageBox.Show($"Запис на ремонт успішно створено для {clientName} на автомобіль {carModel}.\nДата ремонту: {repairDate.ToShortDateString()}\nЧас ремонту: {repairTime.ToShortTimeString()}\nОпис проблеми: {problemDescription}");

                // Очищення полів після збереження
                txtClientName.Clear();
                txtCarModel.Clear();
                txtProblemDescription.Clear();
                dateTimePickerRepairDate.Value = DateTime.Now;  // скидаємо дату на поточну
                dateTimePickerRepairTime.Value = DateTime.Now;  // скидаємо час на поточний
            }
            else
            {
                MessageBox.Show("Сталася помилка при записі на ремонт.");
            }
        }

        // Функція для збереження запису на ремонт в базу даних
        private bool AddRepairBookingToDatabase(string clientName, string carModel, DateTime repairDate, DateTime repairTime, string problemDescription)
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=CarServiceDB;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL запит для додавання запису на ремонт
                    string query = "INSERT INTO RepairBookings (ClientName, CarModel, RepairDate, RepairTime, ProblemDescription) " +
                                   "VALUES (@ClientName, @CarModel, @RepairDate, @RepairTime, @ProblemDescription)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Додавання параметрів для запиту
                        command.Parameters.AddWithValue("@ClientName", clientName);
                        command.Parameters.AddWithValue("@CarModel", carModel);
                        command.Parameters.AddWithValue("@RepairDate", repairDate);
                        command.Parameters.AddWithValue("@RepairTime", repairTime);
                        command.Parameters.AddWithValue("@ProblemDescription", problemDescription);

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
