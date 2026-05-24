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
    private void InitializeComponent() {
        clientsDataGrid = new DataGridView();
        animalsDataGrid = new DataGridView();
        splitContainer1 = new SplitContainer();
        flowLayoutPanel1 = new FlowLayoutPanel();
        inputId = new TextBox();
        inputFullName = new TextBox();
        inputPhone = new TextBox();
        inputEmail = new TextBox();
        inputSearch = new TextBox();
        btnAddClient = new Button();
        btnDeleteClient = new Button();
        btnSearch = new Button();
        btnHome = new Button();
        ((System.ComponentModel.ISupportInitialize)clientsDataGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)animalsDataGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // clientsDataGrid
        // 
        clientsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        clientsDataGrid.ColumnHeadersHeight = 34;
        clientsDataGrid.Dock = DockStyle.Fill;
        clientsDataGrid.Location = new Point(0, 0);
        clientsDataGrid.MultiSelect = false;
        clientsDataGrid.Name = "clientsDataGrid";
        clientsDataGrid.ReadOnly = true;
        clientsDataGrid.RowHeadersWidth = 62;
        clientsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        clientsDataGrid.Size = new Size(394, 299);
        clientsDataGrid.TabIndex = 0;
        clientsDataGrid.SelectionChanged += clientsDataGrid_SelectionChanged;
        // 
        // animalsDataGrid
        // 
        animalsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        animalsDataGrid.ColumnHeadersHeight = 34;
        animalsDataGrid.Dock = DockStyle.Fill;
        animalsDataGrid.Location = new Point(0, 0);
        animalsDataGrid.MultiSelect = false;
        animalsDataGrid.Name = "animalsDataGrid";
        animalsDataGrid.ReadOnly = true;
        animalsDataGrid.RowHeadersWidth = 62;
        animalsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        animalsDataGrid.Size = new Size(402, 299);
        animalsDataGrid.TabIndex = 1;
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 80);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(clientsDataGrid);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(animalsDataGrid);
        splitContainer1.Size = new Size(800, 299);
        splitContainer1.SplitterDistance = 394;
        splitContainer1.TabIndex = 0;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoSize = true;
        flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        flowLayoutPanel1.Controls.Add(inputId);
        flowLayoutPanel1.Controls.Add(inputFullName);
        flowLayoutPanel1.Controls.Add(inputPhone);
        flowLayoutPanel1.Controls.Add(inputEmail);
        flowLayoutPanel1.Controls.Add(inputSearch);
        flowLayoutPanel1.Controls.Add(btnAddClient);
        flowLayoutPanel1.Controls.Add(btnDeleteClient);
        flowLayoutPanel1.Controls.Add(btnSearch);
        flowLayoutPanel1.Controls.Add(btnHome);
        flowLayoutPanel1.Dock = DockStyle.Top;
        flowLayoutPanel1.Location = new Point(0, 0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Padding = new Padding(8);
        flowLayoutPanel1.Size = new Size(800, 80);
        flowLayoutPanel1.TabIndex = 1;
        // 
        // inputId
        // 
        inputId.Location = new Point(11, 11);
        inputId.Name = "inputId";
        inputId.PlaceholderText = "Id";
        inputId.Size = new Size(120, 31);
        inputId.TabIndex = 0;
        // 
        // inputFullName
        // 
        inputFullName.Location = new Point(137, 11);
        inputFullName.Name = "inputFullName";
        inputFullName.PlaceholderText = "Full name";
        inputFullName.Size = new Size(160, 31);
        inputFullName.TabIndex = 1;
        // 
        // inputPhone
        // 
        inputPhone.Location = new Point(303, 11);
        inputPhone.Name = "inputPhone";
        inputPhone.PlaceholderText = "Phone";
        inputPhone.Size = new Size(140, 31);
        inputPhone.TabIndex = 2;
        // 
        // inputEmail
        // 
        inputEmail.Location = new Point(449, 11);
        inputEmail.Name = "inputEmail";
        inputEmail.PlaceholderText = "Email";
        inputEmail.Size = new Size(190, 31);
        inputEmail.TabIndex = 3;
        // 
        // inputSearch
        // 
        inputSearch.Location = new Point(645, 11);
        inputSearch.Name = "inputSearch";
        inputSearch.PlaceholderText = "Search";
        inputSearch.Size = new Size(140, 31);
        inputSearch.TabIndex = 4;
        // 
        // btnAddClient
        // 
        btnAddClient.Location = new Point(11, 48);
        btnAddClient.Name = "btnAddClient";
        btnAddClient.Size = new Size(120, 34);
        btnAddClient.TabIndex = 5;
        btnAddClient.Text = "Add Client";
        btnAddClient.UseVisualStyleBackColor = true;
        btnAddClient.Click += btnAddClient_Click;
        // 
        // btnDeleteClient
        // 
        btnDeleteClient.Location = new Point(137, 48);
        btnDeleteClient.Name = "btnDeleteClient";
        btnDeleteClient.Size = new Size(160, 34);
        btnDeleteClient.TabIndex = 6;
        btnDeleteClient.Text = "Delete Client";
        btnDeleteClient.UseVisualStyleBackColor = true;
        btnDeleteClient.Click += btnDeleteClient_Click;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(303, 48);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(120, 34);
        btnSearch.TabIndex = 7;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // btnHome
        // 
        btnHome.Location = new Point(429, 48);
        btnHome.Name = "btnHome";
        btnHome.Size = new Size(120, 34);
        btnHome.TabIndex = 8;
        btnHome.Text = "Home";
        btnHome.UseVisualStyleBackColor = true;
        btnHome.Click += btnHome_Click;
        // 
        // ClientsPage
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 379);
        Controls.Add(splitContainer1);
        Controls.Add(flowLayoutPanel1);
        Name = "ClientsPage";
        Text = "ClientsPage";
        ((System.ComponentModel.ISupportInitialize)clientsDataGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)animalsDataGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        splitContainer1.ResumeLayout(false);
        flowLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView clientsDataGrid;
    private DataGridView animalsDataGrid;
    private SplitContainer splitContainer1;
    private FlowLayoutPanel flowLayoutPanel1;
    private TextBox inputId;
    private TextBox inputFullName;
    private TextBox inputPhone;
    private TextBox inputEmail;
    private TextBox inputSearch;
    private Button btnAddClient;
    private Button btnDeleteClient;
    private Button btnSearch;
    private Button btnHome;
}