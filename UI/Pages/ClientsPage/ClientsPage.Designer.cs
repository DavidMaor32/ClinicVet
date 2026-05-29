namespace ClinicVet.UI.Pages.ClientsPage;

partial class ClientsPage {
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsPage));
        inputId = new TextBox();
        inputFullName = new TextBox();
        inputPhone = new TextBox();
        inputEmail = new TextBox();
        inputSearch = new TextBox();
        btnAddClient = new Button();
        btnDeleteClient = new Button();
        btnSearch = new Button();
        btnHome = new Button();
        clientsDataGrid = new DataGridView();
        animalsDataGrid = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)clientsDataGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)animalsDataGrid).BeginInit();
        SuspendLayout();
        // 
        // inputId
        // 
        inputId.Location = new Point(81, 120);
        inputId.Margin = new Padding(2);
        inputId.Name = "inputId";
        inputId.PlaceholderText = "Id";
        inputId.Size = new Size(204, 27);
        inputId.TabIndex = 0;
        // 
        // inputFullName
        // 
        inputFullName.Location = new Point(211, 185);
        inputFullName.Margin = new Padding(2);
        inputFullName.Name = "inputFullName";
        inputFullName.PlaceholderText = "Full name";
        inputFullName.Size = new Size(184, 27);
        inputFullName.TabIndex = 1;
        // 
        // inputPhone
        // 
        inputPhone.Location = new Point(649, 120);
        inputPhone.Margin = new Padding(2);
        inputPhone.Name = "inputPhone";
        inputPhone.PlaceholderText = "Phone";
        inputPhone.Size = new Size(172, 27);
        inputPhone.TabIndex = 2;
        // 
        // inputEmail
        // 
        inputEmail.Location = new Point(649, 178);
        inputEmail.Margin = new Padding(2);
        inputEmail.Name = "inputEmail";
        inputEmail.PlaceholderText = "Email";
        inputEmail.Size = new Size(182, 27);
        inputEmail.TabIndex = 3;
        // 
        // inputSearch
        // 
        inputSearch.Location = new Point(334, 29);
        inputSearch.Margin = new Padding(2);
        inputSearch.Name = "inputSearch";
        inputSearch.PlaceholderText = "Search";
        inputSearch.Size = new Size(388, 27);
        inputSearch.TabIndex = 4;
        inputSearch.TextChanged += inputSearch_TextChanged;
        // 
        // btnAddClient
        // 
        btnAddClient.Location = new Point(953, 106);
        btnAddClient.Margin = new Padding(2);
        btnAddClient.Name = "btnAddClient";
        btnAddClient.Size = new Size(225, 52);
        btnAddClient.TabIndex = 5;
        btnAddClient.Text = "Add Client";
        btnAddClient.UseVisualStyleBackColor = true;
        btnAddClient.Click += btnAddClient_Click;
        // 
        // btnDeleteClient
        // 
        btnDeleteClient.Location = new Point(953, 162);
        btnDeleteClient.Margin = new Padding(2);
        btnDeleteClient.Name = "btnDeleteClient";
        btnDeleteClient.Size = new Size(221, 58);
        btnDeleteClient.TabIndex = 6;
        btnDeleteClient.Text = "Delete Client";
        btnDeleteClient.UseVisualStyleBackColor = true;
        btnDeleteClient.Click += btnDeleteClient_Click;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(744, 11);
        btnSearch.Margin = new Padding(2);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(164, 63);
        btnSearch.TabIndex = 7;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // btnHome
        // 
        btnHome.Location = new Point(1232, 11);
        btnHome.Margin = new Padding(2);
        btnHome.Name = "btnHome";
        btnHome.Size = new Size(128, 81);
        btnHome.TabIndex = 8;
        btnHome.Text = "Home";
        btnHome.UseVisualStyleBackColor = true;
        btnHome.Click += btnHome_Click;
        // 
        // clientsDataGrid
        // 
        clientsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        clientsDataGrid.ColumnHeadersHeight = 34;
        clientsDataGrid.Location = new Point(0, 237);
        clientsDataGrid.Margin = new Padding(2);
        clientsDataGrid.MultiSelect = false;
        clientsDataGrid.Name = "clientsDataGrid";
        clientsDataGrid.ReadOnly = true;
        clientsDataGrid.RowHeadersWidth = 62;
        clientsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        clientsDataGrid.Size = new Size(656, 451);
        clientsDataGrid.TabIndex = 5;
        // 
        // animalsDataGrid
        // 
        animalsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        animalsDataGrid.ColumnHeadersHeight = 34;
        animalsDataGrid.Location = new Point(660, 237);
        animalsDataGrid.Margin = new Padding(2);
        animalsDataGrid.MultiSelect = false;
        animalsDataGrid.Name = "animalsDataGrid";
        animalsDataGrid.ReadOnly = true;
        animalsDataGrid.RowHeadersWidth = 62;
        animalsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        animalsDataGrid.Size = new Size(700, 447);
        animalsDataGrid.TabIndex = 4;
        animalsDataGrid.CellContentClick += animalsDataGrid_CellContentClick;
        // 
        // ClientsPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1371, 684);
        Controls.Add(inputSearch);
        Controls.Add(inputEmail);
        Controls.Add(btnHome);
        Controls.Add(btnSearch);
        Controls.Add(btnAddClient);
        Controls.Add(inputPhone);
        Controls.Add(btnDeleteClient);
        Controls.Add(inputFullName);
        Controls.Add(inputId);
        Controls.Add(clientsDataGrid);
        Controls.Add(animalsDataGrid);
        Margin = new Padding(2);
        Name = "ClientsPage";
        Text = "ClientsPage";
        ((System.ComponentModel.ISupportInitialize)clientsDataGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)animalsDataGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox inputId;
    private TextBox inputFullName;
    private TextBox inputPhone;
    private TextBox inputEmail;
    private TextBox inputSearch;
    private Button btnAddClient;
    private Button btnDeleteClient;
    private Button btnSearch;
    private Button btnHome;
    private DataGridView clientsDataGrid;
    private DataGridView animalsDataGrid;
}