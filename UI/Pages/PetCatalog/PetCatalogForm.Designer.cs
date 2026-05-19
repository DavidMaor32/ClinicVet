namespace ClinicVet.Gui.Pages.PetCatalog;

partial class PetCatalogForm
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
        backBtn = new Button();
        listBox1 = new ListBox();
        addNewBtn = new Button();
        deleteBtn = new Button();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        label1 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        textBox4 = new TextBox();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // backBtn
        // 
        backBtn.BackColor = SystemColors.ActiveCaption;
        backBtn.Location = new Point(12, 12);
        backBtn.Name = "backBtn";
        backBtn.Size = new Size(94, 29);
        backBtn.TabIndex = 9;
        backBtn.Text = "<<Back";
        backBtn.UseVisualStyleBackColor = false;
        backBtn.Click += backBtn_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new Point(52, 26);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(227, 344);
        listBox1.TabIndex = 10;
        // 
        // addNewBtn
        // 
        addNewBtn.Location = new Point(71, 402);
        addNewBtn.Name = "addNewBtn";
        addNewBtn.Size = new Size(171, 29);
        addNewBtn.TabIndex = 11;
        addNewBtn.Text = "Add New...";
        addNewBtn.UseVisualStyleBackColor = true;
        addNewBtn.Click += button1_Click;
        // 
        // deleteBtn
        // 
        deleteBtn.Location = new Point(71, 448);
        deleteBtn.Name = "deleteBtn";
        deleteBtn.Size = new Size(171, 29);
        deleteBtn.TabIndex = 12;
        deleteBtn.Text = "Delete selected";
        deleteBtn.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(listBox1);
        groupBox1.Controls.Add(deleteBtn);
        groupBox1.Controls.Add(addNewBtn);
        groupBox1.Location = new Point(12, 64);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(350, 494);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(textBox4);
        groupBox2.Controls.Add(textBox3);
        groupBox2.Controls.Add(textBox2);
        groupBox2.Controls.Add(textBox1);
        groupBox2.Location = new Point(394, 64);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(559, 494);
        groupBox2.TabIndex = 14;
        groupBox2.TabStop = false;
        groupBox2.Text = "groupBox2";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        label1.Location = new Point(394, 30);
        label1.Name = "label1";
        label1.Size = new Size(251, 25);
        label1.TabIndex = 15;
        label1.Text = "Details for selected species:";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(135, 52);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(398, 27);
        textBox1.TabIndex = 0;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(135, 136);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(398, 27);
        textBox2.TabIndex = 1;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(135, 241);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(398, 27);
        textBox3.TabIndex = 2;
        // 
        // textBox4
        // 
        textBox4.Location = new Point(135, 329);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(398, 27);
        textBox4.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 55);
        label2.Name = "label2";
        label2.Size = new Size(106, 20);
        label2.TabIndex = 4;
        label2.Text = "Species Name:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(7, 139);
        label3.Name = "label3";
        label3.Size = new Size(122, 20);
        label3.TabIndex = 5;
        label3.Text = "Common Breeds:";
        label3.Click += label3_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(24, 244);
        label4.Name = "label4";
        label4.Size = new Size(88, 20);
        label4.TabIndex = 6;
        label4.Text = "Description:";
        label4.Click += label4_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(43, 332);
        label5.Name = "label5";
        label5.Size = new Size(51, 20);
        label5.TabIndex = 7;
        label5.Text = "Notes:";
        label5.Click += label5_Click;
        // 
        // PetCatalogForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(965, 585);
        Controls.Add(label1);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(backBtn);
        Name = "PetCatalogForm";
        Text = "PetCatalogForm";
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button backBtn;
    private ListBox listBox1;
    private Button addNewBtn;
    private Button deleteBtn;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private TextBox textBox1;
    private Label label1;
    private TextBox textBox4;
    private TextBox textBox3;
    private TextBox textBox2;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
}