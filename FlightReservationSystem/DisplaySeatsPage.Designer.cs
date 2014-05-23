namespace FlightReservationSystem
{
    partial class DisplaySeatsPage
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
            this.SeatsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SeatsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SeatsGridView
            // 
            this.SeatsGridView.AllowUserToDeleteRows = false;
            this.SeatsGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SeatsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeatsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeatsGridView.Location = new System.Drawing.Point(0, 0);
            this.SeatsGridView.Name = "SeatsGridView";
            this.SeatsGridView.ReadOnly = true;
            this.SeatsGridView.Size = new System.Drawing.Size(1113, 397);
            this.SeatsGridView.TabIndex = 0;
            // 
            // DisplaySeatsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 397);
            this.Controls.Add(this.SeatsGridView);
            this.Name = "DisplaySeatsPage";
            this.Text = "DisplaySeatsPage";
            this.Load += new System.EventHandler(this.DisplaySeatsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SeatsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SeatsGridView;

    }
}