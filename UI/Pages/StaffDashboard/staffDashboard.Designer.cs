namespace Clinic.Gui.Pages.StaffDashboard;

partial class staffDashboard
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        label1 = new Label();
        txtSearch = new TextBox();
        btnSearch = new Button();
        btnAddPet = new Button();
        comboBoxSearch = new ComboBox();
        label2 = new Label();
        label3 = new Label();
        button1 = new Button();
        panel1 = new Panel();
        dgvPets = new DataGridView();
        nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        chipNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        animalBindingSource = new BindingSource(components);
        label4 = new Label();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
        ((System.ComponentModel.ISupportInitialize)animalBindingSource).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(27, 33);
        label1.Name = "label1";
        label1.Size = new Size(0, 20);
        label1.TabIndex = 0;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(396, 68);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(168, 27);
        txtSearch.TabIndex = 1;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = SystemColors.ActiveCaption;
        btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSearch.Location = new Point(585, 68);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(94, 29);
        btnSearch.TabIndex = 2;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += btnSearch_Click;
        // 
        // btnAddPet
        // 
        btnAddPet.BackColor = SystemColors.ActiveCaption;
        btnAddPet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnAddPet.Location = new Point(27, 216);
        btnAddPet.Name = "btnAddPet";
        btnAddPet.Size = new Size(143, 72);
        btnAddPet.TabIndex = 4;
        btnAddPet.Text = "Add pet";
        btnAddPet.UseVisualStyleBackColor = false;
        btnAddPet.Click += btnAddPet_Click;
        // 
        // comboBoxSearch
        // 
        comboBoxSearch.FormattingEnabled = true;
        comboBoxSearch.Location = new Point(230, 69);
        comboBoxSearch.Name = "comboBoxSearch";
        comboBoxSearch.Size = new Size(151, 28);
        comboBoxSearch.TabIndex = 5;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label2.Location = new Point(68, 71);
        label2.Name = "label2";
        label2.Size = new Size(156, 20);
        label2.TabIndex = 6;
        label2.Text = "enter pet chip/name:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = SystemColors.ControlLightLight;
        label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label3.Location = new Point(365, 10);
        label3.Name = "label3";
        label3.Size = new Size(86, 20);
        label3.TabIndex = 7;
        label3.Text = "Search pet:";
        // 
        // button1
        // 
        button1.BackColor = SystemColors.ActiveCaption;
        button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        button1.Location = new Point(27, 331);
        button1.Name = "button1";
        button1.Size = new Size(143, 72);
        button1.TabIndex = 8;
        button1.Text = "Pet catalog";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ActiveCaption;
        panel1.Controls.Add(txtSearch);
        panel1.Controls.Add(btnSearch);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(comboBoxSearch);
        panel1.Controls.Add(label2);
        panel1.Location = new Point(80, 21);
        panel1.Name = "panel1";
        panel1.Size = new Size(772, 125);
        panel1.TabIndex = 9;
        // 
        // dgvPets
        // 
        dgvPets.AllowUserToAddRows = false;
        dgvPets.AllowUserToDeleteRows = false;
        dgvPets.AutoGenerateColumns = false;
        dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPets.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn, chipNumberDataGridViewTextBoxColumn });
        dgvPets.DataSource = animalBindingSource;
        dgvPets.Location = new Point(225, 216);
        dgvPets.Name = "dgvPets";
        dgvPets.ReadOnly = true;
        dgvPets.RowHeadersWidth = 51;
        dgvPets.Size = new Size(602, 352);
        dgvPets.TabIndex = 10;
        dgvPets.CellContentClick += DgvPets_CellContentClick;
        // 
        // nameDataGridViewTextBoxColumn
        // 
        nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
        nameDataGridViewTextBoxColumn.HeaderText = "Name";
        nameDataGridViewTextBoxColumn.MinimumWidth = 6;
        nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
        nameDataGridViewTextBoxColumn.ReadOnly = true;
        nameDataGridViewTextBoxColumn.Width = 125;
        // 
        // typeDataGridViewTextBoxColumn
        // 
        typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
        typeDataGridViewTextBoxColumn.HeaderText = "Type";
        typeDataGridViewTextBoxColumn.MinimumWidth = 6;
        typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
        typeDataGridViewTextBoxColumn.ReadOnly = true;
        typeDataGridViewTextBoxColumn.Width = 125;
        // 
        // weightDataGridViewTextBoxColumn
        // 
        weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
        weightDataGridViewTextBoxColumn.HeaderText = "Weight";
        weightDataGridViewTextBoxColumn.MinimumWidth = 6;
        weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
        weightDataGridViewTextBoxColumn.ReadOnly = true;
        weightDataGridViewTextBoxColumn.Width = 125;
        // 
        // chipNumberDataGridViewTextBoxColumn
        // 
        chipNumberDataGridViewTextBoxColumn.DataPropertyName = "ChipNumber";
        chipNumberDataGridViewTextBoxColumn.HeaderText = "ChipNumber";
        chipNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
        chipNumberDataGridViewTextBoxColumn.Name = "chipNumberDataGridViewTextBoxColumn";
        chipNumberDataGridViewTextBoxColumn.ReadOnly = true;
        chipNumberDataGridViewTextBoxColumn.Width = 125;
        // 
        // animalBindingSource
        // 
        animalBindingSource.DataSource = typeof(Animal);
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label4.Location = new Point(225, 181);
        label4.Name = "label4";
        label4.Size = new Size(110, 20);
        label4.TabIndex = 11;
        label4.Text = "Search results:";
        label4.Click += Label4_Click;
        // 
        // staffDashboard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(960, 653);
        Controls.Add(label4);
        Controls.Add(dgvPets);
        Controls.Add(panel1);
        Controls.Add(button1);
        Controls.Add(btnAddPet);
        Controls.Add(label1);
        Name = "staffDashboard";
        Text = "staffDashboard";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
        ((System.ComponentModel.ISupportInitialize)animalBindingSource).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtSearch;
    private Button btnSearch;
    private Button btnAddPet;
    private ComboBox comboBoxSearch;
    private Label label2;
    private Label label3;
    private Button button1;
    private Panel panel1;
    private DataGridView dgvPets;
    private BindingSource animalBindingSource;
    private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn chipNumberDataGridViewTextBoxColumn;
    private Label label4;
}