namespace ClinicVet.UI.Pages.VisitsManagementPage
{
    partial class VisitsManagementPage
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
            visitsGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)visitsGridView).BeginInit();
            SuspendLayout();
            // 
            // visitsGridView
            // 
            visitsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visitsGridView.Dock = DockStyle.Fill;
            visitsGridView.Location = new Point(0, 0);
            visitsGridView.Name = "visitsGridView";
            visitsGridView.RowHeadersWidth = 51;
            visitsGridView.Size = new Size(875, 503);
            visitsGridView.TabIndex = 0;
            // 
            // VisitsManagementPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 503);
            Controls.Add(visitsGridView);
            Name = "VisitsManagementPage";
            Text = "VisitsManagementPage";
            ((System.ComponentModel.ISupportInitialize)visitsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView visitsGridView;
    }
}