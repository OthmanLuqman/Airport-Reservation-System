namespace FlightReservationSystem
{
    partial class AddFlightPage
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
            this.AddButton = new System.Windows.Forms.Button();
            this.PlaneIDTextBox = new System.Windows.Forms.TextBox();
            this.OriginAirportTextBox = new System.Windows.Forms.TextBox();
            this.DestinationAirportTextBox = new System.Windows.Forms.TextBox();
            this.DepartureTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ArrivalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(106, 176);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PlaneIDTextBox
            // 
            this.PlaneIDTextBox.Location = new System.Drawing.Point(96, 38);
            this.PlaneIDTextBox.Name = "PlaneIDTextBox";
            this.PlaneIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlaneIDTextBox.TabIndex = 1;
            // 
            // OriginAirportTextBox
            // 
            this.OriginAirportTextBox.Location = new System.Drawing.Point(96, 64);
            this.OriginAirportTextBox.Name = "OriginAirportTextBox";
            this.OriginAirportTextBox.Size = new System.Drawing.Size(100, 20);
            this.OriginAirportTextBox.TabIndex = 2;
            // 
            // DestinationAirportTextBox
            // 
            this.DestinationAirportTextBox.Location = new System.Drawing.Point(96, 90);
            this.DestinationAirportTextBox.Name = "DestinationAirportTextBox";
            this.DestinationAirportTextBox.Size = new System.Drawing.Size(100, 20);
            this.DestinationAirportTextBox.TabIndex = 3;
            // 
            // DepartureTimePicker
            // 
            this.DepartureTimePicker.CustomFormat = "\"yyyy/mm/dd hh:mm:ss\"";
            this.DepartureTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureTimePicker.Location = new System.Drawing.Point(50, 116);
            this.DepartureTimePicker.Name = "DepartureTimePicker";
            this.DepartureTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DepartureTimePicker.TabIndex = 6;
            this.DepartureTimePicker.ValueChanged += new System.EventHandler(this.DepartureTimePicker_ValueChanged);
            // 
            // ArrivalTimePicker
            // 
            this.ArrivalTimePicker.CustomFormat = "\"yyyy/mm/dd hh:mm:ss\"";
            this.ArrivalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ArrivalTimePicker.Location = new System.Drawing.Point(50, 142);
            this.ArrivalTimePicker.Name = "ArrivalTimePicker";
            this.ArrivalTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ArrivalTimePicker.TabIndex = 7;
            // 
            // AddFlightPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ArrivalTimePicker);
            this.Controls.Add(this.DepartureTimePicker);
            this.Controls.Add(this.DestinationAirportTextBox);
            this.Controls.Add(this.OriginAirportTextBox);
            this.Controls.Add(this.PlaneIDTextBox);
            this.Controls.Add(this.AddButton);
            this.Name = "AddFlightPage";
            this.Text = "AddFlightPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox PlaneIDTextBox;
        private System.Windows.Forms.TextBox OriginAirportTextBox;
        private System.Windows.Forms.TextBox DestinationAirportTextBox;
        private System.Windows.Forms.DateTimePicker DepartureTimePicker;
        private System.Windows.Forms.DateTimePicker ArrivalTimePicker;
    }
}