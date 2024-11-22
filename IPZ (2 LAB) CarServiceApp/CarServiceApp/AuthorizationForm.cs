using CarServiceApp;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class AuthorizationForm : Form
{
    public AuthorizationForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        // Перевірка введених даних
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Будь ласка, введіть логін і пароль.");
            return;
        }

        // Перевірка логіна і пароля через базу даних
        if (ValidateUserCredentials(username, password))
        {
            MessageBox.Show("Вхід успішний!");

            // Створення екземпляра головного меню
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show(); // Показуємо форму головного меню

            this.Hide(); // Приховуємо форму авторизації
        }
        else
        {
            MessageBox.Show("Невірний логін або пароль.");
        }
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        // Переходимо на форму реєстрації
        RegistrationForm registrationForm = new RegistrationForm();
        registrationForm.Show();
        this.Hide(); // Приховуємо форму авторизації
    }

    // Функція для перевірки логіна і пароля через базу даних
    private bool ValidateUserCredentials(string username, string password)
    {
        try
        {
            string connectionString = "Data Source=localhost;Initial Catalog=CarServiceDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL запит для перевірки існування користувача з таким логіном та паролем
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Додавання параметрів для запиту
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int userCount = (int)command.ExecuteScalar(); // Отримуємо кількість користувачів з таким логіном і паролем

                    // Якщо кількість користувачів більше 0, то логін і пароль правильні
                    return userCount > 0;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Помилка при перевірці користувача: {ex.Message}");
            return false;
        }
    }
}
