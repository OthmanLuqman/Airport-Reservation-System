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
            this.CancelReservationButton.Location = new System.Drawing.Point(105, 193);
            this.CancelReservationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelReservationButton.Name = "CancelReservationButton";
            this.CancelReservationButton.Size = new System.Drawing.Size(157, 76);
            this.CancelReservationButton.TabIndex = 0;
            this.CancelReservationButton.Text = "لغو";
            this.CancelReservationButton.UseVisualStyleBackColor = true;
            this.CancelReservationButton.Click += new System.EventHandler(this.CancelReservationButton_Click);
            // 
            // ReservationIDTextBox
            // 
            this.ReservationIDTextBox.Location = new System.Drawing.Point(75, 109);
            this.ReservationIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReservationIDTextBox.Name = "ReservationIDTextBox";
            this.ReservationIDTextBox.Size = new System.Drawing.Size(206, 27);
            this.ReservationIDTextBox.TabIndex = 1;
            // 
            // ReservationIDLabel
            // 
            this.ReservationIDLabel.AutoSize = true;
            this.ReservationIDLabel.Location = new System.Drawing.Point(289, 112);
            this.ReservationIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReservationIDLabel.Name = "ReservationIDLabel";
            this.ReservationIDLabel.Size = new System.Drawing.Size(52, 20);
            this.ReservationIDLabel.TabIndex = 2;
            this.ReservationIDLabel.Text = "شماره رزرو";
            // 
            // CancelReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(379, 402);
            this.Controls.Add(this.ReservationIDLabel);
            this.Controls.Add(this.ReservationIDTextBox);
            this.Controls.Add(this.CancelReservationButton);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CancelReservationPage";
            this.Text = "لغو رزرو";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelReservationButton;
        private System.Windows.Forms.TextBox ReservationIDTextBox;
        private System.Windows.Forms.Label ReservationIDLabel;
    }
}