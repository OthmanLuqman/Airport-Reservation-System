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
            this.PlaneLabel = new System.Windows.Forms.Label();
            this.OriginLabel = new System.Windows.Forms.Label();
            this.DestinaionLabel = new System.Windows.Forms.Label();
            this.DepartureTimeLabel = new System.Windows.Forms.Label();
            this.ArrivalTimeLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.SearchPlaneIDButton = new System.Windows.Forms.Button();
            this.SearchOriginAirportIDButton = new System.Windows.Forms.Button();
            this.SearchDestinationAirportIDButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(96, 213);
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
            // PlaneLabel
            // 
            this.PlaneLabel.AutoSize = true;
            this.PlaneLabel.Location = new System.Drawing.Point(202, 41);
            this.PlaneLabel.Name = "PlaneLabel";
            this.PlaneLabel.Size = new System.Drawing.Size(34, 13);
            this.PlaneLabel.TabIndex = 8;
            this.PlaneLabel.Text = "Plane";
            // 
            // OriginLabel
            // 
            this.OriginLabel.AutoSize = true;
            this.OriginLabel.Location = new System.Drawing.Point(202, 67);
            this.OriginLabel.Name = "OriginLabel";
            this.OriginLabel.Size = new System.Drawing.Size(67, 13);
            this.OriginLabel.TabIndex = 9;
            this.OriginLabel.Text = "Origin Airport";
            // 
            // DestinaionLabel
            // 
            this.DestinaionLabel.AutoSize = true;
            this.DestinaionLabel.Location = new System.Drawing.Point(202, 93);
            this.DestinaionLabel.Name = "DestinaionLabel";
            this.DestinaionLabel.Size = new System.Drawing.Size(93, 13);
            this.DestinaionLabel.TabIndex = 10;
            this.DestinaionLabel.Text = "Destination Airport";
            // 
            // DepartureTimeLabel
            // 
            this.DepartureTimeLabel.AutoSize = true;
            this.DepartureTimeLabel.Location = new System.Drawing.Point(256, 122);
            this.DepartureTimeLabel.Name = "DepartureTimeLabel";
            this.DepartureTimeLabel.Size = new System.Drawing.Size(80, 13);
            this.DepartureTimeLabel.TabIndex = 11;
            this.DepartureTimeLabel.Text = "Departure Time";
            // 
            // ArrivalTimeLabel
            // 
            this.ArrivalTimeLabel.AutoSize = true;
            this.ArrivalTimeLabel.Location = new System.Drawing.Point(256, 148);
            this.ArrivalTimeLabel.Name = "ArrivalTimeLabel";
            this.ArrivalTimeLabel.Size = new System.Drawing.Size(62, 13);
            this.ArrivalTimeLabel.TabIndex = 12;
            this.ArrivalTimeLabel.Text = "Arrival Time";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(82, 168);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 13;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(188, 171);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(28, 13);
            this.CostLabel.TabIndex = 14;
            this.CostLabel.Text = "Cost";
            // 
            // SearchPlaneIDButton
            // 
            this.SearchPlaneIDButton.Location = new System.Drawing.Point(63, 35);
            this.SearchPlaneIDButton.Name = "SearchPlaneIDButton";
            this.SearchPlaneIDButton.Size = new System.Drawing.Size(27, 23);
            this.SearchPlaneIDButton.TabIndex = 15;
            this.SearchPlaneIDButton.Text = "ج";
            this.SearchPlaneIDButton.UseVisualStyleBackColor = true;
            this.SearchPlaneIDButton.Click += new System.EventHandler(this.SearchPlaneIDButton_Click);
            // 
            // SearchOriginAirportIDButton
            // 
            this.SearchOriginAirportIDButton.Location = new System.Drawing.Point(63, 61);
            this.SearchOriginAirportIDButton.Name = "SearchOriginAirportIDButton";
            this.SearchOriginAirportIDButton.Size = new System.Drawing.Size(27, 23);
            this.SearchOriginAirportIDButton.TabIndex = 16;
            this.SearchOriginAirportIDButton.Text = "ج";
            this.SearchOriginAirportIDButton.UseVisualStyleBackColor = true;
            this.SearchOriginAirportIDButton.Click += new System.EventHandler(this.SearchOriginAirportIDButton_Click);
            // 
            // SearchDestinationAirportIDButton
            // 
            this.SearchDestinationAirportIDButton.Location = new System.Drawing.Point(63, 88);
            this.SearchDestinationAirportIDButton.Name = "SearchDestinationAirportIDButton";
            this.SearchDestinationAirportIDButton.Size = new System.Drawing.Size(27, 23);
            this.SearchDestinationAirportIDButton.TabIndex = 17;
            this.SearchDestinationAirportIDButton.Text = "ج";
            this.SearchDestinationAirportIDButton.UseVisualStyleBackColor = true;
            this.SearchDestinationAirportIDButton.Click += new System.EventHandler(this.SearchDestinationAirportIDButton_Click);
            // 
            // AddFlightPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 261);
            this.Controls.Add(this.SearchDestinationAirportIDButton);
            this.Controls.Add(this.SearchOriginAirportIDButton);
            this.Controls.Add(this.SearchPlaneIDButton);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.ArrivalTimeLabel);
            this.Controls.Add(this.DepartureTimeLabel);
            this.Controls.Add(this.DestinaionLabel);
            this.Controls.Add(this.OriginLabel);
            this.Controls.Add(this.PlaneLabel);
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
        private System.Windows.Forms.Label PlaneLabel;
        private System.Windows.Forms.Label OriginLabel;
        private System.Windows.Forms.Label DestinaionLabel;
        private System.Windows.Forms.Label DepartureTimeLabel;
        private System.Windows.Forms.Label ArrivalTimeLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Button SearchPlaneIDButton;
        private System.Windows.Forms.Button SearchOriginAirportIDButton;
        private System.Windows.Forms.Button SearchDestinationAirportIDButton;
    }
}