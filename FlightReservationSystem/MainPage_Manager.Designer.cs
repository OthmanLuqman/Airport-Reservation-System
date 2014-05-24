namespace FlightReservationSystem
{
    partial class MainPage_Manager
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
            this.AddCompanyButton = new System.Windows.Forms.Button();
            this.AddAirportButton = new System.Windows.Forms.Button();
            this.AddStaffButton = new System.Windows.Forms.Button();
            this.CancelReservationButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddAirplaneButton = new System.Windows.Forms.Button();
            this.AddFlightButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DisplayAirplanesButton = new System.Windows.Forms.Button();
            this.DisplayStaffsButton = new System.Windows.Forms.Button();
            this.DisplayReservationsButton = new System.Windows.Forms.Button();
            this.DisplayCompaniesButton = new System.Windows.Forms.Button();
            this.DisplayAirportsButton = new System.Windows.Forms.Button();
            this.DisplayFlightsButton = new System.Windows.Forms.Button();
            this.UpdateTablesButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReserveButton
            // 
            this.ReserveButton.Location = new System.Drawing.Point(117, 24);
            this.ReserveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(186, 66);
            this.ReserveButton.TabIndex = 0;
            this.ReserveButton.Text = "رزرو بلیط";
            this.ReserveButton.UseVisualStyleBackColor = true;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // AddCompanyButton
            // 
            this.AddCompanyButton.Location = new System.Drawing.Point(21, 132);
            this.AddCompanyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCompanyButton.Name = "AddCompanyButton";
            this.AddCompanyButton.Size = new System.Drawing.Size(192, 58);
            this.AddCompanyButton.TabIndex = 1;
            this.AddCompanyButton.Text = "اضافه کردن شرکت";
            this.AddCompanyButton.UseVisualStyleBackColor = true;
            this.AddCompanyButton.Click += new System.EventHandler(this.AddCompanyButton_Click);
            // 
            // AddAirportButton
            // 
            this.AddAirportButton.Location = new System.Drawing.Point(21, 54);
            this.AddAirportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddAirportButton.Name = "AddAirportButton";
            this.AddAirportButton.Size = new System.Drawing.Size(192, 57);
            this.AddAirportButton.TabIndex = 2;
            this.AddAirportButton.Text = "اضافه کردن فرودگاه";
            this.AddAirportButton.UseVisualStyleBackColor = true;
            this.AddAirportButton.Click += new System.EventHandler(this.AddAirportButton_Click);
            // 
            // AddStaffButton
            // 
            this.AddStaffButton.Location = new System.Drawing.Point(236, 132);
            this.AddStaffButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddStaffButton.Name = "AddStaffButton";
            this.AddStaffButton.Size = new System.Drawing.Size(198, 58);
            this.AddStaffButton.TabIndex = 4;
            this.AddStaffButton.Text = "اضافه کردن کارمند";
            this.AddStaffButton.UseVisualStyleBackColor = true;
            this.AddStaffButton.Click += new System.EventHandler(this.AddStaffButton_Click);
            // 
            // CancelReservationButton
            // 
            this.CancelReservationButton.Location = new System.Drawing.Point(117, 113);
            this.CancelReservationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelReservationButton.Name = "CancelReservationButton";
            this.CancelReservationButton.Size = new System.Drawing.Size(186, 66);
            this.CancelReservationButton.TabIndex = 5;
            this.CancelReservationButton.Text = "لغو رزرو";
            this.CancelReservationButton.UseVisualStyleBackColor = true;
            this.CancelReservationButton.Click += new System.EventHandler(this.CancelReservationButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReserveButton);
            this.groupBox1.Controls.Add(this.CancelReservationButton);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(546, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(405, 204);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "رزرو";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddAirplaneButton);
            this.groupBox2.Controls.Add(this.AddFlightButton);
            this.groupBox2.Controls.Add(this.AddStaffButton);
            this.groupBox2.Controls.Add(this.AddAirportButton);
            this.groupBox2.Controls.Add(this.AddCompanyButton);
            this.groupBox2.Location = new System.Drawing.Point(34, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(442, 304);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مدیریت سیستم";
            // 
            // AddAirplaneButton
            // 
            this.AddAirplaneButton.Location = new System.Drawing.Point(129, 212);
            this.AddAirplaneButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddAirplaneButton.Name = "AddAirplaneButton";
            this.AddAirplaneButton.Size = new System.Drawing.Size(192, 61);
            this.AddAirplaneButton.TabIndex = 6;
            this.AddAirplaneButton.Text = "اضافه کردن هواپیما";
            this.AddAirplaneButton.UseVisualStyleBackColor = true;
            this.AddAirplaneButton.Click += new System.EventHandler(this.AddAirplaneButton_Click);
            // 
            // AddFlightButton
            // 
            this.AddFlightButton.Location = new System.Drawing.Point(236, 54);
            this.AddFlightButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddFlightButton.Name = "AddFlightButton";
            this.AddFlightButton.Size = new System.Drawing.Size(198, 57);
            this.AddFlightButton.TabIndex = 5;
            this.AddFlightButton.Text = "اضافه کردن پرواز";
            this.AddFlightButton.UseVisualStyleBackColor = true;
            this.AddFlightButton.Click += new System.EventHandler(this.AddFlightButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DisplayAirplanesButton);
            this.groupBox3.Controls.Add(this.DisplayStaffsButton);
            this.groupBox3.Controls.Add(this.DisplayReservationsButton);
            this.groupBox3.Controls.Add(this.DisplayCompaniesButton);
            this.groupBox3.Controls.Add(this.DisplayAirportsButton);
            this.groupBox3.Controls.Add(this.DisplayFlightsButton);
            this.groupBox3.Location = new System.Drawing.Point(546, 297);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(405, 239);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "گزارشات و ویرایش";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // DisplayAirplanesButton
            // 
            this.DisplayAirplanesButton.Location = new System.Drawing.Point(253, 99);
            this.DisplayAirplanesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DisplayAirplanesButton.Name = "DisplayAirplanesButton";
            this.DisplayAirplanesButton.Size = new System.Drawing.Size(142, 52);
            this.DisplayAirplanesButton.TabIndex = 5;
            this.DisplayAirplanesButton.Text = "هواپیماها";
            this.DisplayAirplanesButton.UseVisualStyleBackColor = true;
            this.DisplayAirplanesButton.Click += new System.EventHandler(this.DisplayAirplanesButton_Click);
            // 
            // DisplayStaffsButton
            // 
            this.DisplayStaffsButton.Location = new System.Drawing.Point(253, 161);
            this.DisplayStaffsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DisplayStaffsButton.Name = "DisplayStaffsButton";
            this.DisplayStaffsButton.Size = new System.Drawing.Size(142, 49);
            this.DisplayStaffsButton.TabIndex = 4;
            this.DisplayStaffsButton.Text = "کارمندها";
            this.DisplayStaffsButton.UseVisualStyleBackColor = true;
            this.DisplayStaffsButton.Click += new System.EventHandler(this.DisplayStaffsButton_Click);
            // 
            // DisplayReservationsButton
            // 
            this.DisplayReservationsButton.Location = new System.Drawing.Point(48, 36);
            this.DisplayReservationsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DisplayReservationsButton.Name = "DisplayReservationsButton";
            this.DisplayReservationsButton.Size = new System.Drawing.Size(142, 53);
            this.DisplayReservationsButton.TabIndex = 3;
            this.DisplayReservationsButton.Text = "رزروها";
            this.DisplayReservationsButton.UseVisualStyleBackColor = true;
            this.DisplayReservationsButton.Click += new System.EventHandler(this.DisplayReservationsButton_Click);
            // 
            // DisplayCompaniesButton
            // 
            this.DisplayCompaniesButton.Location = new System.Drawing.Point(48, 161);
            this.DisplayCompaniesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DisplayCompaniesButton.Name = "DisplayCompaniesButton";
            this.DisplayCompaniesButton.Size = new System.Drawing.Size(142, 49);
            this.DisplayCompaniesButton.TabIndex = 2;
            this.DisplayCompaniesButton.Text = "شرکت ها";
            this.DisplayCompaniesButton.UseVisualStyleBackColor = true;
            this.DisplayCompaniesButton.Click += new System.EventHandler(this.DisplayCompaniesButton_Click);
            // 
            // DisplayAirportsButton
            // 
            this.DisplayAirportsButton.Location = new System.Drawing.Point(48, 99);
            this.DisplayAirportsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DisplayAirportsButton.Name = "DisplayAirportsButton";
            this.DisplayAirportsButton.Size = new System.Drawing.Size(142, 52);
            this.DisplayAirportsButton.TabIndex = 1;
            this.DisplayAirportsButton.Text = "فرودگاه ها";
            this.DisplayAirportsButton.UseVisualStyleBackColor = true;
            this.DisplayAirportsButton.Click += new System.EventHandler(this.DisplayAirportsButton_Click);
            // 
            // DisplayFlightsButton
            // 
            this.DisplayFlightsButton.Location = new System.Drawing.Point(253, 36);
            this.DisplayFlightsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DisplayFlightsButton.Name = "DisplayFlightsButton";
            this.DisplayFlightsButton.Size = new System.Drawing.Size(142, 53);
            this.DisplayFlightsButton.TabIndex = 0;
            this.DisplayFlightsButton.Text = "پروازها";
            this.DisplayFlightsButton.UseVisualStyleBackColor = true;
            this.DisplayFlightsButton.Click += new System.EventHandler(this.DisplayFlightsButton_Click);
            // 
            // UpdateTablesButton
            // 
            this.UpdateTablesButton.Location = new System.Drawing.Point(70, 411);
            this.UpdateTablesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateTablesButton.Name = "UpdateTablesButton";
            this.UpdateTablesButton.Size = new System.Drawing.Size(267, 125);
            this.UpdateTablesButton.TabIndex = 10;
            this.UpdateTablesButton.Text = "بازگذاری مجدد اطلاعات";
            this.UpdateTablesButton.UseVisualStyleBackColor = true;
            this.UpdateTablesButton.Click += new System.EventHandler(this.UpdateTablesButton_Click);
            // 
            // MainPage_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 579);
            this.Controls.Add(this.UpdateTablesButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainPage_Manager";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "خوش آمدید";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.Button AddCompanyButton;
        private System.Windows.Forms.Button AddAirportButton;
        private System.Windows.Forms.Button AddStaffButton;
        private System.Windows.Forms.Button CancelReservationButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddFlightButton;
        private System.Windows.Forms.Button AddAirplaneButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DisplayAirportsButton;
        private System.Windows.Forms.Button DisplayFlightsButton;
        private System.Windows.Forms.Button DisplayStaffsButton;
        private System.Windows.Forms.Button DisplayReservationsButton;
        private System.Windows.Forms.Button DisplayCompaniesButton;
        private System.Windows.Forms.Button DisplayAirplanesButton;
        private System.Windows.Forms.Button UpdateTablesButton;
    }
}