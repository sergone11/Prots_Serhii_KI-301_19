using System;
using System.Linq;
using System.Windows.Forms;
using CarServiceApp;
using Microsoft.EntityFrameworkCore;

public partial class ProfileForm : Form
{
    private CarServiceDbContext _context;

    public ProfileForm()
    {
        InitializeComponent();
        _context = new CarServiceDbContext(new DbContextOptions<CarServiceDbContext>());
        this.Load += ProfileForm_Load;
    }

    private void ProfileForm_Load(object sender, EventArgs e)
    {
        if (RegistrationForm.CurrentUser != null)
        {
            // Отримуємо дані користувача з бази даних
            var user = _context.Users
                .FirstOrDefault(u => u.Username == RegistrationForm.CurrentUser.Username);

            if (user != null)
            {
                // Заповнюємо ярлики даними з бази даних
                lblName.Text = $"Ім'я: {user.FirstName} {user.LastName}";
                lblCarMake.Text = $"Марка автомобіля: {user.CarMake}";
                lblCarModel.Text = $"Модель автомобіля: {user.CarModel}";
                lblPhone.Text = $"Номер телефону: {user.Phone}";
            }
            else
            {
                MessageBox.Show("Користувача не знайдено в базі даних.");
            }
        }
        else
        {
            MessageBox.Show("Не вдалося отримати поточного користувача.");
        }
    }

    private void btnBackToMainMenu_Click(object sender, EventArgs e)
    {
        this.Close();  // Закриває форму профілю та повертає до головного меню
        MainMenuForm mainMenuForm = new MainMenuForm();  // Використовуємо правильну назву форми
        mainMenuForm.Show();  // Показуємо головне меню
    }
}
