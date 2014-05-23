namespace FlightReservationSystem
{
    partial class CancelReservationPage
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
            this.CancelReservationButton = new System.Windows.Forms.Button();
            this.ReservationIDTextBox = new System.Windows.Forms.TextBox();
            this.ReservationIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelReservationButton
            // 
            this.CancelReservationButton.Location = new System.Drawing.Point(95, 156);
            this.CancelReservationButton.Name = "CancelReservationButton";
            this.CancelReservationButton.Size = new System.Drawing.Size(116, 23);
            this.CancelReservationButton.TabIndex = 0;
            this.CancelReservationButton.Text = "Cancel Reservation";
            this.CancelReservationButton.UseVisualStyleBackColor = true;
            this.CancelReservationButton.Click += new System.EventHandler(this.CancelReservationButton_Click);
            // 
            // ReservationIDTextBox
            // 
            this.ReservationIDTextBox.Location = new System.Drawing.Point(99, 71);
            this.ReservationIDTextBox.Name = "ReservationIDTextBox";
            this.ReservationIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ReservationIDTextBox.TabIndex = 1;
            // 
            // ReservationIDLabel
            // 
            this.ReservationIDLabel.AutoSize = true;
            this.ReservationIDLabel.Location = new System.Drawing.Point(205, 78);
            this.ReservationIDLabel.Name = "ReservationIDLabel";
            this.ReservationIDLabel.Size = new System.Drawing.Size(75, 13);
            this.ReservationIDLabel.TabIndex = 2;
            this.ReservationIDLabel.Text = "ReservationID";
            // 
            // CancelReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ReservationIDLabel);
            this.Controls.Add(this.ReservationIDTextBox);
            this.Controls.Add(this.CancelReservationButton);
            this.Name = "CancelReservationPage";
            this.Text = "CancelReservationPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelReservationButton;
        private System.Windows.Forms.TextBox ReservationIDTextBox;
        private System.Windows.Forms.Label ReservationIDLabel;
    }
}