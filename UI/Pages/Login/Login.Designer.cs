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
    private void InitializeComponent() {
        inputName = new TextBox();
        inputPassword = new TextBox();
        btnLogin = new Button();
        togglePasswordVisible = new CheckBox();
        flowLayoutPanel1 = new FlowLayoutPanel();
        flowLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // inputName
        // 
        inputName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        inputName.Location = new Point(3, 3);
        inputName.Name = "inputName";
        inputName.PlaceholderText = "Username";
        inputName.Size = new Size(162, 31);
        inputName.TabIndex = 0;
        // 
        // inputPassword
        // 
        inputPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        inputPassword.Location = new Point(3, 40);
        inputPassword.Name = "inputPassword";
        inputPassword.PlaceholderText = "Password";
        inputPassword.Size = new Size(162, 31);
        inputPassword.TabIndex = 1;
        inputPassword.UseSystemPasswordChar = true;
        // 
        // btnLogin
        // 
        btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        btnLogin.Location = new Point(3, 112);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(162, 34);
        btnLogin.TabIndex = 2;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += button1_Click;
        // 
        // togglePasswordVisible
        // 
        togglePasswordVisible.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        togglePasswordVisible.AutoSize = true;
        togglePasswordVisible.Location = new Point(3, 77);
        togglePasswordVisible.Name = "togglePasswordVisible";
        togglePasswordVisible.Size = new Size(162, 29);
        togglePasswordVisible.TabIndex = 3;
        togglePasswordVisible.Text = "Show Password";
        togglePasswordVisible.UseVisualStyleBackColor = true;
        togglePasswordVisible.CheckedChanged += TogglePasswordVisible_CheckedChanged;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        flowLayoutPanel1.Controls.Add(inputName);
        flowLayoutPanel1.Controls.Add(inputPassword);
        flowLayoutPanel1.Controls.Add(togglePasswordVisible);
        flowLayoutPanel1.Controls.Add(btnLogin);
        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel1.Location = new Point(297, 110);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(171, 160);
        flowLayoutPanel1.TabIndex = 4;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(flowLayoutPanel1);
        Name = "Login";
        Text = "ClinicVet";
        flowLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TextBox inputName;
    private TextBox inputPassword;
    private Button btnLogin;
    private CheckBox togglePasswordVisible;
    private FlowLayoutPanel flowLayoutPanel1;
}
