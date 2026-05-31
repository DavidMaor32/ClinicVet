namespace ClinicVet.UI.Pages.MedicineManagement;
partial class MedicineManagementPage
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineManagementPage));
        medNameAddTextBox = new TextBox();
        addMedButton = new Button();
        clearButton = new Button();
        captionMedStockLabel = new Label();
        deleteButton = new Button();
        updateButton = new Button();
        medNameSelectedTextBox = new TextBox();
        refreshButton = new Button();
        medicineGridView = new DataGridView();
        quantityAddNumeric = new NumericUpDown();
        priceAddNumeric = new NumericUpDown();
        quantitySelectedNumeric = new NumericUpDown();
        priceSelectedNumeric = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)medicineGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)quantityAddNumeric).BeginInit();
        ((System.ComponentModel.ISupportInitialize)priceAddNumeric).BeginInit();
        ((System.ComponentModel.ISupportInitialize)quantitySelectedNumeric).BeginInit();
        ((System.ComponentModel.ISupportInitialize)priceSelectedNumeric).BeginInit();
        SuspendLayout();
        // 
        // medNameAddTextBox
        // 
        medNameAddTextBox.Location = new Point(220, 128);
        medNameAddTextBox.Name = "medNameAddTextBox";
        medNameAddTextBox.Size = new Size(188, 27);
        medNameAddTextBox.TabIndex = 2;
        // 
        // addMedButton
        // 
        addMedButton.Location = new Point(33, 353);
        addMedButton.Name = "addMedButton";
        addMedButton.Size = new Size(180, 76);
        addMedButton.TabIndex = 7;
        addMedButton.Text = "Add Medicine";
        addMedButton.UseVisualStyleBackColor = true;
        addMedButton.Click += addMedButton_Click;
        // 
        // clearButton
        // 
        clearButton.Location = new Point(236, 362);
        clearButton.Name = "clearButton";
        clearButton.Size = new Size(147, 58);
        clearButton.TabIndex = 8;
        clearButton.Text = "clear";
        clearButton.UseVisualStyleBackColor = true;
        clearButton.Click += clearButton_Click;
        // 
        // captionMedStockLabel
        // 
        captionMedStockLabel.AutoSize = true;
        captionMedStockLabel.Location = new Point(410, 424);
        captionMedStockLabel.Name = "captionMedStockLabel";
        captionMedStockLabel.Size = new Size(110, 20);
        captionMedStockLabel.TabIndex = 9;
        captionMedStockLabel.Text = "Medicine Stock";
        // 
        // deleteButton
        // 
        deleteButton.Location = new Point(741, 353);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new Size(175, 67);
        deleteButton.TabIndex = 18;
        deleteButton.Text = "Delete Medicine";
        deleteButton.UseVisualStyleBackColor = true;
        deleteButton.Click += deleteButton_Click;
        // 
        // updateButton
        // 
        updateButton.Location = new Point(546, 353);
        updateButton.Name = "updateButton";
        updateButton.Size = new Size(189, 67);
        updateButton.TabIndex = 17;
        updateButton.Text = "Update Stock";
        updateButton.UseVisualStyleBackColor = true;
        updateButton.Click += updateButton_Click;
        // 
        // medNameSelectedTextBox
        // 
        medNameSelectedTextBox.Location = new Point(732, 118);
        medNameSelectedTextBox.Name = "medNameSelectedTextBox";
        medNameSelectedTextBox.Size = new Size(184, 27);
        medNameSelectedTextBox.TabIndex = 12;
        // 
        // refreshButton
        // 
        refreshButton.Location = new Point(935, 353);
        refreshButton.Name = "refreshButton";
        refreshButton.Size = new Size(101, 67);
        refreshButton.TabIndex = 19;
        refreshButton.Text = "Refresh";
        refreshButton.UseVisualStyleBackColor = true;
        refreshButton.Click += refreshButton_Click;
        // 
        // medicineGridView
        // 
        medicineGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        medicineGridView.Location = new Point(174, 447);
        medicineGridView.Name = "medicineGridView";
        medicineGridView.RowHeadersWidth = 51;
        medicineGridView.Size = new Size(718, 238);
        medicineGridView.TabIndex = 20;
        medicineGridView.CellClick += medicineGridView_CellClick;
        // 
        // quantityAddNumeric
        // 
        quantityAddNumeric.Location = new Point(145, 203);
        quantityAddNumeric.Name = "quantityAddNumeric";
        quantityAddNumeric.Size = new Size(150, 27);
        quantityAddNumeric.TabIndex = 21;
        // 
        // priceAddNumeric
        // 
        priceAddNumeric.Location = new Point(101, 269);
        priceAddNumeric.Name = "priceAddNumeric";
        priceAddNumeric.Size = new Size(150, 27);
        priceAddNumeric.TabIndex = 22;
        // 
        // quantitySelectedNumeric
        // 
        quantitySelectedNumeric.Location = new Point(657, 192);
        quantitySelectedNumeric.Name = "quantitySelectedNumeric";
        quantitySelectedNumeric.Size = new Size(150, 27);
        quantitySelectedNumeric.TabIndex = 23;
        // 
        // priceSelectedNumeric
        // 
        priceSelectedNumeric.Location = new Point(611, 269);
        priceSelectedNumeric.Name = "priceSelectedNumeric";
        priceSelectedNumeric.Size = new Size(150, 27);
        priceSelectedNumeric.TabIndex = 24;
        // 
        // MedicineManagementPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        BackgroundImage = Properties.Resources._05_medicine_stock_background;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1075, 689);
        Controls.Add(priceSelectedNumeric);
        Controls.Add(quantitySelectedNumeric);
        Controls.Add(priceAddNumeric);
        Controls.Add(quantityAddNumeric);
        Controls.Add(medicineGridView);
        Controls.Add(refreshButton);
        Controls.Add(deleteButton);
        Controls.Add(updateButton);
        Controls.Add(medNameSelectedTextBox);
        Controls.Add(captionMedStockLabel);
        Controls.Add(clearButton);
        Controls.Add(addMedButton);
        Controls.Add(medNameAddTextBox);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "MedicineManagementPage";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "MedicinieManagement";
        ((System.ComponentModel.ISupportInitialize)medicineGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)quantityAddNumeric).EndInit();
        ((System.ComponentModel.ISupportInitialize)priceAddNumeric).EndInit();
        ((System.ComponentModel.ISupportInitialize)quantitySelectedNumeric).EndInit();
        ((System.ComponentModel.ISupportInitialize)priceSelectedNumeric).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox medNameAddTextBox;
    private Button addMedButton;
    private Button clearButton;
    private Label captionMedStockLabel;
    private Button deleteButton;
    private Button updateButton;
    private TextBox medNameSelectedTextBox;
    private Button refreshButton;
    private DataGridView medicineGridView;
    private NumericUpDown quantityAddNumeric;
    private NumericUpDown priceAddNumeric;
    private NumericUpDown quantitySelectedNumeric;
    private NumericUpDown priceSelectedNumeric;
}