namespace FlightReservationSystem
{
    partial class DisplayAirportsPage
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
            this.AirportGridView = new System.Windows.Forms.DataGridView();
            this.AirportNameTextBox = new System.Windows.Forms.TextBox();
            this.AirportCountryTextBox = new System.Windows.Forms.TextBox();
            this.AirportCityTextBox = new System.Windows.Forms.TextBox();
            this.AirportNameLabel = new System.Windows.Forms.Label();
            this.AirportCountryLabel = new System.Windows.Forms.Label();
            this.AirportCityLabel = new System.Windows.Forms.Label();
            this.SearchAirportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AirportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightGridView
            // 
            this.AirportGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AirportGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AirportGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AirportGridView.Location = new System.Drawing.Point(0, 199);
            this.AirportGridView.Name = "FlightGridView";
            this.AirportGridView.ReadOnly = true;
            this.AirportGridView.Size = new System.Drawing.Size(537, 150);
            this.AirportGridView.TabIndex = 1;
            // 
            // AirportNameTextBox
            // 
            this.AirportNameTextBox.Location = new System.Drawing.Point(310, 34);
            this.AirportNameTextBox.Name = "AirportNameTextBox";
            this.AirportNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AirportNameTextBox.TabIndex = 2;
            // 
            // AirportCountryTextBox
            // 
            this.AirportCountryTextBox.Location = new System.Drawing.Point(310, 69);
            this.AirportCountryTextBox.Name = "AirportCountryTextBox";
            this.AirportCountryTextBox.Size = new System.Drawing.Size(100, 20);
            this.AirportCountryTextBox.TabIndex = 3;
            // 
            // AirportCityTextBox
            // 
            this.AirportCityTextBox.Location = new System.Drawing.Point(310, 110);
            this.AirportCityTextBox.Name = "AirportCityTextBox";
            this.AirportCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.AirportCityTextBox.TabIndex = 4;
            // 
            // AirportNameLabel
            // 
            this.AirportNameLabel.AutoSize = true;
            this.AirportNameLabel.Location = new System.Drawing.Point(439, 37);
            this.AirportNameLabel.Name = "AirportNameLabel";
            this.AirportNameLabel.Size = new System.Drawing.Size(65, 13);
            this.AirportNameLabel.TabIndex = 5;
            this.AirportNameLabel.Text = "AirportName";
            // 
            // AirportCountryLabel
            // 
            this.AirportCountryLabel.AutoSize = true;
            this.AirportCountryLabel.Location = new System.Drawing.Point(439, 76);
            this.AirportCountryLabel.Name = "AirportCountryLabel";
            this.AirportCountryLabel.Size = new System.Drawing.Size(73, 13);
            this.AirportCountryLabel.TabIndex = 6;
            this.AirportCountryLabel.Text = "AirportCountry";
            // 
            // AirportCityLabel
            // 
            this.AirportCityLabel.AutoSize = true;
            this.AirportCityLabel.Location = new System.Drawing.Point(439, 113);
            this.AirportCityLabel.Name = "AirportCityLabel";
            this.AirportCityLabel.Size = new System.Drawing.Size(54, 13);
            this.AirportCityLabel.TabIndex = 7;
            this.AirportCityLabel.Text = "AirportCity";
            // 
            // SearchAirportButton
            // 
            this.SearchAirportButton.Location = new System.Drawing.Point(77, 148);
            this.SearchAirportButton.Name = "SearchAirportButton";
            this.SearchAirportButton.Size = new System.Drawing.Size(75, 23);
            this.SearchAirportButton.TabIndex = 8;
            this.SearchAirportButton.Text = "Search";
            this.SearchAirportButton.UseVisualStyleBackColor = true;
            this.SearchAirportButton.Click += new System.EventHandler(this.SearchAirportButton_Click);
            // 
            // DisplayAirportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 349);
            this.Controls.Add(this.SearchAirportButton);
            this.Controls.Add(this.AirportCityLabel);
            this.Controls.Add(this.AirportCountryLabel);
            this.Controls.Add(this.AirportNameLabel);
            this.Controls.Add(this.AirportCityTextBox);
            this.Controls.Add(this.AirportCountryTextBox);
            this.Controls.Add(this.AirportNameTextBox);
            this.Controls.Add(this.AirportGridView);
            this.Name = "DisplayAirportsPage";
            this.Text = "DisplayAirportsPage";
            this.Load += new System.EventHandler(this.DisplayAirportsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AirportGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView AirportGridView;
        private System.Windows.Forms.TextBox AirportNameTextBox;
        private System.Windows.Forms.TextBox AirportCountryTextBox;
        private System.Windows.Forms.TextBox AirportCityTextBox;
        private System.Windows.Forms.Label AirportNameLabel;
        private System.Windows.Forms.Label AirportCountryLabel;
        private System.Windows.Forms.Label AirportCityLabel;
        private System.Windows.Forms.Button SearchAirportButton;
    }
}