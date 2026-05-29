namespace ClinicVet.UI.Pages.PriceSummary;

partial class PriceSummaryPage
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
        visitLabel = new Label();
        medLabel = new Label();
        medNum = new Label();
        totalLabel = new Label();
        totalNum = new Label();
        precMedLabel = new Label();
        MedListBox = new ListBox();
        SuspendLayout();
        // 
        // visitLabel
        // 
        visitLabel.AutoSize = true;
        visitLabel.Location = new Point(12, 113);
        visitLabel.Name = "visitLabel";
        visitLabel.Size = new Size(104, 20);
        visitLabel.TabIndex = 0;
        visitLabel.Text = "Visit Price: 100";
        // 
        // medLabel
        // 
        medLabel.AutoSize = true;
        medLabel.Location = new Point(12, 151);
        medLabel.Name = "medLabel";
        medLabel.Size = new Size(109, 20);
        medLabel.TabIndex = 1;
        medLabel.Text = "Medicine Price:";
        // 
        // medNum
        // 
        medNum.AutoSize = true;
        medNum.Location = new Point(117, 151);
        medNum.Name = "medNum";
        medNum.Size = new Size(25, 20);
        medNum.TabIndex = 2;
        medNum.Text = "50";
        // 
        // totalLabel
        // 
        totalLabel.AutoSize = true;
        totalLabel.Location = new Point(12, 184);
        totalLabel.Name = "totalLabel";
        totalLabel.Size = new Size(81, 20);
        totalLabel.TabIndex = 3;
        totalLabel.Text = "Total Price:";
        // 
        // totalNum
        // 
        totalNum.AutoSize = true;
        totalNum.Location = new Point(92, 184);
        totalNum.Name = "totalNum";
        totalNum.Size = new Size(33, 20);
        totalNum.TabIndex = 4;
        totalNum.Text = "150";
        // 
        // precMedLabel
        // 
        precMedLabel.AutoSize = true;
        precMedLabel.Location = new Point(12, 249);
        precMedLabel.Name = "precMedLabel";
        precMedLabel.Size = new Size(146, 20);
        precMedLabel.TabIndex = 5;
        precMedLabel.Text = "Prescribed Medicine:";
        // 
        // MedListBox
        // 
        MedListBox.FormattingEnabled = true;
        MedListBox.Location = new Point(12, 272);
        MedListBox.Name = "MedListBox";
        MedListBox.Size = new Size(249, 164);
        MedListBox.TabIndex = 6;
        // 
        // PriceSummary
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(MedListBox);
        Controls.Add(precMedLabel);
        Controls.Add(totalNum);
        Controls.Add(totalLabel);
        Controls.Add(medNum);
        Controls.Add(medLabel);
        Controls.Add(visitLabel);
        Name = "PriceSummary";
        Text = "PriceSummary";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label visitLabel;
    private Label medLabel;
    private Label medNum;
    private Label totalLabel;
    private Label totalNum;
    private Label precMedLabel;
    private ListBox MedListBox;
}