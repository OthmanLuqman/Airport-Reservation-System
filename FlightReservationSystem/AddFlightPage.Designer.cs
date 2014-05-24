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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(43, 317);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 65);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "اضافه کردن";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PlaneIDTextBox
            // 
            this.PlaneIDTextBox.Location = new System.Drawing.Point(124, 30);
            this.PlaneIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlaneIDTextBox.Name = "PlaneIDTextBox";
            this.PlaneIDTextBox.Size = new System.Drawing.Size(217, 27);
            this.PlaneIDTextBox.TabIndex = 1;
            // 
            // OriginAirportTextBox
            // 
            this.OriginAirportTextBox.Location = new System.Drawing.Point(124, 72);
            this.OriginAirportTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OriginAirportTextBox.Name = "OriginAirportTextBox";
            this.OriginAirportTextBox.Size = new System.Drawing.Size(217, 27);
            this.OriginAirportTextBox.TabIndex = 2;
            // 
            // DestinationAirportTextBox
            // 
            this.DestinationAirportTextBox.Location = new System.Drawing.Point(124, 112);
            this.DestinationAirportTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DestinationAirportTextBox.Name = "DestinationAirportTextBox";
            this.DestinationAirportTextBox.Size = new System.Drawing.Size(217, 27);
            this.DestinationAirportTextBox.TabIndex = 3;
            // 
            // DepartureTimePicker
            // 
            this.DepartureTimePicker.CustomFormat = "\"yyyy/MM/dd hh:mm:ss\"";
            this.DepartureTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureTimePicker.Location = new System.Drawing.Point(76, 158);
            this.DepartureTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DepartureTimePicker.Name = "DepartureTimePicker";
            this.DepartureTimePicker.Size = new System.Drawing.Size(265, 27);
            this.DepartureTimePicker.TabIndex = 6;
            this.DepartureTimePicker.ValueChanged += new System.EventHandler(this.DepartureTimePicker_ValueChanged);
            // 
            // ArrivalTimePicker
            // 
            this.ArrivalTimePicker.CustomFormat = "\"yyyy/MM/dd hh:mm:ss\"";
            this.ArrivalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ArrivalTimePicker.Location = new System.Drawing.Point(76, 206);
            this.ArrivalTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ArrivalTimePicker.Name = "ArrivalTimePicker";
            this.ArrivalTimePicker.Size = new System.Drawing.Size(265, 27);
            this.ArrivalTimePicker.TabIndex = 7;
            // 
            // PlaneLabel
            // 
            this.PlaneLabel.AutoSize = true;
            this.PlaneLabel.Location = new System.Drawing.Point(370, 35);
            this.PlaneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlaneLabel.Name = "PlaneLabel";
            this.PlaneLabel.Size = new System.Drawing.Size(37, 20);
            this.PlaneLabel.TabIndex = 8;
            this.PlaneLabel.Text = "هواپیما";
            // 
            // OriginLabel
            // 
            this.OriginLabel.AutoSize = true;
            this.OriginLabel.Location = new System.Drawing.Point(350, 77);
            this.OriginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OriginLabel.Name = "OriginLabel";
            this.OriginLabel.Size = new System.Drawing.Size(57, 20);
            this.OriginLabel.TabIndex = 9;
            this.OriginLabel.Text = "فرودگاه مبدا";
            // 
            // DestinaionLabel
            // 
            this.DestinaionLabel.AutoSize = true;
            this.DestinaionLabel.Location = new System.Drawing.Point(350, 117);
            this.DestinaionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DestinaionLabel.Name = "DestinaionLabel";
            this.DestinaionLabel.Size = new System.Drawing.Size(63, 20);
            this.DestinaionLabel.TabIndex = 10;
            this.DestinaionLabel.Text = "فرودگاه مقصد";
            // 
            // DepartureTimeLabel
            // 
            this.DepartureTimeLabel.AutoSize = true;
            this.DepartureTimeLabel.Location = new System.Drawing.Point(365, 165);
            this.DepartureTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartureTimeLabel.Name = "DepartureTimeLabel";
            this.DepartureTimeLabel.Size = new System.Drawing.Size(48, 20);
            this.DepartureTimeLabel.TabIndex = 11;
            this.DepartureTimeLabel.Text = "زمان پرواز";
            // 
            // ArrivalTimeLabel
            // 
            this.ArrivalTimeLabel.AutoSize = true;
            this.ArrivalTimeLabel.Location = new System.Drawing.Point(366, 211);
            this.ArrivalTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArrivalTimeLabel.Name = "ArrivalTimeLabel";
            this.ArrivalTimeLabel.Size = new System.Drawing.Size(47, 20);
            this.ArrivalTimeLabel.TabIndex = 12;
            this.ArrivalTimeLabel.Text = "زمان فرود";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(236, 252);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(105, 27);
            this.CostTextBox.TabIndex = 13;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(353, 252);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(60, 20);
            this.CostLabel.TabIndex = 14;
            this.CostLabel.Text = "قیمت (ریال)";
            // 
            // SearchPlaneIDButton
            // 
            this.SearchPlaneIDButton.Location = new System.Drawing.Point(43, 31);
            this.SearchPlaneIDButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchPlaneIDButton.Name = "SearchPlaneIDButton";
            this.SearchPlaneIDButton.Size = new System.Drawing.Size(73, 25);
            this.SearchPlaneIDButton.TabIndex = 15;
            this.SearchPlaneIDButton.Text = "جستجو";
            this.SearchPlaneIDButton.UseVisualStyleBackColor = true;
            this.SearchPlaneIDButton.Click += new System.EventHandler(this.SearchPlaneIDButton_Click);
            // 
            // SearchOriginAirportIDButton
            // 
            this.SearchOriginAirportIDButton.Location = new System.Drawing.Point(43, 72);
            this.SearchOriginAirportIDButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchOriginAirportIDButton.Name = "SearchOriginAirportIDButton";
            this.SearchOriginAirportIDButton.Size = new System.Drawing.Size(73, 27);
            this.SearchOriginAirportIDButton.TabIndex = 16;
            this.SearchOriginAirportIDButton.Text = "جستجو";
            this.SearchOriginAirportIDButton.UseVisualStyleBackColor = true;
            this.SearchOriginAirportIDButton.Click += new System.EventHandler(this.SearchOriginAirportIDButton_Click);
            // 
            // SearchDestinationAirportIDButton
            // 
            this.SearchDestinationAirportIDButton.Location = new System.Drawing.Point(43, 112);
            this.SearchDestinationAirportIDButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchDestinationAirportIDButton.Name = "SearchDestinationAirportIDButton";
            this.SearchDestinationAirportIDButton.Size = new System.Drawing.Size(73, 27);
            this.SearchDestinationAirportIDButton.TabIndex = 17;
            this.SearchDestinationAirportIDButton.Text = "جستجو";
            this.SearchDestinationAirportIDButton.UseVisualStyleBackColor = true;
            this.SearchDestinationAirportIDButton.Click += new System.EventHandler(this.SearchDestinationAirportIDButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchPlaneIDButton);
            this.groupBox1.Controls.Add(this.SearchDestinationAirportIDButton);
            this.groupBox1.Controls.Add(this.PlaneIDTextBox);
            this.groupBox1.Controls.Add(this.SearchOriginAirportIDButton);
            this.groupBox1.Controls.Add(this.OriginAirportTextBox);
            this.groupBox1.Controls.Add(this.DestinationAirportTextBox);
            this.groupBox1.Controls.Add(this.CostLabel);
            this.groupBox1.Controls.Add(this.DepartureTimePicker);
            this.groupBox1.Controls.Add(this.CostTextBox);
            this.groupBox1.Controls.Add(this.ArrivalTimePicker);
            this.groupBox1.Controls.Add(this.ArrivalTimeLabel);
            this.groupBox1.Controls.Add(this.PlaneLabel);
            this.groupBox1.Controls.Add(this.DepartureTimeLabel);
            this.groupBox1.Controls.Add(this.OriginLabel);
            this.groupBox1.Controls.Add(this.DestinaionLabel);
            this.groupBox1.Location = new System.Drawing.Point(260, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(431, 342);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات";
            // 
            // AddFlightPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(743, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddButton);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddFlightPage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}