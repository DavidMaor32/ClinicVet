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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
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
            btnWorkersPage.Cursor = Cursors.Hand;
            btnWorkersPage.Location = new Point(319, 11);
            btnWorkersPage.Margin = new Padding(2);
            btnWorkersPage.Name = "btnWorkersPage";
            btnWorkersPage.Size = new Size(361, 88);
            btnWorkersPage.TabIndex = 0;
            btnWorkersPage.Text = "Workers Management";
            btnWorkersPage.UseVisualStyleBackColor = true;
            // 
            // btnClientsPage
            // 
            btnClientsPage.Cursor = Cursors.Hand;
            btnClientsPage.Location = new Point(319, 112);
            btnClientsPage.Margin = new Padding(2);
            btnClientsPage.Name = "btnClientsPage";
            btnClientsPage.Size = new Size(361, 80);
            btnClientsPage.TabIndex = 1;
            btnClientsPage.Text = "Clients Management";
            btnClientsPage.UseVisualStyleBackColor = true;
            // 
            // btnPetsManagement
            // 
            btnPetsManagement.Cursor = Cursors.Hand;
            btnPetsManagement.Location = new Point(319, 196);
            btnPetsManagement.Margin = new Padding(2);
            btnPetsManagement.Name = "btnPetsManagement";
            btnPetsManagement.Size = new Size(352, 84);
            btnPetsManagement.TabIndex = 2;
            btnPetsManagement.Text = "Pets Management";
            btnPetsManagement.UseVisualStyleBackColor = true;
            // 
            // btnVisitsPage
            // 
            btnVisitsPage.Cursor = Cursors.Hand;
            btnVisitsPage.Location = new Point(319, 295);
            btnVisitsPage.Margin = new Padding(2);
            btnVisitsPage.Name = "btnVisitsPage";
            btnVisitsPage.Size = new Size(352, 79);
            btnVisitsPage.TabIndex = 3;
            btnVisitsPage.Text = "Visits";
            btnVisitsPage.UseVisualStyleBackColor = true;
            // 
            // btnMedicinePage
            // 
            btnMedicinePage.Cursor = Cursors.Hand;
            btnMedicinePage.Location = new Point(319, 393);
            btnMedicinePage.Margin = new Padding(2);
            btnMedicinePage.Name = "btnMedicinePage";
            btnMedicinePage.Size = new Size(352, 76);
            btnMedicinePage.TabIndex = 4;
            btnMedicinePage.Text = "Medicine Stock";
            btnMedicinePage.UseVisualStyleBackColor = true;
            // 
            // btnViewVisits
            // 
            btnViewVisits.Cursor = Cursors.Hand;
            btnViewVisits.Location = new Point(319, 482);
            btnViewVisits.Margin = new Padding(2);
            btnViewVisits.Name = "btnViewVisits";
            btnViewVisits.Size = new Size(352, 81);
            btnViewVisits.TabIndex = 5;
            btnViewVisits.Text = "View Visits";
            btnViewVisits.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(995, 625);
            Controls.Add(btnViewVisits);
            Controls.Add(btnMedicinePage);
            Controls.Add(btnVisitsPage);
            Controls.Add(btnPetsManagement);
            Controls.Add(btnClientsPage);
            Controls.Add(btnWorkersPage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
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