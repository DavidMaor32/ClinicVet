namespace team3
{
    partial class OpenVisit
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
            pracNameLabel = new Label();
            petNameLabel = new Label();
            visitLabel = new Label();
            VisitTextBox = new TextBox();
            diagnosisLabel = new Label();
            diagnosisTextBox = new TextBox();
            medicineLabel = new Label();
            medicineComboBox = new ComboBox();
            addButton = new Button();
            sendButton = new Button();
            pracName = new Label();
            petName = new Label();
            vaccineAlertLabel = new Label();
            medicineListBox = new ListBox();
            selectedMedLabel = new Label();
            quantityLabel = new Label();
            quantityNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)quantityNum).BeginInit();
            SuspendLayout();
            // 
            // pracNameLabel
            // 
            pracNameLabel.AutoSize = true;
            pracNameLabel.Location = new Point(12, 25);
            pracNameLabel.Name = "pracNameLabel";
            pracNameLabel.Size = new Size(149, 20);
            pracNameLabel.TabIndex = 0;
            pracNameLabel.Text = " Practitioner's Name: ";
            // 
            // petNameLabel
            // 
            petNameLabel.AutoSize = true;
            petNameLabel.Location = new Point(12, 120);
            petNameLabel.Name = "petNameLabel";
            petNameLabel.Size = new Size(89, 20);
            petNameLabel.TabIndex = 1;
            petNameLabel.Text = "Pet's Name: ";
            // 
            // visitLabel
            // 
            visitLabel.AutoSize = true;
            visitLabel.Location = new Point(12, 159);
            visitLabel.Name = "visitLabel";
            visitLabel.Size = new Size(92, 20);
            visitLabel.TabIndex = 2;
            visitLabel.Text = "Visit Reason:";
            // 
            // VisitTextBox
            // 
            VisitTextBox.Location = new Point(12, 182);
            VisitTextBox.Name = "VisitTextBox";
            VisitTextBox.Size = new Size(268, 27);
            VisitTextBox.TabIndex = 4;
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new Point(12, 229);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new Size(77, 20);
            diagnosisLabel.TabIndex = 5;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // diagnosisTextBox
            // 
            diagnosisTextBox.Location = new Point(12, 252);
            diagnosisTextBox.Name = "diagnosisTextBox";
            diagnosisTextBox.Size = new Size(268, 27);
            diagnosisTextBox.TabIndex = 6;
            // 
            // medicineLabel
            // 
            medicineLabel.AutoSize = true;
            medicineLabel.Location = new Point(12, 306);
            medicineLabel.Name = "medicineLabel";
            medicineLabel.Size = new Size(70, 20);
            medicineLabel.TabIndex = 7;
            medicineLabel.Text = "Medicine";
            // 
            // medicineComboBox
            // 
            medicineComboBox.FormattingEnabled = true;
            medicineComboBox.Location = new Point(12, 329);
            medicineComboBox.Name = "medicineComboBox";
            medicineComboBox.Size = new Size(151, 28);
            medicineComboBox.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.Location = new Point(317, 329);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 9;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(352, 396);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(94, 29);
            sendButton.TabIndex = 11;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // pracName
            // 
            pracName.AutoSize = true;
            pracName.Location = new Point(153, 25);
            pracName.Name = "pracName";
            pracName.Size = new Size(48, 20);
            pracName.TabIndex = 13;
            pracName.Text = "David";
            // 
            // petName
            // 
            petName.AutoSize = true;
            petName.Location = new Point(92, 120);
            petName.Name = "petName";
            petName.Size = new Size(60, 20);
            petName.TabIndex = 14;
            petName.Text = "Batman";
            // 
            // vaccineAlertLabel
            // 
            vaccineAlertLabel.AutoSize = true;
            vaccineAlertLabel.Location = new Point(447, 25);
            vaccineAlertLabel.Name = "vaccineAlertLabel";
            vaccineAlertLabel.Size = new Size(200, 20);
            vaccineAlertLabel.TabIndex = 15;
            vaccineAlertLabel.Text = "Not vaccinated this past year";
            // 
            // medicineListBox
            // 
            medicineListBox.FormattingEnabled = true;
            medicineListBox.Location = new Point(447, 105);
            medicineListBox.Name = "medicineListBox";
            medicineListBox.Size = new Size(245, 144);
            medicineListBox.TabIndex = 12;
            // 
            // selectedMedLabel
            // 
            selectedMedLabel.AutoSize = true;
            selectedMedLabel.Location = new Point(447, 79);
            selectedMedLabel.Name = "selectedMedLabel";
            selectedMedLabel.Size = new Size(134, 20);
            selectedMedLabel.TabIndex = 10;
            selectedMedLabel.Text = "Selected Medicine:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(163, 334);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(72, 20);
            quantityLabel.TabIndex = 16;
            quantityLabel.Text = "Quantity: ";
            // 
            // quantityNum
            // 
            quantityNum.Location = new Point(229, 332);
            quantityNum.Name = "quantityNum";
            quantityNum.Size = new Size(82, 27);
            quantityNum.TabIndex = 17;
            // 
            // OpenVisit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(quantityNum);
            Controls.Add(quantityLabel);
            Controls.Add(vaccineAlertLabel);
            Controls.Add(petName);
            Controls.Add(pracName);
            Controls.Add(medicineListBox);
            Controls.Add(sendButton);
            Controls.Add(selectedMedLabel);
            Controls.Add(addButton);
            Controls.Add(medicineComboBox);
            Controls.Add(medicineLabel);
            Controls.Add(diagnosisTextBox);
            Controls.Add(diagnosisLabel);
            Controls.Add(VisitTextBox);
            Controls.Add(visitLabel);
            Controls.Add(petNameLabel);
            Controls.Add(pracNameLabel);
            Name = "OpenVisit";
            Text = "OpenVisit";
            ((System.ComponentModel.ISupportInitialize)quantityNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pracNameLabel;
        private Label petNameLabel;
        private Label visitLabel;
        private TextBox VisitTextBox;
        private Label diagnosisLabel;
        private TextBox diagnosisTextBox;
        private Label medicineLabel;
        private ComboBox medicineComboBox;
        private Button addButton;
        private Button sendButton;
        private Label pracName;
        private Label petName;
        private Label vaccineAlertLabel;
        private ListBox medicineListBox;
        private Label selectedMedLabel;
        private Label quantityLabel;
        private NumericUpDown quantityNum;
    }
}
