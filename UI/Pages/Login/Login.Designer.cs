namespace ClinicVet.UI.Pages.Login;

partial class Login
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        inputName = new TextBox();
        inputPassword = new TextBox();
        btnLogin = new Button();
        togglePasswordVisible = new CheckBox();
        label1 = new Label();
        SuspendLayout();
        // 
        // inputName
        // 
        inputName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        inputName.Location = new Point(484, 210);
        inputName.Margin = new Padding(2);
        inputName.Name = "inputName";
        inputName.PlaceholderText = "Username";
        inputName.Size = new Size(243, 27);
        inputName.TabIndex = 0;
        // 
        // inputPassword
        // 
        inputPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        inputPassword.Location = new Point(484, 312);
        inputPassword.Margin = new Padding(2);
        inputPassword.Name = "inputPassword";
        inputPassword.PlaceholderText = "Password";
        inputPassword.Size = new Size(243, 27);
        inputPassword.TabIndex = 1;
        inputPassword.UseSystemPasswordChar = true;
        // 
        // btnLogin
        // 
        btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btnLogin.Location = new Point(456, 444);
        btnLogin.Margin = new Padding(2);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(204, 73);
        btnLogin.TabIndex = 2;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += button1_Click;
        // 
        // togglePasswordVisible
        // 
        togglePasswordVisible.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        togglePasswordVisible.AutoSize = true;
        togglePasswordVisible.BackColor = Color.Transparent;
        togglePasswordVisible.Location = new Point(456, 375);
        togglePasswordVisible.Margin = new Padding(2);
        togglePasswordVisible.Name = "togglePasswordVisible";
        togglePasswordVisible.Size = new Size(18, 17);
        togglePasswordVisible.TabIndex = 3;
        togglePasswordVisible.UseVisualStyleBackColor = false;
        togglePasswordVisible.CheckedChanged += TogglePasswordVisible_CheckedChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(51, 223);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(193, 84);
        label1.TabIndex = 5;
        label1.Text = "default user\r\nusername: admin12\r\npassword:admin123!\r\n";
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources._02_login_background;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1157, 635);
        Controls.Add(inputName);
        Controls.Add(inputPassword);
        Controls.Add(label1);
        Controls.Add(togglePasswordVisible);
        Controls.Add(btnLogin);
        Margin = new Padding(2);
        Name = "Login";
        Text = "ClinicVet";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox inputName;
    private TextBox inputPassword;
    private Button btnLogin;
    private CheckBox togglePasswordVisible;
    private Label label1;
}
