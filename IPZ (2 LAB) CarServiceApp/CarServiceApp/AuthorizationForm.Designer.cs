partial class AuthorizationForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.Label lblPassword;

    // Dispose method
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
        txtUsername = new TextBox();
        txtPassword = new TextBox();
        btnLogin = new Button();
        btnRegister = new Button();
        lblUsername = new Label();
        lblPassword = new Label();
        SuspendLayout();
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(100, 50);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(150, 31);
        txtUsername.TabIndex = 0;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(100, 80);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(150, 31);
        txtPassword.TabIndex = 1;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(76, 130);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(101, 42);
        btnLogin.TabIndex = 2;
        btnLogin.Text = "Увійти";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // btnRegister
        // 
        btnRegister.Location = new Point(183, 130);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(158, 42);
        btnRegister.TabIndex = 3;
        btnRegister.Text = "Зареєструватися";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += btnRegister_Click;
        // 
        // lblUsername
        // 
        lblUsername.Location = new Point(20, 50);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(80, 31);
        lblUsername.TabIndex = 0;
        lblUsername.Text = "Логін:";
        // 
        // lblPassword
        // 
        lblPassword.Location = new Point(20, 80);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(80, 31);
        lblPassword.TabIndex = 1;
        lblPassword.Text = "Пароль:";
        // 
        // AuthorizationForm
        // 
        ClientSize = new Size(400, 200);
        Controls.Add(lblUsername);
        Controls.Add(lblPassword);
        Controls.Add(txtUsername);
        Controls.Add(txtPassword);
        Controls.Add(btnLogin);
        Controls.Add(btnRegister);
        Name = "AuthorizationForm";
        Text = "Авторизація";
        ResumeLayout(false);
        PerformLayout();
    }
}
