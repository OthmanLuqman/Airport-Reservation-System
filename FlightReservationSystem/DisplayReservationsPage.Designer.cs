namespace FlightReservationSystem
{
    partial class DisplayReservationsPage
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
            this.ReservationGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservationGridView
            // 
            this.ReservationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReservationGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ReservationGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReservationGridView.Location = new System.Drawing.Point(0, 212);
            this.ReservationGridView.Name = "ReservationGridView";
            this.ReservationGridView.Size = new System.Drawing.Size(919, 150);
            this.ReservationGridView.TabIndex = 2;
            // 
            // DisplayReservationsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 362);
            this.Controls.Add(this.ReservationGridView);
            this.Name = "DisplayReservationsPage";
            this.Text = "DisplayReservationsPage";
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView ReservationGridView;
    }
}