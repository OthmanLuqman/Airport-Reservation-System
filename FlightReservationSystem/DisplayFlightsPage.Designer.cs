using System.Windows.Forms;
namespace FlightReservationSystem
{
    partial class DisplayFlightsPage
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
        protected void InitializeComponent()
        {
            this.FlightGridView = new System.Windows.Forms.DataGridView();
            this.OriginCountryTextBox = new System.Windows.Forms.TextBox();
            this.OriginCountrytLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.OriginCityTextBox = new System.Windows.Forms.TextBox();
            this.OriginAirportNameTextBox = new System.Windows.Forms.TextBox();
            this.DestinationCountryTextBox = new System.Windows.Forms.TextBox();
            this.DestinationCityTextBox = new System.Windows.Forms.TextBox();
            this.DestinationAirportNameTextBox = new System.Windows.Forms.TextBox();
            this.DestinationCountryLabel = new System.Windows.Forms.Label();
            this.OriginCityLabel = new System.Windows.Forms.Label();
            this.DestinationCityLabel = new System.Windows.Forms.Label();
            this.OriginAirportNameLabel = new System.Windows.Forms.Label();
            this.DestinationAirportNameLabel = new System.Windows.Forms.Label();
            this.DepartureTimeLabel = new System.Windows.Forms.Label();
            this.ArrivalDateLabel = new System.Windows.Forms.Label();
            this.DepartureDateLabel = new System.Windows.Forms.Label();
            this.ArrivalTimeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ArrivalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartureTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartureDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ArrivalDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.FlightGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlightGridView
            // 
            this.FlightGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FlightGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FlightGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlightGridView.Location = new System.Drawing.Point(0, 284);
            this.FlightGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FlightGridView.Name = "FlightGridView";
            this.FlightGridView.Size = new System.Drawing.Size(1176, 231);
            this.FlightGridView.TabIndex = 0;
            this.FlightGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightGridView_CellEndEdit);
            // 
            // OriginCountryTextBox
            // 
            this.OriginCountryTextBox.Location = new System.Drawing.Point(7, 37);
            this.OriginCountryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OriginCountryTextBox.Name = "OriginCountryTextBox";
            this.OriginCountryTextBox.Size = new System.Drawing.Size(132, 27);
            this.OriginCountryTextBox.TabIndex = 1;
            // 
            // OriginCountrytLabel
            // 
            this.OriginCountrytLabel.AutoSize = true;
            this.OriginCountrytLabel.Location = new System.Drawing.Point(164, 39);
            this.OriginCountrytLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OriginCountrytLabel.Name = "OriginCountrytLabel";
            this.OriginCountrytLabel.Size = new System.Drawing.Size(49, 20);
            this.OriginCountrytLabel.TabIndex = 2;
            this.OriginCountrytLabel.Text = "کشور مبدا";
            this.OriginCountrytLabel.Click += new System.EventHandler(this.OriginAirportLabel_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(104, 204);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(150, 59);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "جستجو";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // OriginCityTextBox
            // 
            this.OriginCityTextBox.Location = new System.Drawing.Point(7, 84);
            this.OriginCityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OriginCityTextBox.Name = "OriginCityTextBox";
            this.OriginCityTextBox.Size = new System.Drawing.Size(132, 27);
            this.OriginCityTextBox.TabIndex = 4;
            // 
            // OriginAirportNameTextBox
            // 
            this.OriginAirportNameTextBox.Location = new System.Drawing.Point(7, 134);
            this.OriginAirportNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OriginAirportNameTextBox.Name = "OriginAirportNameTextBox";
            this.OriginAirportNameTextBox.Size = new System.Drawing.Size(132, 27);
            this.OriginAirportNameTextBox.TabIndex = 5;
            // 
            // DestinationCountryTextBox
            // 
            this.DestinationCountryTextBox.Location = new System.Drawing.Point(20, 36);
            this.DestinationCountryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DestinationCountryTextBox.Name = "DestinationCountryTextBox";
            this.DestinationCountryTextBox.Size = new System.Drawing.Size(132, 27);
            this.DestinationCountryTextBox.TabIndex = 7;
            // 
            // DestinationCityTextBox
            // 
            this.DestinationCityTextBox.Location = new System.Drawing.Point(20, 82);
            this.DestinationCityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DestinationCityTextBox.Name = "DestinationCityTextBox";
            this.DestinationCityTextBox.Size = new System.Drawing.Size(132, 27);
            this.DestinationCityTextBox.TabIndex = 8;
            // 
            // DestinationAirportNameTextBox
            // 
            this.DestinationAirportNameTextBox.Location = new System.Drawing.Point(20, 133);
            this.DestinationAirportNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DestinationAirportNameTextBox.Name = "DestinationAirportNameTextBox";
            this.DestinationAirportNameTextBox.Size = new System.Drawing.Size(132, 27);
            this.DestinationAirportNameTextBox.TabIndex = 9;
            // 
            // DestinationCountryLabel
            // 
            this.DestinationCountryLabel.AutoSize = true;
            this.DestinationCountryLabel.Location = new System.Drawing.Point(174, 43);
            this.DestinationCountryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DestinationCountryLabel.Name = "DestinationCountryLabel";
            this.DestinationCountryLabel.Size = new System.Drawing.Size(55, 20);
            this.DestinationCountryLabel.TabIndex = 12;
            this.DestinationCountryLabel.Text = "کشور مقصد";
            // 
            // OriginCityLabel
            // 
            this.OriginCityLabel.AutoSize = true;
            this.OriginCityLabel.Location = new System.Drawing.Point(168, 91);
            this.OriginCityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OriginCityLabel.Name = "OriginCityLabel";
            this.OriginCityLabel.Size = new System.Drawing.Size(45, 20);
            this.OriginCityLabel.TabIndex = 13;
            this.OriginCityLabel.Text = "شهر مبدا";
            // 
            // DestinationCityLabel
            // 
            this.DestinationCityLabel.AutoSize = true;
            this.DestinationCityLabel.Location = new System.Drawing.Point(174, 94);
            this.DestinationCityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DestinationCityLabel.Name = "DestinationCityLabel";
            this.DestinationCityLabel.Size = new System.Drawing.Size(51, 20);
            this.DestinationCityLabel.TabIndex = 14;
            this.DestinationCityLabel.Text = "شهر مقصد";
            // 
            // OriginAirportNameLabel
            // 
            this.OriginAirportNameLabel.AutoSize = true;
            this.OriginAirportNameLabel.Location = new System.Drawing.Point(156, 137);
            this.OriginAirportNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OriginAirportNameLabel.Name = "OriginAirportNameLabel";
            this.OriginAirportNameLabel.Size = new System.Drawing.Size(57, 20);
            this.OriginAirportNameLabel.TabIndex = 15;
            this.OriginAirportNameLabel.Text = "فرودگاه مبدا";
            // 
            // DestinationAirportNameLabel
            // 
            this.DestinationAirportNameLabel.AutoSize = true;
            this.DestinationAirportNameLabel.Location = new System.Drawing.Point(170, 140);
            this.DestinationAirportNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DestinationAirportNameLabel.Name = "DestinationAirportNameLabel";
            this.DestinationAirportNameLabel.Size = new System.Drawing.Size(63, 20);
            this.DestinationAirportNameLabel.TabIndex = 16;
            this.DestinationAirportNameLabel.Text = "فرودگاه مقصد";
            // 
            // DepartureTimeLabel
            // 
            this.DepartureTimeLabel.AutoSize = true;
            this.DepartureTimeLabel.Location = new System.Drawing.Point(414, 39);
            this.DepartureTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartureTimeLabel.Name = "DepartureTimeLabel";
            this.DepartureTimeLabel.Size = new System.Drawing.Size(54, 20);
            this.DepartureTimeLabel.TabIndex = 17;
            this.DepartureTimeLabel.Text = "ساعت پرواز";
            this.DepartureTimeLabel.Click += new System.EventHandler(this.DepartureTimeLabel_Click);
            // 
            // ArrivalDateLabel
            // 
            this.ArrivalDateLabel.AutoSize = true;
            this.ArrivalDateLabel.Location = new System.Drawing.Point(185, 81);
            this.ArrivalDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArrivalDateLabel.Name = "ArrivalDateLabel";
            this.ArrivalDateLabel.Size = new System.Drawing.Size(53, 20);
            this.ArrivalDateLabel.TabIndex = 18;
            this.ArrivalDateLabel.Text = "تاریخ رسید";
            // 
            // DepartureDateLabel
            // 
            this.DepartureDateLabel.AutoSize = true;
            this.DepartureDateLabel.Location = new System.Drawing.Point(418, 81);
            this.DepartureDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartureDateLabel.Name = "DepartureDateLabel";
            this.DepartureDateLabel.Size = new System.Drawing.Size(50, 20);
            this.DepartureDateLabel.TabIndex = 22;
            this.DepartureDateLabel.Text = "تاریخ پرواز";
            // 
            // ArrivalTimeLabel
            // 
            this.ArrivalTimeLabel.AutoSize = true;
            this.ArrivalTimeLabel.Location = new System.Drawing.Point(185, 39);
            this.ArrivalTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArrivalTimeLabel.Name = "ArrivalTimeLabel";
            this.ArrivalTimeLabel.Size = new System.Drawing.Size(57, 20);
            this.ArrivalTimeLabel.TabIndex = 25;
            this.ArrivalTimeLabel.Text = "ساعت رسید";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OriginCountryTextBox);
            this.groupBox1.Controls.Add(this.OriginCountrytLabel);
            this.groupBox1.Controls.Add(this.OriginCityTextBox);
            this.groupBox1.Controls.Add(this.OriginAirportNameTextBox);
            this.groupBox1.Controls.Add(this.OriginCityLabel);
            this.groupBox1.Controls.Add(this.OriginAirportNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(923, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 206);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مبدا";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DestinationCountryTextBox);
            this.groupBox2.Controls.Add(this.DestinationCityTextBox);
            this.groupBox2.Controls.Add(this.DestinationAirportNameTextBox);
            this.groupBox2.Controls.Add(this.DestinationCountryLabel);
            this.groupBox2.Controls.Add(this.DestinationCityLabel);
            this.groupBox2.Controls.Add(this.DestinationAirportNameLabel);
            this.groupBox2.Location = new System.Drawing.Point(646, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 206);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مقصد";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ArrivalDatePicker);
            this.groupBox3.Controls.Add(this.DepartureDatePicker);
            this.groupBox3.Controls.Add(this.DepartureTimePicker);
            this.groupBox3.Controls.Add(this.ArrivalTimePicker);
            this.groupBox3.Controls.Add(this.DepartureTimeLabel);
            this.groupBox3.Controls.Add(this.ArrivalTimeLabel);
            this.groupBox3.Controls.Add(this.ArrivalDateLabel);
            this.groupBox3.Controls.Add(this.DepartureDateLabel);
            this.groupBox3.Location = new System.Drawing.Point(104, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 183);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "زمان بندی";
            // 
            // ArrivalTimePicker
            // 
            this.ArrivalTimePicker.CustomFormat = "HH:mm:ss";
            this.ArrivalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ArrivalTimePicker.Location = new System.Drawing.Point(53, 32);
            this.ArrivalTimePicker.Name = "ArrivalTimePicker";
            this.ArrivalTimePicker.Size = new System.Drawing.Size(125, 27);
            this.ArrivalTimePicker.TabIndex = 26;
            this.ArrivalTimePicker.Value = new System.DateTime(2014, 5, 23, 12, 0, 0, 0);
            // 
            // DepartureTimePicker
            // 
            this.DepartureTimePicker.CustomFormat = "HH:mm:ss";
            this.DepartureTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureTimePicker.Location = new System.Drawing.Point(282, 38);
            this.DepartureTimePicker.Name = "DepartureTimePicker";
            this.DepartureTimePicker.Size = new System.Drawing.Size(125, 27);
            this.DepartureTimePicker.TabIndex = 27;
            this.DepartureTimePicker.Value = new System.DateTime(2014, 5, 23, 12, 0, 0, 0);
            // 
            // DepartureDatePicker
            // 
            this.DepartureDatePicker.CustomFormat = "yyyy/MM/dd";
            this.DepartureDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureDatePicker.Location = new System.Drawing.Point(282, 77);
            this.DepartureDatePicker.Name = "DepartureDatePicker";
            this.DepartureDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DepartureDatePicker.Size = new System.Drawing.Size(125, 27);
            this.DepartureDatePicker.TabIndex = 28;
            this.DepartureDatePicker.Value = new System.DateTime(2014, 1, 1, 22, 49, 0, 0);
            // 
            // ArrivalDatePicker
            // 
            this.ArrivalDatePicker.CustomFormat = "yyyy/MM/dd";
            this.ArrivalDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ArrivalDatePicker.Location = new System.Drawing.Point(53, 74);
            this.ArrivalDatePicker.Name = "ArrivalDatePicker";
            this.ArrivalDatePicker.Size = new System.Drawing.Size(125, 27);
            this.ArrivalDatePicker.TabIndex = 29;
            this.ArrivalDatePicker.Value = new System.DateTime(2014, 1, 1, 22, 50, 0, 0);
            // 
            // DisplayFlightsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1176, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.FlightGridView);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayFlightsPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "DisplayFlights";
            this.Load += new System.EventHandler(this.DisplayFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox OriginCountryTextBox;
        private System.Windows.Forms.Label OriginCountrytLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox OriginCityTextBox;
        private System.Windows.Forms.TextBox OriginAirportNameTextBox;
        private System.Windows.Forms.TextBox DestinationCountryTextBox;
        private System.Windows.Forms.TextBox DestinationCityTextBox;
        private System.Windows.Forms.TextBox DestinationAirportNameTextBox;
        private System.Windows.Forms.Label DestinationCountryLabel;
        private System.Windows.Forms.Label OriginCityLabel;
        private System.Windows.Forms.Label DestinationCityLabel;
        private System.Windows.Forms.Label OriginAirportNameLabel;
        private System.Windows.Forms.Label DestinationAirportNameLabel;
        private System.Windows.Forms.Label DepartureTimeLabel;
        private System.Windows.Forms.Label ArrivalDateLabel;
        private System.Windows.Forms.Label DepartureDateLabel;
        private System.Windows.Forms.Label ArrivalTimeLabel;
        protected internal System.Windows.Forms.DataGridView FlightGridView;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DateTimePicker ArrivalDatePicker;
        private DateTimePicker DepartureDatePicker;
        private DateTimePicker DepartureTimePicker;
        private DateTimePicker ArrivalTimePicker;
    }
}