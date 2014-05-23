namespace FlightReservationSystem
{
    partial class DisplayCompaniesPage
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
            this.CompanyGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyGridView
            // 
            this.CompanyGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompanyGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CompanyGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CompanyGridView.Location = new System.Drawing.Point(0, 199);
            this.CompanyGridView.Name = "CompanyGridView";
            this.CompanyGridView.ReadOnly = true;
            this.CompanyGridView.Size = new System.Drawing.Size(720, 150);
            this.CompanyGridView.TabIndex = 1;
            // 
            // DisplayCompaniesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 349);
            this.Controls.Add(this.CompanyGridView);
            this.Name = "DisplayCompaniesPage";
            this.Text = "DisplayCompaniesPage";
            this.Load += new System.EventHandler(this.DisplayCompaniesPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView CompanyGridView;
    }
}