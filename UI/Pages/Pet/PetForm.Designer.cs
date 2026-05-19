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
        Lbl1 = new Label();
        TB_pet_name = new TextBox();
        lblBx = new Label();
        lblPetType = new Label();
        TB_pet_weight = new TextBox();
        lblWeight = new Label();
        lblPetBirth = new Label();
        Date_birth = new DateTimePicker();
        lblOwner = new Label();
        label1 = new Label();
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
        SuspendLayout();
        // 
        // Lbl1
        // 
        Lbl1.AutoSize = true;
        Lbl1.BackColor = SystemColors.ActiveCaption;
        Lbl1.BorderStyle = BorderStyle.Fixed3D;
        Lbl1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        Lbl1.Location = new Point(10, 18);
        Lbl1.Name = "Lbl1";
        Lbl1.Size = new Size(109, 27);
        Lbl1.TabIndex = 0;
        Lbl1.Text = "Pet details:";
        // 
        // TB_pet_name
        // 
        TB_pet_name.ForeColor = SystemColors.WindowText;
        TB_pet_name.Location = new Point(139, 64);
        TB_pet_name.Name = "TB_pet_name";
        TB_pet_name.Size = new Size(125, 27);
        TB_pet_name.TabIndex = 1;
        // 
        // lblBx
        // 
        lblBx.AutoSize = true;
        lblBx.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblBx.Location = new Point(10, 64);
        lblBx.Name = "lblBx";
        lblBx.Size = new Size(124, 20);
        lblBx.TabIndex = 2;
        lblBx.Text = "Enter pet name: ";
        // 
        // lblPetType
        // 
        lblPetType.AutoSize = true;
        lblPetType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPetType.Location = new Point(12, 120);
        lblPetType.Name = "lblPetType";
        lblPetType.Size = new Size(116, 20);
        lblPetType.TabIndex = 3;
        lblPetType.Text = "Check pet type:";
        // 
        // TB_pet_weight
        // 
        TB_pet_weight.Location = new Point(142, 174);
        TB_pet_weight.Name = "TB_pet_weight";
        TB_pet_weight.Size = new Size(125, 27);
        TB_pet_weight.TabIndex = 8;
        // 
        // lblWeight
        // 
        lblWeight.AutoSize = true;
        lblWeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblWeight.Location = new Point(11, 177);
        lblWeight.Name = "lblWeight";
        lblWeight.Size = new Size(133, 20);
        lblWeight.TabIndex = 9;
        lblWeight.Text = "Enter pet weight: ";
        // 
        // lblPetBirth
        // 
        lblPetBirth.AutoSize = true;
        lblPetBirth.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPetBirth.Location = new Point(11, 237);
        lblPetBirth.Name = "lblPetBirth";
        lblPetBirth.Size = new Size(107, 20);
        lblPetBirth.TabIndex = 10;
        lblPetBirth.Text = "Date of birth: ";
        // 
        // Date_birth
        // 
        Date_birth.Location = new Point(121, 237);
        Date_birth.Name = "Date_birth";
        Date_birth.Size = new Size(250, 27);
        Date_birth.TabIndex = 11;
        Date_birth.Value = new DateTime(1999, 5, 10, 22, 51, 0, 0);
        // 
        // lblOwner
        // 
        lblOwner.AutoSize = true;
        lblOwner.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblOwner.Location = new Point(10, 292);
        lblOwner.Name = "lblOwner";
        lblOwner.Size = new Size(101, 20);
        lblOwner.TabIndex = 12;
        lblOwner.Text = "Enter Owner:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label1.Location = new Point(11, 360);
        label1.Name = "label1";
        label1.Size = new Size(111, 20);
        label1.TabIndex = 13;
        label1.Text = "Latest vaccine:";
        // 
        // TB_owner
        // 
        TB_owner.Location = new Point(121, 292);
        TB_owner.Name = "TB_owner";
        TB_owner.Size = new Size(125, 27);
        TB_owner.TabIndex = 14;
        // 
        // Date_vac
        // 
        Date_vac.Enabled = false;
        Date_vac.Location = new Point(436, 360);
        Date_vac.Name = "Date_vac";
        Date_vac.Size = new Size(250, 27);
        Date_vac.TabIndex = 15;
        Date_vac.Value = new DateTime(1999, 5, 10, 22, 51, 0, 0);
        // 
        // btnFinishAddPet
        // 
        btnFinishAddPet.BackColor = SystemColors.ActiveCaption;
        btnFinishAddPet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnFinishAddPet.Location = new Point(696, 422);
        btnFinishAddPet.Name = "btnFinishAddPet";
        btnFinishAddPet.Size = new Size(94, 29);
        btnFinishAddPet.TabIndex = 18;
        btnFinishAddPet.Text = "Check";
        btnFinishAddPet.UseVisualStyleBackColor = false;
        btnFinishAddPet.Click += btnFinishAddPet_Click;
        // 
        // lblPetNameValid
        // 
        lblPetNameValid.AutoSize = true;
        lblPetNameValid.Font = new Font("Segoe UI", 11F);
        lblPetNameValid.ForeColor = Color.Firebrick;
        lblPetNameValid.Location = new Point(309, 66);
        lblPetNameValid.Name = "lblPetNameValid";
        lblPetNameValid.Size = new Size(23, 25);
        lblPetNameValid.TabIndex = 19;
        lblPetNameValid.Text = "X";
        lblPetNameValid.Visible = false;
        // 
        // CBxPetType
        // 
        CBxPetType.FormattingEnabled = true;
        CBxPetType.Location = new Point(137, 117);
        CBxPetType.Name = "CBxPetType";
        CBxPetType.Size = new Size(151, 28);
        CBxPetType.TabIndex = 20;
        // 
        // lblPetTaype
        // 
        lblPetTaype.AutoSize = true;
        lblPetTaype.Font = new Font("Segoe UI", 11F);
        lblPetTaype.ForeColor = Color.Firebrick;
        lblPetTaype.Location = new Point(326, 120);
        lblPetTaype.Name = "lblPetTaype";
        lblPetTaype.Size = new Size(23, 25);
        lblPetTaype.TabIndex = 21;
        lblPetTaype.Text = "X";
        lblPetTaype.Visible = false;
        // 
        // X_weightVal
        // 
        X_weightVal.AutoSize = true;
        X_weightVal.Font = new Font("Segoe UI", 11F);
        X_weightVal.ForeColor = Color.Firebrick;
        X_weightVal.Location = new Point(309, 177);
        X_weightVal.Name = "X_weightVal";
        X_weightVal.Size = new Size(23, 25);
        X_weightVal.TabIndex = 22;
        X_weightVal.Text = "X";
        X_weightVal.Visible = false;
        // 
        // X_birthDateVal
        // 
        X_birthDateVal.AutoSize = true;
        X_birthDateVal.Font = new Font("Segoe UI", 11F);
        X_birthDateVal.ForeColor = Color.Firebrick;
        X_birthDateVal.Location = new Point(410, 238);
        X_birthDateVal.Name = "X_birthDateVal";
        X_birthDateVal.Size = new Size(23, 25);
        X_birthDateVal.TabIndex = 23;
        X_birthDateVal.Text = "X";
        X_birthDateVal.Visible = false;
        // 
        // X_ownerVal
        // 
        X_ownerVal.AutoSize = true;
        X_ownerVal.Font = new Font("Segoe UI", 11F);
        X_ownerVal.ForeColor = Color.Firebrick;
        X_ownerVal.Location = new Point(280, 294);
        X_ownerVal.Name = "X_ownerVal";
        X_ownerVal.Size = new Size(23, 25);
        X_ownerVal.TabIndex = 24;
        X_ownerVal.Text = "X";
        X_ownerVal.Visible = false;
        // 
        // X_vaccineVal
        // 
        X_vaccineVal.AutoSize = true;
        X_vaccineVal.Font = new Font("Segoe UI", 11F);
        X_vaccineVal.ForeColor = Color.Firebrick;
        X_vaccineVal.Location = new Point(721, 359);
        X_vaccineVal.Name = "X_vaccineVal";
        X_vaccineVal.Size = new Size(23, 25);
        X_vaccineVal.TabIndex = 25;
        X_vaccineVal.Text = "X";
        X_vaccineVal.Visible = false;
        // 
        // radioButtonGotVaccine
        // 
        radioButtonGotVaccine.AutoSize = true;
        radioButtonGotVaccine.Location = new Point(351, 361);
        radioButtonGotVaccine.Name = "radioButtonGotVaccine";
        radioButtonGotVaccine.Size = new Size(64, 24);
        radioButtonGotVaccine.TabIndex = 27;
        radioButtonGotVaccine.TabStop = true;
        radioButtonGotVaccine.Text = "Have";
        radioButtonGotVaccine.UseVisualStyleBackColor = true;
        radioButtonGotVaccine.CheckedChanged += radioButtonGotVaccine_CheckedChanged;
        // 
        // radioButtonNoVacc
        // 
        radioButtonNoVacc.AutoSize = true;
        radioButtonNoVacc.Location = new Point(137, 361);
        radioButtonNoVacc.Name = "radioButtonNoVacc";
        radioButtonNoVacc.Size = new Size(181, 24);
        radioButtonNoVacc.TabIndex = 28;
        radioButtonNoVacc.TabStop = true;
        radioButtonNoVacc.Text = "Never been vaccinated";
        radioButtonNoVacc.UseVisualStyleBackColor = true;
        radioButtonNoVacc.CheckedChanged += radioButtonNoVacc_CheckedChanged;
        // 
        // PetForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(802, 463);
        Controls.Add(radioButtonNoVacc);
        Controls.Add(radioButtonGotVaccine);
        Controls.Add(X_vaccineVal);
        Controls.Add(X_ownerVal);
        Controls.Add(X_birthDateVal);
        Controls.Add(X_weightVal);
        Controls.Add(lblPetTaype);
        Controls.Add(CBxPetType);
        Controls.Add(lblPetNameValid);
        Controls.Add(btnFinishAddPet);
        Controls.Add(Date_vac);
        Controls.Add(TB_owner);
        Controls.Add(label1);
        Controls.Add(lblOwner);
        Controls.Add(Date_birth);
        Controls.Add(lblPetBirth);
        Controls.Add(lblWeight);
        Controls.Add(TB_pet_weight);
        Controls.Add(lblPetType);
        Controls.Add(lblBx);
        Controls.Add(TB_pet_name);
        Controls.Add(Lbl1);
        Name = "PetForm";
        Text = " ";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label Lbl1;
    private TextBox TB_pet_name;
    private Label lblBx;
    private Label lblPetType;
    private TextBox TB_pet_weight;
    private Label lblWeight;
    private Label lblPetBirth;
    private DateTimePicker Date_birth;
    private Label lblOwner;
    private Label label1;
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
}