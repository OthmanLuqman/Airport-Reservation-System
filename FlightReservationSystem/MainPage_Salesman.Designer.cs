namespace FlightReservationSystem
{
    partial class MainPage
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
            this.ReserveButton = new System.Windows.Forms.Button();
            this.CancelReservationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReserveButton
            // 
            this.ReserveButton.Location = new System.Drawing.Point(70, 69);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(107, 23);
            this.ReserveButton.TabIndex = 1;
            this.ReserveButton.Text = "Reserve";
            this.ReserveButton.UseVisualStyleBackColor = true;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // CancelReservationButton
            // 
            this.CancelReservationButton.Location = new System.Drawing.Point(237, 69);
            this.CancelReservationButton.Name = "CancelReservationButton";
            this.CancelReservationButton.Size = new System.Drawing.Size(110, 23);
            this.CancelReservationButton.TabIndex = 6;
            this.CancelReservationButton.Text = "Cancel Reservation";
            this.CancelReservationButton.UseVisualStyleBackColor = true;
            this.CancelReservationButton.Click += new System.EventHandler(this.CancelReservationButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 309);
            this.Controls.Add(this.CancelReservationButton);
            this.Controls.Add(this.ReserveButton);
            this.Name = "MainPage";
            this.Text = "MainPage_Salesman";
            this.Load += new System.EventHandler(this.MainPage_Salesman_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.Button CancelReservationButton;
    }
}