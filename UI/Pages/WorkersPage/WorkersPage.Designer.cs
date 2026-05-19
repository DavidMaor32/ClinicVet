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
    private void InitializeComponent() {
        workersDataGrid = new DataGridView();
        flowLayoutPanel1 = new FlowLayoutPanel();
        btnAddWorker = new Button();
        flowLayoutPanel2 = new FlowLayoutPanel();
        inputUsername = new TextBox();
        inputPassword = new TextBox();
        inputWorkId = new TextBox();
        inputId = new TextBox();
        inputEmail = new TextBox();
        inputRole = new ComboBox();
        btnHome = new Button();
        ((System.ComponentModel.ISupportInitialize)workersDataGrid).BeginInit();
        flowLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // workersDataGrid
        // 
        workersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        workersDataGrid.ColumnHeadersHeight = 34;
        workersDataGrid.Dock = DockStyle.Bottom;
        workersDataGrid.Location = new Point(0, 151);
        workersDataGrid.Name = "workersDataGrid";
        workersDataGrid.ReadOnly = true;
        workersDataGrid.RowHeadersWidth = 62;
        workersDataGrid.ScrollBars = ScrollBars.Vertical;
        workersDataGrid.Size = new Size(800, 299);
        workersDataGrid.TabIndex = 0;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoSize = true;
        flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flowLayoutPanel1.Location = new Point(101, 111);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(0, 0);
        flowLayoutPanel1.TabIndex = 1;
        // 
        // btnAddWorker
        // 
        btnAddWorker.Location = new Point(221, 79);
        btnAddWorker.Name = "btnAddWorker";
        btnAddWorker.Size = new Size(212, 34);
        btnAddWorker.TabIndex = 2;
        btnAddWorker.Text = "Add Worker";
        btnAddWorker.UseVisualStyleBackColor = true;
        btnAddWorker.Click += btnAddWorker_Click;
        // 
        // flowLayoutPanel2
        // 
        flowLayoutPanel2.Controls.Add(inputUsername);
        flowLayoutPanel2.Controls.Add(inputPassword);
        flowLayoutPanel2.Controls.Add(inputWorkId);
        flowLayoutPanel2.Controls.Add(inputId);
        flowLayoutPanel2.Controls.Add(inputEmail);
        flowLayoutPanel2.Controls.Add(inputRole);
        flowLayoutPanel2.Controls.Add(btnAddWorker);
        flowLayoutPanel2.Dock = DockStyle.Left;
        flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel2.Location = new Point(0, 0);
        flowLayoutPanel2.Name = "flowLayoutPanel2";
        flowLayoutPanel2.Size = new Size(441, 151);
        flowLayoutPanel2.TabIndex = 3;
        // 
        // inputUsername
        // 
        inputUsername.Location = new Point(3, 3);
        inputUsername.Name = "inputUsername";
        inputUsername.PlaceholderText = "Username";
        inputUsername.Size = new Size(212, 31);
        inputUsername.TabIndex = 0;
        // 
        // inputPassword
        // 
        inputPassword.Location = new Point(3, 40);
        inputPassword.Name = "inputPassword";
        inputPassword.PlaceholderText = "Password";
        inputPassword.Size = new Size(212, 31);
        inputPassword.TabIndex = 1;
        // 
        // inputWorkId
        // 
        inputWorkId.Location = new Point(3, 77);
        inputWorkId.Name = "inputWorkId";
        inputWorkId.PlaceholderText = "WorkerId";
        inputWorkId.Size = new Size(212, 31);
        inputWorkId.TabIndex = 2;
        // 
        // inputId
        // 
        inputId.Location = new Point(3, 114);
        inputId.Name = "inputId";
        inputId.PlaceholderText = "Id";
        inputId.Size = new Size(212, 31);
        inputId.TabIndex = 4;
        // 
        // inputEmail
        // 
        inputEmail.Location = new Point(221, 3);
        inputEmail.Name = "inputEmail";
        inputEmail.PlaceholderText = "Email";
        inputEmail.Size = new Size(212, 31);
        inputEmail.TabIndex = 3;
        // 
        // inputRole
        // 
        inputRole.FormattingEnabled = true;
        inputRole.Location = new Point(221, 40);
        inputRole.Name = "inputRole";
        inputRole.Size = new Size(212, 33);
        inputRole.TabIndex = 5;
        // 
        // btnHome
        // 
        btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnHome.Location = new Point(676, 12);
        btnHome.Name = "btnHome";
        btnHome.Size = new Size(112, 34);
        btnHome.TabIndex = 4;
        btnHome.Text = "Home";
        btnHome.UseVisualStyleBackColor = true;
        btnHome.Click += btnHome_Click;
        // 
        // WorkersPage
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnHome);
        Controls.Add(flowLayoutPanel2);
        Controls.Add(workersDataGrid);
        Controls.Add(flowLayoutPanel1);
        Name = "WorkersPage";
        Text = "WorkersPage";
        ((System.ComponentModel.ISupportInitialize)workersDataGrid).EndInit();
        flowLayoutPanel2.ResumeLayout(false);
        flowLayoutPanel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView workersDataGrid;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button btnAddWorker;
    private FlowLayoutPanel flowLayoutPanel2;
    private TextBox inputUsername;
    private TextBox inputPassword;
    private TextBox inputWorkId;
    private TextBox inputId;
    private TextBox inputEmail;
    private ComboBox inputRole;
    private Button btnHome;
}