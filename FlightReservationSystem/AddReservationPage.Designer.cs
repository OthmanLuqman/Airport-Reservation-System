namespace FlightReservationSystem
{
    partial class AddReservationPage
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
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.NationalCodeTextBox = new System.Windows.Forms.TextBox();
            this.FlightIDTextBox = new System.Windows.Forms.TextBox();
            this.ReserveButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.NationalCodeLabel = new System.Windows.Forms.Label();
            this.FlightIDLabel = new System.Windows.Forms.Label();
            this.SeatNumberTestBox = new System.Windows.Forms.TextBox();
            this.SeatNumberLabel = new System.Windows.Forms.Label();
            this.FlightSearchButton = new System.Windows.Forms.Button();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchSeatsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(63, 69);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(132, 27);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(63, 110);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(132, 27);
            this.LastNameTextBox.TabIndex = 1;
            this.LastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(63, 149);
            this.AgeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(132, 27);
            this.AgeTextBox.TabIndex = 2;
            this.AgeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NationalCodeTextBox
            // 
            this.NationalCodeTextBox.Location = new System.Drawing.Point(63, 233);
            this.NationalCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NationalCodeTextBox.Name = "NationalCodeTextBox";
            this.NationalCodeTextBox.Size = new System.Drawing.Size(132, 27);
            this.NationalCodeTextBox.TabIndex = 4;
            // 
            // FlightIDTextBox
            // 
            this.FlightIDTextBox.Location = new System.Drawing.Point(154, 61);
            this.FlightIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FlightIDTextBox.Name = "FlightIDTextBox";
            this.FlightIDTextBox.Size = new System.Drawing.Size(132, 27);
            this.FlightIDTextBox.TabIndex = 5;
            // 
            // ReserveButton
            // 
            this.ReserveButton.Location = new System.Drawing.Point(489, 315);
            this.ReserveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(164, 88);
            this.ReserveButton.TabIndex = 8;
            this.ReserveButton.Text = "رزرو";
            this.ReserveButton.UseVisualStyleBackColor = true;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(243, 76);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(19, 20);
            this.FirstNameLabel.TabIndex = 7;
            this.FirstNameLabel.Text = "نام";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(203, 113);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(59, 20);
            this.LastNameLabel.TabIndex = 8;
            this.LastNameLabel.Text = "نام خانوادگی";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(238, 152);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(24, 20);
            this.AgeLabel.TabIndex = 9;
            this.AgeLabel.Text = "سن";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(221, 200);
            this.SexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(41, 20);
            this.SexLabel.TabIndex = 3;
            this.SexLabel.Text = "جنسیت";
            // 
            // NationalCodeLabel
            // 
            this.NationalCodeLabel.AutoSize = true;
            this.NationalCodeLabel.Location = new System.Drawing.Point(227, 236);
            this.NationalCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NationalCodeLabel.Name = "NationalCodeLabel";
            this.NationalCodeLabel.Size = new System.Drawing.Size(35, 20);
            this.NationalCodeLabel.TabIndex = 11;
            this.NationalCodeLabel.Text = "کدملی";
            // 
            // FlightIDLabel
            // 
            this.FlightIDLabel.AutoSize = true;
            this.FlightIDLabel.Location = new System.Drawing.Point(294, 64);
            this.FlightIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FlightIDLabel.Name = "FlightIDLabel";
            this.FlightIDLabel.Size = new System.Drawing.Size(54, 20);
            this.FlightIDLabel.TabIndex = 12;
            this.FlightIDLabel.Text = "شماره پرواز";
            // 
            // SeatNumberTestBox
            // 
            this.SeatNumberTestBox.Location = new System.Drawing.Point(154, 118);
            this.SeatNumberTestBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SeatNumberTestBox.Name = "SeatNumberTestBox";
            this.SeatNumberTestBox.Size = new System.Drawing.Size(132, 27);
            this.SeatNumberTestBox.TabIndex = 13;
            // 
            // SeatNumberLabel
            // 
            this.SeatNumberLabel.AutoSize = true;
            this.SeatNumberLabel.Location = new System.Drawing.Point(285, 121);
            this.SeatNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SeatNumberLabel.Name = "SeatNumberLabel";
            this.SeatNumberLabel.Size = new System.Drawing.Size(63, 20);
            this.SeatNumberLabel.TabIndex = 7;
            this.SeatNumberLabel.Text = "شماره صندلی";
            // 
            // FlightSearchButton
            // 
            this.FlightSearchButton.Location = new System.Drawing.Point(62, 61);
            this.FlightSearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FlightSearchButton.Name = "FlightSearchButton";
            this.FlightSearchButton.Size = new System.Drawing.Size(84, 27);
            this.FlightSearchButton.TabIndex = 6;
            this.FlightSearchButton.Text = "جستجو";
            this.FlightSearchButton.UseVisualStyleBackColor = true;
            this.FlightSearchButton.Click += new System.EventHandler(this.FlightSearchButton_Click);
            // 
            // SexComboBox
            // 
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "مرد",
            "زن"});
            this.SexComboBox.Location = new System.Drawing.Point(63, 192);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SexComboBox.Size = new System.Drawing.Size(132, 28);
            this.SexComboBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FirstNameTextBox);
            this.groupBox1.Controls.Add(this.SexComboBox);
            this.groupBox1.Controls.Add(this.LastNameTextBox);
            this.groupBox1.Controls.Add(this.AgeTextBox);
            this.groupBox1.Controls.Add(this.NationalCodeTextBox);
            this.groupBox1.Controls.Add(this.FirstNameLabel);
            this.groupBox1.Controls.Add(this.LastNameLabel);
            this.groupBox1.Controls.Add(this.NationalCodeLabel);
            this.groupBox1.Controls.Add(this.AgeLabel);
            this.groupBox1.Controls.Add(this.SexLabel);
            this.groupBox1.Location = new System.Drawing.Point(53, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 329);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات مسافر";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchSeatsButton);
            this.groupBox2.Controls.Add(this.FlightIDTextBox);
            this.groupBox2.Controls.Add(this.FlightIDLabel);
            this.groupBox2.Controls.Add(this.FlightSearchButton);
            this.groupBox2.Controls.Add(this.SeatNumberTestBox);
            this.groupBox2.Controls.Add(this.SeatNumberLabel);
            this.groupBox2.Location = new System.Drawing.Point(387, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 193);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مشخصات پرواز";
            // 
            // SearchSeatsButton
            // 
            this.SearchSeatsButton.Location = new System.Drawing.Point(62, 118);
            this.SearchSeatsButton.Name = "SearchSeatsButton";
            this.SearchSeatsButton.Size = new System.Drawing.Size(84, 27);
            this.SearchSeatsButton.TabIndex = 14;
            this.SearchSeatsButton.Text = "جستجو";
            this.SearchSeatsButton.UseVisualStyleBackColor = true;
            this.SearchSeatsButton.Click += new System.EventHandler(this.SearchSeatsButton_Click);
            // 
            // AddReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(813, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReserveButton);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddReservationPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "رزرو بلیط";
            this.Load += new System.EventHandler(this.ReservationPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox NationalCodeTextBox;
        private System.Windows.Forms.TextBox FlightIDTextBox;
        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label NationalCodeLabel;
        private System.Windows.Forms.Label FlightIDLabel;
        private System.Windows.Forms.TextBox SeatNumberTestBox;
        private System.Windows.Forms.Label SeatNumberLabel;
        private System.Windows.Forms.Button FlightSearchButton;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SearchSeatsButton;
    }
}