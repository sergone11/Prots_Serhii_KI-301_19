using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key] // Позначаємо UserId як ключ
    public int UserId { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string CarMake { get; set; }

    [Required]
    public string CarModel { get; set; }

    [Required]
    [Phone] // Валідація для номера телефону
    public string Phone { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    [DataType(DataType.Password)] // Шифруємо пароль
    public string Password { get; set; }

    // Конструктор без параметрів для Entity Framework
    public User() { }

    // Конструктор для ініціалізації
    public User(string firstName, string lastName, string carMake, string carModel, string phone, string username, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        CarMake = carMake;
        CarModel = carModel;
        Phone = phone;
        Username = username;
        Password = password;
    }
}
