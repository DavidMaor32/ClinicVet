namespace team3
{
    partial class MedicinieManagement
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
            captionAddLabel = new Label();
            medNameAddLabel = new Label();
            medNameAddTextBox = new TextBox();
            quantityAddLabel = new Label();
            priceAddLabel = new Label();
            addMedButton = new Button();
            clearButton = new Button();
            captionMedStockLabel = new Label();
            captionSelectedMedLabel = new Label();
            deleteButton = new Button();
            updateButton = new Button();
            priceSelectedLabel = new Label();
            quantitySelectedLabel = new Label();
            medNameSelectedTextBox = new TextBox();
            medNameSelectedLabel = new Label();
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
            // captionAddLabel
            // 
            captionAddLabel.AutoSize = true;
            captionAddLabel.Location = new Point(12, 18);
            captionAddLabel.Name = "captionAddLabel";
            captionAddLabel.Size = new Size(139, 20);
            captionAddLabel.TabIndex = 0;
            captionAddLabel.Text = "Add New Medicine:";
            // 
            // medNameAddLabel
            // 
            medNameAddLabel.AutoSize = true;
            medNameAddLabel.Location = new Point(12, 56);
            medNameAddLabel.Name = "medNameAddLabel";
            medNameAddLabel.Size = new Size(117, 20);
            medNameAddLabel.TabIndex = 1;
            medNameAddLabel.Text = "Medicine Name:";
            // 
            // medNameAddTextBox
            // 
            medNameAddTextBox.Location = new Point(12, 79);
            medNameAddTextBox.Name = "medNameAddTextBox";
            medNameAddTextBox.Size = new Size(125, 27);
            medNameAddTextBox.TabIndex = 2;
            // 
            // quantityAddLabel
            // 
            quantityAddLabel.AutoSize = true;
            quantityAddLabel.Location = new Point(12, 118);
            quantityAddLabel.Name = "quantityAddLabel";
            quantityAddLabel.Size = new Size(68, 20);
            quantityAddLabel.TabIndex = 3;
            quantityAddLabel.Text = "Quantity:";
            // 
            // priceAddLabel
            // 
            priceAddLabel.AutoSize = true;
            priceAddLabel.Location = new Point(12, 180);
            priceAddLabel.Name = "priceAddLabel";
            priceAddLabel.Size = new Size(44, 20);
            priceAddLabel.TabIndex = 5;
            priceAddLabel.Text = "Price:";
            // 
            // addMedButton
            // 
            addMedButton.Location = new Point(12, 245);
            addMedButton.Name = "addMedButton";
            addMedButton.Size = new Size(117, 29);
            addMedButton.TabIndex = 7;
            addMedButton.Text = "Add Medicine";
            addMedButton.UseVisualStyleBackColor = true;
            addMedButton.Click += addMedButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(147, 245);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 8;
            clearButton.Text = "clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // captionMedStockLabel
            // 
            captionMedStockLabel.AutoSize = true;
            captionMedStockLabel.Location = new Point(301, 279);
            captionMedStockLabel.Name = "captionMedStockLabel";
            captionMedStockLabel.Size = new Size(110, 20);
            captionMedStockLabel.TabIndex = 9;
            captionMedStockLabel.Text = "Medicine Stock";
            // 
            // captionSelectedMedLabel
            // 
            captionSelectedMedLabel.AutoSize = true;
            captionSelectedMedLabel.Location = new Point(301, 18);
            captionSelectedMedLabel.Name = "captionSelectedMedLabel";
            captionSelectedMedLabel.Size = new Size(134, 20);
            captionSelectedMedLabel.TabIndex = 10;
            captionSelectedMedLabel.Text = "Selected Medicine:";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(436, 245);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(126, 29);
            deleteButton.TabIndex = 18;
            deleteButton.Text = "Delete Medicine";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // UpdateButton
            // 
            updateButton.Location = new Point(301, 245);
            updateButton.Name = "UpdateButton";
            updateButton.Size = new Size(117, 29);
            updateButton.TabIndex = 17;
            updateButton.Text = "Update Stock";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // priceSelectedLabel
            // 
            priceSelectedLabel.AutoSize = true;
            priceSelectedLabel.Location = new Point(301, 180);
            priceSelectedLabel.Name = "priceSelectedLabel";
            priceSelectedLabel.Size = new Size(44, 20);
            priceSelectedLabel.TabIndex = 15;
            priceSelectedLabel.Text = "Price:";
            // 
            // quantitySelectedLabel
            // 
            quantitySelectedLabel.AutoSize = true;
            quantitySelectedLabel.Location = new Point(301, 118);
            quantitySelectedLabel.Name = "quantitySelectedLabel";
            quantitySelectedLabel.Size = new Size(68, 20);
            quantitySelectedLabel.TabIndex = 13;
            quantitySelectedLabel.Text = "Quantity:";
            // 
            // medNameSelectedTextBox
            // 
            medNameSelectedTextBox.Location = new Point(301, 79);
            medNameSelectedTextBox.Name = "medNameSelectedTextBox";
            medNameSelectedTextBox.Size = new Size(125, 27);
            medNameSelectedTextBox.TabIndex = 12;
            // 
            // medNameSelectedLabel
            // 
            medNameSelectedLabel.AutoSize = true;
            medNameSelectedLabel.Location = new Point(301, 56);
            medNameSelectedLabel.Name = "medNameSelectedLabel";
            medNameSelectedLabel.Size = new Size(117, 20);
            medNameSelectedLabel.TabIndex = 11;
            medNameSelectedLabel.Text = "Medicine Name:";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(583, 245);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(126, 29);
            refreshButton.TabIndex = 19;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // medicineGridView
            // 
            medicineGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medicineGridView.Location = new Point(301, 302);
            medicineGridView.Name = "medicineGridView";
            medicineGridView.RowHeadersWidth = 51;
            medicineGridView.Size = new Size(474, 188);
            medicineGridView.TabIndex = 20;
            // 
            // quantityAddNumeric
            // 
            quantityAddNumeric.Location = new Point(12, 141);
            quantityAddNumeric.Name = "quantityAddNumeric";
            quantityAddNumeric.Size = new Size(150, 27);
            quantityAddNumeric.TabIndex = 21;
            // 
            // priceAddNumeric
            // 
            priceAddNumeric.Location = new Point(12, 203);
            priceAddNumeric.Name = "priceAddNumeric";
            priceAddNumeric.Size = new Size(150, 27);
            priceAddNumeric.TabIndex = 22;
            // 
            // quantitySelectedNumeric
            // 
            quantitySelectedNumeric.Location = new Point(301, 141);
            quantitySelectedNumeric.Name = "quantitySelectedNumeric";
            quantitySelectedNumeric.Size = new Size(150, 27);
            quantitySelectedNumeric.TabIndex = 23;
            // 
            // priceSelectedNumeric
            // 
            priceSelectedNumeric.Location = new Point(301, 203);
            priceSelectedNumeric.Name = "priceSelectedNumeric";
            priceSelectedNumeric.Size = new Size(150, 27);
            priceSelectedNumeric.TabIndex = 24;
            // 
            // MedicinieManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(priceSelectedNumeric);
            Controls.Add(quantitySelectedNumeric);
            Controls.Add(priceAddNumeric);
            Controls.Add(quantityAddNumeric);
            Controls.Add(medicineGridView);
            Controls.Add(refreshButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(priceSelectedLabel);
            Controls.Add(quantitySelectedLabel);
            Controls.Add(medNameSelectedTextBox);
            Controls.Add(medNameSelectedLabel);
            Controls.Add(captionSelectedMedLabel);
            Controls.Add(captionMedStockLabel);
            Controls.Add(clearButton);
            Controls.Add(addMedButton);
            Controls.Add(priceAddLabel);
            Controls.Add(quantityAddLabel);
            Controls.Add(medNameAddTextBox);
            Controls.Add(medNameAddLabel);
            Controls.Add(captionAddLabel);
            Name = "MedicinieManagement";
            Text = "MedicinieManagement";
            ((System.ComponentModel.ISupportInitialize)medicineGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityAddNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceAddNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantitySelectedNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceSelectedNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
            medicineGridView.CellClick += medicineGridView_CellClick;
        }

        #endregion

        private Label captionAddLabel;
        private Label medNameAddLabel;
        private TextBox medNameAddTextBox;
        private Label quantityAddLabel;
        private Label priceAddLabel;
        private Button addMedButton;
        private Button clearButton;
        private Label captionMedStockLabel;
        private Label captionSelectedMedLabel;
        private Button deleteButton;
        private Button updateButton;
        private Label priceSelectedLabel;
        private Label quantitySelectedLabel;
        private TextBox medNameSelectedTextBox;
        private Label medNameSelectedLabel;
        private Button refreshButton;
        private DataGridView medicineGridView;
        private NumericUpDown quantityAddNumeric;
        private NumericUpDown priceAddNumeric;
        private NumericUpDown quantitySelectedNumeric;
        private NumericUpDown priceSelectedNumeric;
    }
}