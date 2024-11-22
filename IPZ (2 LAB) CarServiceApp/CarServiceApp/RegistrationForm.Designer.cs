partial class RegistrationForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox txtFirstName; // Текстове поле для введення імені
    private System.Windows.Forms.TextBox txtLastName; // Текстове поле для введення прізвища
    private System.Windows.Forms.TextBox txtCarMake; // Текстове поле для введення марки автомобіля
    private System.Windows.Forms.TextBox txtCarModel; // Текстове поле для введення моделі автомобіля
    private System.Windows.Forms.TextBox txtPhone; // Текстове поле для введення телефону
    private System.Windows.Forms.TextBox txtUsername; // Текстове поле для введення логіну
    private System.Windows.Forms.TextBox txtPassword; // Текстове поле для введення паролю
    private System.Windows.Forms.Button btnRegister; // Кнопка для реєстрації
    private System.Windows.Forms.Button btnCancel; // Кнопка для скасування реєстрації

    private System.Windows.Forms.Label lblFirstName; // Лейбл для імені
    private System.Windows.Forms.Label lblLastName; // Лейбл для прізвища
    private System.Windows.Forms.Label lblCarMake; // Лейбл для марки автомобіля
    private System.Windows.Forms.Label lblCarModel; // Лейбл для моделі автомобіля
    private System.Windows.Forms.Label lblPhone; // Лейбл для телефону
    private System.Windows.Forms.Label lblUsername; // Лейбл для логіну
    private System.Windows.Forms.Label lblPassword; // Лейбл для паролю

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        txtFirstName = new TextBox();
        txtLastName = new TextBox();
        txtCarMake = new TextBox();
        txtCarModel = new TextBox();
        txtPhone = new TextBox();
        txtUsername = new TextBox();
        txtPassword = new TextBox();
        btnRegister = new Button();
        btnCancel = new Button();
        lblFirstName = new Label();
        lblLastName = new Label();
        lblCarMake = new Label();
        lblCarModel = new Label();
        lblPhone = new Label();
        lblUsername = new Label();
        lblPassword = new Label();
        SuspendLayout();
        // 
        // txtFirstName
        // 
        txtFirstName.Location = new Point(100, 40);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(150, 31);
        txtFirstName.TabIndex = 0;
        // 
        // txtLastName
        // 
        txtLastName.Location = new Point(100, 114);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(150, 31);
        txtLastName.TabIndex = 2;
        // 
        // txtCarMake
        // 
        txtCarMake.Location = new Point(100, 189);
        txtCarMake.Name = "txtCarMake";
        txtCarMake.Size = new Size(150, 31);
        txtCarMake.TabIndex = 4;
        // 
        // txtCarModel
        // 
        txtCarModel.Location = new Point(100, 246);
        txtCarModel.Name = "txtCarModel";
        txtCarModel.Size = new Size(150, 31);
        txtCarModel.TabIndex = 6;
        // 
        // txtPhone
        // 
        txtPhone.Location = new Point(100, 306);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(150, 31);
        txtPhone.TabIndex = 8;
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(100, 367);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(150, 31);
        txtUsername.TabIndex = 10;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(100, 432);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(150, 31);
        txtPassword.TabIndex = 12;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // btnRegister
        // 
        btnRegister.Location = new Point(28, 480);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(163, 41);
        btnRegister.TabIndex = 13;
        btnRegister.Text = "Зареєструватися";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += btnRegister_Click;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(211, 480);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(112, 41);
        btnCancel.TabIndex = 14;
        btnCancel.Text = "Скасувати";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // lblFirstName
        // 
        lblFirstName.Location = new Point(100, 9);
        lblFirstName.Name = "lblFirstName";
        lblFirstName.Size = new Size(150, 20);
        lblFirstName.TabIndex = 1;
        lblFirstName.Text = "Ім'я:";
        // 
        // lblLastName
        // 
        lblLastName.Location = new Point(100, 85);
        lblLastName.Name = "lblLastName";
        lblLastName.Size = new Size(150, 26);
        lblLastName.TabIndex = 3;
        lblLastName.Text = "Прізвище:";
        // 
        // lblCarMake
        // 
        lblCarMake.Location = new Point(100, 148);
        lblCarMake.Name = "lblCarMake";
        lblCarMake.Size = new Size(150, 27);
        lblCarMake.TabIndex = 5;
        lblCarMake.Text = "Марка авто:";
        // 
        // lblCarModel
        // 
        lblCarModel.Location = new Point(100, 223);
        lblCarModel.Name = "lblCarModel";
        lblCarModel.Size = new Size(150, 26);
        lblCarModel.TabIndex = 7;
        lblCarModel.Text = "Модель авто:";
        // 
        // lblPhone
        // 
        lblPhone.Location = new Point(100, 273);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new Size(150, 30);
        lblPhone.TabIndex = 9;
        lblPhone.Text = "Телефон:";
        // 
        // lblUsername
        // 
        lblUsername.Location = new Point(100, 340);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(150, 20);
        lblUsername.TabIndex = 11;
        lblUsername.Text = "Логін:";
        // 
        // lblPassword
        // 
        lblPassword.Location = new Point(100, 401);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(150, 28);
        lblPassword.TabIndex = 13;
        lblPassword.Text = "Пароль:";
        // 
        // RegistrationForm
        // 
        ClientSize = new Size(432, 572);
        Controls.Add(txtFirstName);
        Controls.Add(lblFirstName);
        Controls.Add(txtLastName);
        Controls.Add(lblLastName);
        Controls.Add(txtCarMake);
        Controls.Add(lblCarMake);
        Controls.Add(txtCarModel);
        Controls.Add(lblCarModel);
        Controls.Add(txtPhone);
        Controls.Add(lblPhone);
        Controls.Add(txtUsername);
        Controls.Add(lblUsername);
        Controls.Add(txtPassword);
        Controls.Add(lblPassword);
        Controls.Add(btnRegister);
        Controls.Add(btnCancel);
        Name = "RegistrationForm";
        Text = "Реєстрація";
        ResumeLayout(false);
        PerformLayout();
    }
}
