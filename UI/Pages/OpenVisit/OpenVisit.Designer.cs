namespace ClinicVet.UI.Pages.OpenVisit;

partial class OpenVisit {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        VisitTextBox = new TextBox();
        diagnosisTextBox = new TextBox();
        medicineComboBox = new ComboBox();
        addButton = new Button();
        sendButton = new Button();
        pracName = new Label();
        vaccineLabel = new Label();
        medicineListBox = new ListBox();
        quantityNum = new NumericUpDown();
        petComboBox = new ComboBox();
        ((System.ComponentModel.ISupportInitialize)quantityNum).BeginInit();
        SuspendLayout();
        // 
        // VisitTextBox
        // 
        VisitTextBox.Location = new Point(253, 194);
        VisitTextBox.Multiline = true;
        VisitTextBox.Name = "VisitTextBox";
        VisitTextBox.Size = new Size(301, 112);
        VisitTextBox.TabIndex = 4;
        // 
        // diagnosisTextBox
        // 
        diagnosisTextBox.Location = new Point(253, 327);
        diagnosisTextBox.Multiline = true;
        diagnosisTextBox.Name = "diagnosisTextBox";
        diagnosisTextBox.Size = new Size(301, 115);
        diagnosisTextBox.TabIndex = 6;
        // 
        // medicineComboBox
        // 
        medicineComboBox.FormattingEnabled = true;
        medicineComboBox.Location = new Point(234, 462);
        medicineComboBox.Name = "medicineComboBox";
        medicineComboBox.Size = new Size(151, 28);
        medicineComboBox.TabIndex = 8;
        // 
        // addButton
        // 
        addButton.Location = new Point(361, 549);
        addButton.Name = "addButton";
        addButton.Size = new Size(94, 50);
        addButton.TabIndex = 9;
        addButton.Text = "Add";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += addButton_Click;
        // 
        // sendButton
        // 
        sendButton.Location = new Point(514, 621);
        sendButton.Name = "sendButton";
        sendButton.Size = new Size(180, 65);
        sendButton.TabIndex = 11;
        sendButton.Text = "Send";
        sendButton.UseVisualStyleBackColor = true;
        sendButton.Click += sendButton_Click;
        // 
        // pracName
        // 
        pracName.AutoSize = true;
        pracName.BackColor = Color.Transparent;
        pracName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        pracName.ForeColor = Color.Black;
        pracName.Location = new Point(443, 9);
        pracName.Name = "pracName";
        pracName.Size = new Size(96, 38);
        pracName.TabIndex = 13;
        pracName.Text = "David";
        // 
        // vaccineLabel
        // 
        vaccineLabel.AutoSize = true;
        vaccineLabel.BackColor = Color.Transparent;
        vaccineLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        vaccineLabel.Location = new Point(606, 139);
        vaccineLabel.Name = "vaccineLabel";
        vaccineLabel.Size = new Size(323, 31);
        vaccineLabel.TabIndex = 15;
        vaccineLabel.Text = "Not vaccinated this past year";
        // 
        // medicineListBox
        // 
        medicineListBox.FormattingEnabled = true;
        medicineListBox.Location = new Point(606, 230);
        medicineListBox.Name = "medicineListBox";
        medicineListBox.Size = new Size(385, 244);
        medicineListBox.TabIndex = 12;
        // 
        // quantityNum
        // 
        quantityNum.Location = new Point(234, 562);
        quantityNum.Name = "quantityNum";
        quantityNum.Size = new Size(94, 27);
        quantityNum.TabIndex = 17;
        // 
        // petComboBox
        // 
        petComboBox.FormattingEnabled = true;
        petComboBox.Location = new Point(272, 102);
        petComboBox.Name = "petComboBox";
        petComboBox.Size = new Size(183, 28);
        petComboBox.TabIndex = 18;
        // 
        // OpenVisit
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources._06_visit_form_background;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1103, 698);
        Controls.Add(petComboBox);
        Controls.Add(quantityNum);
        Controls.Add(vaccineLabel);
        Controls.Add(pracName);
        Controls.Add(medicineListBox);
        Controls.Add(sendButton);
        Controls.Add(addButton);
        Controls.Add(medicineComboBox);
        Controls.Add(diagnosisTextBox);
        Controls.Add(VisitTextBox);
        Name = "OpenVisit";
        Text = "OpenVisit";
        
        ((System.ComponentModel.ISupportInitialize)quantityNum).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox VisitTextBox;
    private TextBox diagnosisTextBox;
    private ComboBox medicineComboBox;
    private Button addButton;
    private Button sendButton;
    private Label pracName;
    private Label vaccineLabel;
    private ListBox medicineListBox;
    private NumericUpDown quantityNum;
    private ComboBox petComboBox;
}
