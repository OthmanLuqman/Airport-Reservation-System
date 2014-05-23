using System.Windows.Forms;
namespace FlightReservationSystem
{
    partial class SelectFlightPage
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
            this.SuspendLayout();
            // 
            // FlightSelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 330);
            this.Name = "FlightSelectionPage";
            this.Text = "FlightSelectionPage";
            this.Load += new System.EventHandler(this.FlightSelectionPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            this.FlightGridView.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(OnRowHeaderMouseClick);

        }

        #endregion
    }
}