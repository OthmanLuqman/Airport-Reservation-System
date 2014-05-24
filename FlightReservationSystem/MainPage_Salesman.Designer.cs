namespace FlightReservationSystem
{
    partial class MainPage_Salesman
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
            this.UpdateTablesButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DisplayAirplanesButton = new System.Windows.Forms.Button();
            this.DisplayReservationsButton = new System.Windows.Forms.Button();
            this.DisplayAirportsButton = new System.Windows.Forms.Button();
            this.DisplayFlightsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReserveButton = new System.Windows.Forms.Button();
            this.CancelReservationButton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateTablesButton
            // 
            this.UpdateTablesButton.Location = new System.Drawing.Point(98, 404);
            this.UpdateTablesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateTablesButton.Name = "UpdateTablesButton";
            this.UpdateTablesButton.Size = new System.Drawing.Size(267, 125);
            this.UpdateTablesButton.TabIndex = 13;
            this.UpdateTablesButton.Text = "بازگذاری مجدد اطلاعات";
            this.UpdateTablesButton.UseVisualStyleBackColor = true;
            this.UpdateTablesButton.Click += new System.EventHandler(this.UpdateTablesButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DisplayAirplanesButton);
            this.groupBox3.Controls.Add(this.DisplayReservationsButton);
            this.groupBox3.Controls.Add(this.DisplayAirportsButton);
            this.groupBox3.Controls.Add(this.DisplayFlightsButton);
            this.groupBox3.Location = new System.Drawing.Point(554, 305);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(405, 202);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "گزارشات و ویرایش";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReserveButton);
            this.groupBox1.Controls.Add(this.CancelReservationButton);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(554, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(405, 204);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "رزرو";
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
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click_1);
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
            this.CancelReservationButton.Click += new System.EventHandler(this.CancelReservationButton_Click_1);
            // 
            // MainPage_Salesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1051, 624);
            this.Controls.Add(this.UpdateTablesButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainPage_Salesman";
            this.Text = "";
            this.Load += new System.EventHandler(this.MainPage_Salesman_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpdateTablesButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DisplayAirplanesButton;
        private System.Windows.Forms.Button DisplayReservationsButton;
        private System.Windows.Forms.Button DisplayAirportsButton;
        private System.Windows.Forms.Button DisplayFlightsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.Button CancelReservationButton;

    }
}