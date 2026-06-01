namespace ClinicVet.UI.Pages.WorkersPage;

partial class WorkersPage {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersPage));
        workersDataGrid = new DataGridView();
        flowLayoutPanel1 = new FlowLayoutPanel();
        btnAddWorker = new Button();
        inputUsername = new TextBox();
        inputPassword = new TextBox();
        inputWorkId = new TextBox();
        inputId = new TextBox();
        inputEmail = new TextBox();
        inputRole = new ComboBox();
        btnHome = new Button();
        ((System.ComponentModel.ISupportInitialize)workersDataGrid).BeginInit();
        SuspendLayout();
        // 
        // workersDataGrid
        // 
        workersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        workersDataGrid.ColumnHeadersHeight = 34;
        workersDataGrid.Location = new Point(11, 270);
        workersDataGrid.Margin = new Padding(2);
        workersDataGrid.Name = "workersDataGrid";
        workersDataGrid.ReadOnly = true;
        workersDataGrid.RowHeadersWidth = 62;
        workersDataGrid.ScrollBars = ScrollBars.Vertical;
        workersDataGrid.Size = new Size(989, 335);
        workersDataGrid.TabIndex = 0;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoSize = true;
        flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flowLayoutPanel1.Location = new Point(175, 215);
        flowLayoutPanel1.Margin = new Padding(2);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(0, 0);
        flowLayoutPanel1.TabIndex = 1;
        // 
        // btnAddWorker
        // 
        btnAddWorker.Cursor = Cursors.Hand;
        btnAddWorker.Location = new Point(669, 161);
        btnAddWorker.Margin = new Padding(2);
        btnAddWorker.Name = "btnAddWorker";
        btnAddWorker.Size = new Size(176, 72);
        btnAddWorker.TabIndex = 2;
        btnAddWorker.Text = "Add Worker";
        btnAddWorker.UseVisualStyleBackColor = true;
        btnAddWorker.Click += btnAddWorker_Click;
        // 
        // inputUsername
        // 
        inputUsername.Location = new Point(184, 27);
        inputUsername.Margin = new Padding(2);
        inputUsername.Name = "inputUsername";
        inputUsername.PlaceholderText = "Username";
        inputUsername.Size = new Size(170, 27);
        inputUsername.TabIndex = 0;
        // 
        // inputPassword
        // 
        inputPassword.Location = new Point(184, 88);
        inputPassword.Margin = new Padding(2);
        inputPassword.Name = "inputPassword";
        inputPassword.PlaceholderText = "Password";
        inputPassword.Size = new Size(170, 27);
        inputPassword.TabIndex = 1;
        // 
        // inputWorkId
        // 
        inputWorkId.Location = new Point(153, 149);
        inputWorkId.Margin = new Padding(2);
        inputWorkId.Name = "inputWorkId";
        inputWorkId.PlaceholderText = "WorkerId";
        inputWorkId.Size = new Size(170, 27);
        inputWorkId.TabIndex = 2;
        // 
        // inputId
        // 
        inputId.Location = new Point(450, 27);
        inputId.Margin = new Padding(2);
        inputId.Name = "inputId";
        inputId.PlaceholderText = "Id";
        inputId.Size = new Size(170, 27);
        inputId.TabIndex = 4;
        // 
        // inputEmail
        // 
        inputEmail.Location = new Point(487, 88);
        inputEmail.Margin = new Padding(2);
        inputEmail.Name = "inputEmail";
        inputEmail.PlaceholderText = "Email";
        inputEmail.Size = new Size(170, 27);
        inputEmail.TabIndex = 3;
        // 
        // inputRole
        // 
        inputRole.FormattingEnabled = true;
        inputRole.Location = new Point(471, 149);
        inputRole.Margin = new Padding(2);
        inputRole.Name = "inputRole";
        inputRole.Size = new Size(170, 28);
        inputRole.TabIndex = 5;
        inputRole.Text = "Role";
        // 
        // btnHome
        // 
        btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnHome.Cursor = Cursors.Hand;
        btnHome.Location = new Point(938, 10);
        btnHome.Margin = new Padding(2);
        btnHome.Name = "btnHome";
        btnHome.Size = new Size(90, 75);
        btnHome.TabIndex = 4;
        btnHome.Text = "Home";
        btnHome.UseVisualStyleBackColor = true;
        btnHome.Click += btnHome_Click;
        // 
        // WorkersPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources._03_workers_management_background1;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1037, 641);
        Controls.Add(inputUsername);
        Controls.Add(inputPassword);
        Controls.Add(btnHome);
        Controls.Add(inputWorkId);
        Controls.Add(inputId);
        Controls.Add(workersDataGrid);
        Controls.Add(inputEmail);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(inputRole);
        Controls.Add(btnAddWorker);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(2);
        MaximizeBox = false;
        Name = "WorkersPage";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "WorkersPage";
        ((System.ComponentModel.ISupportInitialize)workersDataGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView workersDataGrid;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button btnAddWorker;
    private TextBox inputUsername;
    private TextBox inputPassword;
    private TextBox inputWorkId;
    private TextBox inputId;
    private TextBox inputEmail;
    private Button btnHome;
    public ComboBox inputRole;
}