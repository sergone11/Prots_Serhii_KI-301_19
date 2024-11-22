using CarServiceApp;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

public partial class RegistrationForm : Form
{
    public static User CurrentUser { get; set; } // Статичне поле для поточного користувача

    public RegistrationForm()
    {
        InitializeComponent();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        // Отримуємо введені дані
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        string carMake = txtCarMake.Text;
        string carModel = txtCarModel.Text;
        string phone = txtPhone.Text;
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        // Перевірка на порожні поля
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(carMake) ||
            string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(username) ||
            string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Будь ласка, заповніть всі поля.");
            return;
        }

        // Створення нового користувача
        CurrentUser = new User(firstName, lastName, carMake, carModel, phone, username, password);

        // Передаємо дані на сервер
        SendDataToServer(CurrentUser);

        MessageBox.Show("Реєстрація успішна!");

        // Перехід на форму авторизації
        AuthorizationForm authorizationForm = new AuthorizationForm();
        authorizationForm.Show();
        this.Hide();
    }

    // Обробник події для кнопки "Скасувати"
    private void btnCancel_Click(object sender, EventArgs e)
    {
        // Повернення до форми авторизації
        AuthorizationForm authorizationForm = new AuthorizationForm();
        authorizationForm.Show();
        this.Hide();
    }

    // Функція для відправки даних на сервер через TCP
    private void SendDataToServer(User user)
    {
        try
        {
            // Адреса сервера (можна змінити на потрібний IP та порт)
            string serverIp = "127.0.0.1"; // IP сервера
            int port = 12345; // Порт сервера

            // Створення TCP з'єднання
            TcpClient client = new TcpClient(serverIp, port);
            NetworkStream stream = client.GetStream();

            // Створення повідомлення, яке містить дані користувача
            string message = $"{user.FirstName},{user.LastName},{user.CarMake},{user.CarModel},{user.Phone},{user.Username},{user.Password}";
            byte[] data = Encoding.ASCII.GetBytes(message);

            // Відправка даних на сервер
            stream.Write(data, 0, data.Length);
            MessageBox.Show("Дані успішно відправлено на сервер.");

            // Закриття з'єднання
            stream.Close();
            client.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Помилка при з'єднанні з сервером: " + ex.Message);
        }
    }

    private void lblCarModel_Click(object sender, EventArgs e)
    {
        // Обробник події для лейблу (якщо потрібен)
    }
}
