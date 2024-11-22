partial class ProfileForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblCarMake;
    private System.Windows.Forms.Label lblCarModel;
    private System.Windows.Forms.Label lblPhone;
    private System.Windows.Forms.Button btnBackToMainMenu;

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
        lblName = new System.Windows.Forms.Label();
        lblCarMake = new System.Windows.Forms.Label();
        lblCarModel = new System.Windows.Forms.Label();
        lblPhone = new System.Windows.Forms.Label();
        btnBackToMainMenu = new System.Windows.Forms.Button();

        SuspendLayout();

        // lblName
        lblName.AutoSize = true;
        lblName.Location = new System.Drawing.Point(100, 50);
        lblName.Name = "lblName";
        lblName.Size = new System.Drawing.Size(151, 25);
        lblName.Text = "Ім'я користувача";

        // lblCarMake
        lblCarMake.AutoSize = true;
        lblCarMake.Location = new System.Drawing.Point(100, 80);
        lblCarMake.Name = "lblCarMake";
        lblCarMake.Size = new System.Drawing.Size(164, 25);
        lblCarMake.Text = "Марка автомобіля";

        // lblCarModel
        lblCarModel.AutoSize = true;
        lblCarModel.Location = new System.Drawing.Point(100, 110);
        lblCarModel.Name = "lblCarModel";
        lblCarModel.Size = new System.Drawing.Size(174, 25);
        lblCarModel.Text = "Модель автомобіля";

        // lblPhone
        lblPhone.AutoSize = true;
        lblPhone.Location = new System.Drawing.Point(100, 140);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new System.Drawing.Size(150, 25);
        lblPhone.Text = "Номер телефону";

        // btnBackToMainMenu
        btnBackToMainMenu.Location = new System.Drawing.Point(100, 180);
        btnBackToMainMenu.Name = "btnBackToMainMenu";
        btnBackToMainMenu.Size = new System.Drawing.Size(238, 38);
        btnBackToMainMenu.Text = "Повернутися назад";
        btnBackToMainMenu.UseVisualStyleBackColor = true;
        btnBackToMainMenu.Click += new System.EventHandler(btnBackToMainMenu_Click);

        // ProfileForm
        ClientSize = new System.Drawing.Size(400, 250);
        Controls.Add(lblName);
        Controls.Add(lblCarMake);
        Controls.Add(lblCarModel);
        Controls.Add(lblPhone);
        Controls.Add(btnBackToMainMenu);
        Name = "ProfileForm";
        Text = "Профіль користувача";

        ResumeLayout(false);
        PerformLayout();
    }
}
