namespace ClinicVet.Gui.Pages.Pet;

partial class PetForm
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
        TB_pet_name = new TextBox();
        TB_pet_weight = new TextBox();
        Date_birth = new DateTimePicker();
        TB_owner = new TextBox();
        Date_vac = new DateTimePicker();
        btnFinishAddPet = new Button();
        lblPetNameValid = new Label();
        CBxPetType = new ComboBox();
        lblPetTaype = new Label();
        X_weightVal = new Label();
        X_birthDateVal = new Label();
        X_ownerVal = new Label();
        X_vaccineVal = new Label();
        radioButtonGotVaccine = new RadioButton();
        radioButtonNoVacc = new RadioButton();
        catalog = new ListBox();
        deleteBtn = new Button();
        addAnimalBtn = new Button();
        addTxtBx = new TextBox();
        DoneBtn = new Button();
        SuspendLayout();
        // 
        // TB_pet_name
        // 
        TB_pet_name.ForeColor = SystemColors.WindowText;
        TB_pet_name.Location = new Point(880, 136);
        TB_pet_name.Name = "TB_pet_name";
        TB_pet_name.Size = new Size(220, 27);
        TB_pet_name.TabIndex = 1;
        // 
        // TB_pet_weight
        // 
        TB_pet_weight.Location = new Point(907, 292);
        TB_pet_weight.Name = "TB_pet_weight";
        TB_pet_weight.Size = new Size(289, 27);
        TB_pet_weight.TabIndex = 8;
        // 
        // Date_birth
        // 
        Date_birth.Location = new Point(853, 362);
        Date_birth.Name = "Date_birth";
        Date_birth.Size = new Size(250, 27);
        Date_birth.TabIndex = 11;
        Date_birth.Value = new DateTime(1800, 5, 10, 22, 51, 0, 0);
        // 
        // TB_owner
        // 
        TB_owner.Location = new Point(853, 417);
        TB_owner.Name = "TB_owner";
        TB_owner.Size = new Size(247, 27);
        TB_owner.TabIndex = 14;
        // 
        // Date_vac
        // 
        Date_vac.Enabled = false;
        Date_vac.Location = new Point(1050, 516);
        Date_vac.Name = "Date_vac";
        Date_vac.Size = new Size(250, 27);
        Date_vac.TabIndex = 15;
        Date_vac.Value = new DateTime(1799, 5, 10, 22, 51, 0, 0);
        Date_vac.Visible = false;
        // 
        // btnFinishAddPet
        // 
        btnFinishAddPet.BackColor = SystemColors.ActiveCaption;
        btnFinishAddPet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnFinishAddPet.Location = new Point(931, 607);
        btnFinishAddPet.Name = "btnFinishAddPet";
        btnFinishAddPet.Size = new Size(185, 67);
        btnFinishAddPet.TabIndex = 18;
        btnFinishAddPet.Text = "Add New...";
        btnFinishAddPet.UseVisualStyleBackColor = false;
        btnFinishAddPet.Click += btnFinishAddPet_Click;
        // 
        // lblPetNameValid
        // 
        lblPetNameValid.AutoSize = true;
        lblPetNameValid.BackColor = Color.Transparent;
        lblPetNameValid.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblPetNameValid.ForeColor = Color.Red;
        lblPetNameValid.Location = new Point(1121, 136);
        lblPetNameValid.Name = "lblPetNameValid";
        lblPetNameValid.Size = new Size(29, 31);
        lblPetNameValid.TabIndex = 19;
        lblPetNameValid.Text = "X";
        lblPetNameValid.Visible = false;
        // 
        // CBxPetType
        // 
        CBxPetType.FormattingEnabled = true;
        CBxPetType.Location = new Point(886, 219);
        CBxPetType.Name = "CBxPetType";
        CBxPetType.Size = new Size(188, 28);
        CBxPetType.TabIndex = 20;
        CBxPetType.TextUpdate += CBxPetType_TextChanged;
        // 
        // lblPetTaype
        // 
        lblPetTaype.AutoSize = true;
        lblPetTaype.BackColor = Color.Transparent;
        lblPetTaype.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblPetTaype.ForeColor = Color.Red;
        lblPetTaype.Location = new Point(1092, 218);
        lblPetTaype.Name = "lblPetTaype";
        lblPetTaype.Size = new Size(29, 31);
        lblPetTaype.TabIndex = 21;
        lblPetTaype.Text = "X";
        lblPetTaype.Visible = false;
        // 
        // X_weightVal
        // 
        X_weightVal.AutoSize = true;
        X_weightVal.BackColor = Color.Transparent;
        X_weightVal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        X_weightVal.ForeColor = Color.Red;
        X_weightVal.Location = new Point(1217, 291);
        X_weightVal.Name = "X_weightVal";
        X_weightVal.Size = new Size(29, 31);
        X_weightVal.TabIndex = 22;
        X_weightVal.Text = "X";
        X_weightVal.Visible = false;
        // 
        // X_birthDateVal
        // 
        X_birthDateVal.AutoSize = true;
        X_birthDateVal.BackColor = Color.Transparent;
        X_birthDateVal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        X_birthDateVal.ForeColor = Color.Red;
        X_birthDateVal.Location = new Point(1121, 364);
        X_birthDateVal.Name = "X_birthDateVal";
        X_birthDateVal.Size = new Size(29, 31);
        X_birthDateVal.TabIndex = 23;
        X_birthDateVal.Text = "X";
        X_birthDateVal.Visible = false;
        // 
        // X_ownerVal
        // 
        X_ownerVal.AutoSize = true;
        X_ownerVal.BackColor = Color.Transparent;
        X_ownerVal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        X_ownerVal.ForeColor = Color.Red;
        X_ownerVal.Location = new Point(1106, 417);
        X_ownerVal.Name = "X_ownerVal";
        X_ownerVal.Size = new Size(29, 31);
        X_ownerVal.TabIndex = 24;
        X_ownerVal.Text = "X";
        X_ownerVal.Visible = false;
        // 
        // X_vaccineVal
        // 
        X_vaccineVal.AutoSize = true;
        X_vaccineVal.BackColor = Color.Transparent;
        X_vaccineVal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        X_vaccineVal.ForeColor = Color.Red;
        X_vaccineVal.Location = new Point(1311, 518);
        X_vaccineVal.Name = "X_vaccineVal";
        X_vaccineVal.Size = new Size(29, 31);
        X_vaccineVal.TabIndex = 25;
        X_vaccineVal.Text = "X";
        X_vaccineVal.Visible = false;
        // 
        // radioButtonGotVaccine
        // 
        radioButtonGotVaccine.AutoSize = true;
        radioButtonGotVaccine.BackColor = Color.Transparent;
        radioButtonGotVaccine.Location = new Point(1086, 481);
        radioButtonGotVaccine.Name = "radioButtonGotVaccine";
        radioButtonGotVaccine.Size = new Size(17, 16);
        radioButtonGotVaccine.TabIndex = 27;
        radioButtonGotVaccine.TabStop = true;
        radioButtonGotVaccine.UseVisualStyleBackColor = false;
        radioButtonGotVaccine.CheckedChanged += radioButtonGotVaccine_CheckedChanged;
        // 
        // radioButtonNoVacc
        // 
        radioButtonNoVacc.AutoSize = true;
        radioButtonNoVacc.BackColor = Color.Transparent;
        radioButtonNoVacc.Location = new Point(880, 487);
        radioButtonNoVacc.Name = "radioButtonNoVacc";
        radioButtonNoVacc.Size = new Size(17, 16);
        radioButtonNoVacc.TabIndex = 28;
        radioButtonNoVacc.TabStop = true;
        radioButtonNoVacc.UseVisualStyleBackColor = false;
        radioButtonNoVacc.CheckedChanged += radioButtonNoVacc_CheckedChanged;
        // 
        // catalog
        // 
        catalog.FormattingEnabled = true;
        catalog.Location = new Point(139, 12);
        catalog.Name = "catalog";
        catalog.Size = new Size(337, 444);
        catalog.TabIndex = 29;
        // 
        // deleteBtn
        // 
        deleteBtn.BackColor = SystemColors.ActiveCaption;
        deleteBtn.Location = new Point(327, 551);
        deleteBtn.Name = "deleteBtn";
        deleteBtn.Size = new Size(171, 69);
        deleteBtn.TabIndex = 30;
        deleteBtn.Text = "Delete selected";
        deleteBtn.UseVisualStyleBackColor = false;
        deleteBtn.Click += deleteBtn_Click;
        // 
        // addAnimalBtn
        // 
        addAnimalBtn.BackColor = SystemColors.ActiveCaption;
        addAnimalBtn.Location = new Point(91, 551);
        addAnimalBtn.Name = "addAnimalBtn";
        addAnimalBtn.Size = new Size(171, 69);
        addAnimalBtn.TabIndex = 31;
        addAnimalBtn.Text = "Add animal type";
        addAnimalBtn.UseVisualStyleBackColor = false;
        addAnimalBtn.Click += addAnimalBtn_Click;
        // 
        // addTxtBx
        // 
        addTxtBx.Enabled = false;
        addTxtBx.ForeColor = SystemColors.WindowText;
        addTxtBx.Location = new Point(119, 516);
        addTxtBx.Name = "addTxtBx";
        addTxtBx.Size = new Size(125, 27);
        addTxtBx.TabIndex = 32;
        addTxtBx.Visible = false;
        // 
        // DoneBtn
        // 
        DoneBtn.Enabled = false;
        DoneBtn.ForeColor = SystemColors.ActiveCaptionText;
        DoneBtn.Location = new Point(250, 516);
        DoneBtn.Name = "DoneBtn";
        DoneBtn.Size = new Size(51, 27);
        DoneBtn.TabIndex = 33;
        DoneBtn.Text = "done";
        DoneBtn.UseVisualStyleBackColor = true;
        DoneBtn.Visible = false;
        DoneBtn.Click += DoneBtn_Click;
        // 
        // PetForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = global::ClinicVet.Properties.Resources.petForm;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1375, 686);
        Controls.Add(CBxPetType);
        Controls.Add(DoneBtn);
        Controls.Add(TB_pet_name);
        Controls.Add(addTxtBx);
        Controls.Add(addAnimalBtn);
        Controls.Add(catalog);
        Controls.Add(deleteBtn);
        Controls.Add(radioButtonNoVacc);
        Controls.Add(TB_pet_weight);
        Controls.Add(btnFinishAddPet);
        Controls.Add(radioButtonGotVaccine);
        Controls.Add(Date_vac);
        Controls.Add(lblPetNameValid);
        Controls.Add(X_vaccineVal);
        Controls.Add(TB_owner);
        Controls.Add(lblPetTaype);
        Controls.Add(X_ownerVal);
        Controls.Add(Date_birth);
        Controls.Add(X_weightVal);
        Controls.Add(X_birthDateVal);
        DoubleBuffered = true;
        ForeColor = SystemColors.ButtonHighlight;
        Name = "PetForm";
        Text = " Pet form";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox TB_pet_name;
    private TextBox TB_pet_weight;
    private DateTimePicker Date_birth;
    private TextBox TB_owner;
    private DateTimePicker Date_vac;
    private Button btnFinishAddPet;
    private Label lblPetNameValid;
    private ComboBox CBxPetType;
    private Label lblPetTaype;
    private Label X_weightVal;
    private Label X_birthDateVal;
    private Label X_ownerVal;
    private Label X_vaccineVal;
    private RadioButton radioButtonGotVaccine;
    private RadioButton radioButtonNoVacc;
    private ListBox catalog;
    private Button deleteBtn;
    private Button addAnimalBtn;
    private TextBox addTxtBx;
    private Button DoneBtn;
}
