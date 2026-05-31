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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceSummaryPage));
        visitLabel = new Label();
        medNum = new Label();
        totalNum = new Label();
        MedListBox = new ListBox();
        SuspendLayout();
        // 
        // visitLabel
        // 
        visitLabel.AutoSize = true;
        visitLabel.BackColor = Color.Transparent;
        visitLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        visitLabel.Location = new Point(297, 151);
        visitLabel.Name = "visitLabel";
        visitLabel.Size = new Size(59, 31);
        visitLabel.TabIndex = 0;
        visitLabel.Text = " 100";
        // 
        // medNum
        // 
        medNum.AutoSize = true;
        medNum.BackColor = Color.Transparent;
        medNum.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        medNum.Location = new Point(360, 214);
        medNum.Name = "medNum";
        medNum.Size = new Size(40, 31);
        medNum.TabIndex = 2;
        medNum.Text = "50";
        // 
        // totalNum
        // 
        totalNum.AutoSize = true;
        totalNum.BackColor = Color.Transparent;
        totalNum.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        totalNum.Location = new Point(314, 282);
        totalNum.Name = "totalNum";
        totalNum.Size = new Size(53, 31);
        totalNum.TabIndex = 4;
        totalNum.Text = "150";
        // 
        // MedListBox
        // 
        MedListBox.FormattingEnabled = true;
        MedListBox.Location = new Point(183, 413);
        MedListBox.Name = "MedListBox";
        MedListBox.Size = new Size(534, 224);
        MedListBox.TabIndex = 6;
        // 
        // PriceSummaryPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources._07_summary_background;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(984, 650);
        Controls.Add(MedListBox);
        Controls.Add(totalNum);
        Controls.Add(medNum);
        Controls.Add(visitLabel);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimizeBox = false;
        Name = "PriceSummaryPage";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "PriceSummary";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label visitLabel;
    private Label medNum;
    private Label totalNum;
    private ListBox MedListBox;
}