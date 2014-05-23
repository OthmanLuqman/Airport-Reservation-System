namespace FlightReservationSystem
{
    partial class DisplayAirplanesPage
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
            this.PlanesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PlanesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanesGridView
            // 
            this.PlanesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlanesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PlanesGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlanesGridView.Location = new System.Drawing.Point(0, 201);
            this.PlanesGridView.Name = "PlanesGridView";
            this.PlanesGridView.ReadOnly = true;
            this.PlanesGridView.Size = new System.Drawing.Size(668, 150);
            this.PlanesGridView.TabIndex = 2;
            // 
            // DisplayAirPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 351);
            this.Controls.Add(this.PlanesGridView);
            this.Name = "DisplayAirPlanes";
            this.Text = "DisplayAirPlanes";
            this.Load += new System.EventHandler(this.DisplayAirPlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlanesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView PlanesGridView;
    }
}