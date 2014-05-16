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
            this.AddCompanyButton = new System.Windows.Forms.Button();
            this.AddAirportButton = new System.Windows.Forms.Button();
            this.AddFlightButton = new System.Windows.Forms.Button();
            this.AddStaffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReserveButton
            // 
            this.ReserveButton.Location = new System.Drawing.Point(181, 93);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(75, 23);
            this.ReserveButton.TabIndex = 0;
            this.ReserveButton.Text = "Reserve";
            this.ReserveButton.UseVisualStyleBackColor = true;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // AddCompanyButton
            // 
            this.AddCompanyButton.Location = new System.Drawing.Point(146, 122);
            this.AddCompanyButton.Name = "AddCompanyButton";
            this.AddCompanyButton.Size = new System.Drawing.Size(110, 23);
            this.AddCompanyButton.TabIndex = 1;
            this.AddCompanyButton.Text = "Add Company";
            this.AddCompanyButton.UseVisualStyleBackColor = true;
            // 
            // AddAirportButton
            // 
            this.AddAirportButton.Location = new System.Drawing.Point(181, 173);
            this.AddAirportButton.Name = "AddAirportButton";
            this.AddAirportButton.Size = new System.Drawing.Size(75, 23);
            this.AddAirportButton.TabIndex = 2;
            this.AddAirportButton.Text = "Add Airport";
            this.AddAirportButton.UseVisualStyleBackColor = true;
            this.AddAirportButton.Click += new System.EventHandler(this.AddAirportButton_Click);
            // 
            // AddFlightButton
            // 
            this.AddFlightButton.Location = new System.Drawing.Point(181, 202);
            this.AddFlightButton.Name = "AddFlightButton";
            this.AddFlightButton.Size = new System.Drawing.Size(75, 23);
            this.AddFlightButton.TabIndex = 3;
            this.AddFlightButton.Text = "Add Flight";
            this.AddFlightButton.UseVisualStyleBackColor = true;
            // 
            // AddStaffButton
            // 
            this.AddStaffButton.Location = new System.Drawing.Point(78, 189);
            this.AddStaffButton.Name = "AddStaffButton";
            this.AddStaffButton.Size = new System.Drawing.Size(75, 23);
            this.AddStaffButton.TabIndex = 4;
            this.AddStaffButton.Text = "Add Staff";
            this.AddStaffButton.UseVisualStyleBackColor = true;
            this.AddStaffButton.Click += new System.EventHandler(this.AddStaffButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AddStaffButton);
            this.Controls.Add(this.AddFlightButton);
            this.Controls.Add(this.AddAirportButton);
            this.Controls.Add(this.AddCompanyButton);
            this.Controls.Add(this.ReserveButton);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.Button AddCompanyButton;
        private System.Windows.Forms.Button AddAirportButton;
        private System.Windows.Forms.Button AddFlightButton;
        private System.Windows.Forms.Button AddStaffButton;
    }
}