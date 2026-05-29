namespace ClinicVet.Gui.Pages.Home
{
    partial class Home
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
            btnWorkersPage = new Button();
            btnClientsPage = new Button();
            btnPetsManagement = new Button();
            btnVisitsPage = new Button();
            btnMedicinePage = new Button();
            btnViewVisits = new Button();
            SuspendLayout();
            // 
            // btnWorkersPage
            // 
            btnWorkersPage.Location = new Point(239, 92);
            btnWorkersPage.Margin = new Padding(2, 2, 2, 2);
            btnWorkersPage.Name = "btnWorkersPage";
            btnWorkersPage.Size = new Size(186, 27);
            btnWorkersPage.TabIndex = 0;
            btnWorkersPage.Text = "Workers Management";
            btnWorkersPage.UseVisualStyleBackColor = true;
            // 
            // btnClientsPage
            // 
            btnClientsPage.Location = new Point(239, 124);
            btnClientsPage.Margin = new Padding(2, 2, 2, 2);
            btnClientsPage.Name = "btnClientsPage";
            btnClientsPage.Size = new Size(186, 27);
            btnClientsPage.TabIndex = 1;
            btnClientsPage.Text = "Clients Management";
            btnClientsPage.UseVisualStyleBackColor = true;
            // 
            // btnPetsManagement
            // 
            btnPetsManagement.Location = new Point(239, 156);
            btnPetsManagement.Margin = new Padding(2, 2, 2, 2);
            btnPetsManagement.Name = "btnPetsManagement";
            btnPetsManagement.Size = new Size(186, 27);
            btnPetsManagement.TabIndex = 2;
            btnPetsManagement.Text = "Pets Management";
            btnPetsManagement.UseVisualStyleBackColor = true;
            // 
            // btnVisitsPage
            // 
            btnVisitsPage.Location = new Point(239, 188);
            btnVisitsPage.Margin = new Padding(2, 2, 2, 2);
            btnVisitsPage.Name = "btnVisitsPage";
            btnVisitsPage.Size = new Size(186, 27);
            btnVisitsPage.TabIndex = 3;
            btnVisitsPage.Text = "Visits";
            btnVisitsPage.UseVisualStyleBackColor = true;
            // 
            // btnMedicinePage
            // 
            btnMedicinePage.Location = new Point(239, 220);
            btnMedicinePage.Margin = new Padding(2, 2, 2, 2);
            btnMedicinePage.Name = "btnMedicinePage";
            btnMedicinePage.Size = new Size(186, 27);
            btnMedicinePage.TabIndex = 4;
            btnMedicinePage.Text = "Medicine Stock";
            btnMedicinePage.UseVisualStyleBackColor = true;
            // 
            // btnViewVisits
            // 
            btnViewVisits.Location = new Point(239, 251);
            btnViewVisits.Margin = new Padding(2);
            btnViewVisits.Name = "btnViewVisits";
            btnViewVisits.Size = new Size(186, 27);
            btnViewVisits.TabIndex = 5;
            btnViewVisits.Text = "View Visits";
            btnViewVisits.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnViewVisits);
            Controls.Add(btnMedicinePage);
            Controls.Add(btnVisitsPage);
            Controls.Add(btnPetsManagement);
            Controls.Add(btnClientsPage);
            Controls.Add(btnWorkersPage);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button btnWorkersPage;
        private Button btnClientsPage;
        private Button btnPetsManagement;
        private Button btnVisitsPage;
        private Button btnMedicinePage;
        private Button btnViewVisits;
    }
}