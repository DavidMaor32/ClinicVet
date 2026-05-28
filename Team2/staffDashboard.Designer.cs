namespace Team2
{
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffDashboard));
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAddPet = new Button();
            comboBoxSearch = new ComboBox();
            dgvPets = new DataGridView();
            animalBindingSource = new BindingSource(components);
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
            txtSearch.Location = new Point(847, 66);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(206, 27);
            txtSearch.TabIndex = 1;
            
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.Location = new Point(1133, 47);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 62);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddPet
            // 
            btnAddPet.BackColor = SystemColors.ActiveCaption;
            btnAddPet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddPet.Location = new Point(12, 291);
            btnAddPet.Name = "btnAddPet";
            btnAddPet.Size = new Size(253, 103);
            btnAddPet.TabIndex = 4;
            btnAddPet.Text = "Add pet";
            btnAddPet.UseVisualStyleBackColor = false;
            btnAddPet.Click += btnAddPet_Click;
            // 
            // comboBoxSearch
            // 
            comboBoxSearch.FormattingEnabled = true;
            comboBoxSearch.Location = new Point(592, 65);
            comboBoxSearch.Name = "comboBoxSearch";
            comboBoxSearch.Size = new Size(201, 28);
            comboBoxSearch.TabIndex = 5;
            // 
            // dgvPets
            // 
            dgvPets.AllowUserToAddRows = false;
            dgvPets.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvPets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPets.AutoGenerateColumns = false;
            dgvPets.BackgroundColor = SystemColors.Control;
            dgvPets.BorderStyle = BorderStyle.None;
            dgvPets.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPets.DataSource = animalBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPets.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPets.GridColor = SystemColors.Control;
            dgvPets.Location = new Point(302, 176);
            dgvPets.Name = "dgvPets";
            dgvPets.ReadOnly = true;
            dgvPets.RowHeadersVisible = false;
            dgvPets.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dgvPets.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvPets.ScrollBars = ScrollBars.None;
            dgvPets.Size = new Size(881, 453);
            dgvPets.TabIndex = 10;
            // 
            // staffDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1362, 659);
            Controls.Add(txtSearch);
            Controls.Add(dgvPets);
            Controls.Add(btnSearch);
            Controls.Add(comboBoxSearch);
            Controls.Add(btnAddPet);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "staffDashboard";
            Text = "staffDashboard";
          
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
        private DataGridView dgvPets;
        private BindingSource animalBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn chipNumberDataGridViewTextBoxColumn;
    }
}