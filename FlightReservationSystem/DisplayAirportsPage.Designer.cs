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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.AirportGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AirportGridView
            // 
            this.AirportGridView.AllowUserToAddRows = false;
            this.AirportGridView.AllowUserToDeleteRows = false;
            this.AirportGridView.AllowUserToOrderColumns = true;
            this.AirportGridView.AllowUserToResizeColumns = false;
            this.AirportGridView.AllowUserToResizeRows = false;
            this.AirportGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AirportGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AirportGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AirportGridView.Location = new System.Drawing.Point(0, 306);
            this.AirportGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AirportGridView.MultiSelect = false;
            this.AirportGridView.Name = "AirportGridView";
            this.AirportGridView.ReadOnly = true;
            this.AirportGridView.Size = new System.Drawing.Size(590, 231);
            this.AirportGridView.TabIndex = 1;
            // 
            // AirportNameTextBox
            // 
            this.AirportNameTextBox.Location = new System.Drawing.Point(67, 28);
            this.AirportNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AirportNameTextBox.Name = "AirportNameTextBox";
            this.AirportNameTextBox.Size = new System.Drawing.Size(132, 27);
            this.AirportNameTextBox.TabIndex = 2;
            // 
            // AirportCountryTextBox
            // 
            this.AirportCountryTextBox.Location = new System.Drawing.Point(67, 77);
            this.AirportCountryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AirportCountryTextBox.Name = "AirportCountryTextBox";
            this.AirportCountryTextBox.Size = new System.Drawing.Size(132, 27);
            this.AirportCountryTextBox.TabIndex = 3;
            // 
            // AirportCityTextBox
            // 
            this.AirportCityTextBox.Location = new System.Drawing.Point(67, 128);
            this.AirportCityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AirportCityTextBox.Name = "AirportCityTextBox";
            this.AirportCityTextBox.Size = new System.Drawing.Size(132, 27);
            this.AirportCityTextBox.TabIndex = 4;
            // 
            // AirportNameLabel
            // 
            this.AirportNameLabel.AutoSize = true;
            this.AirportNameLabel.Location = new System.Drawing.Point(231, 35);
            this.AirportNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AirportNameLabel.Name = "AirportNameLabel";
            this.AirportNameLabel.Size = new System.Drawing.Size(38, 20);
            this.AirportNameLabel.TabIndex = 5;
            this.AirportNameLabel.Text = "فرودگاه";
            // 
            // AirportCountryLabel
            // 
            this.AirportCountryLabel.AutoSize = true;
            this.AirportCountryLabel.Location = new System.Drawing.Point(207, 80);
            this.AirportCountryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AirportCountryLabel.Name = "AirportCountryLabel";
            this.AirportCountryLabel.Size = new System.Drawing.Size(62, 20);
            this.AirportCountryLabel.TabIndex = 6;
            this.AirportCountryLabel.Text = "کشور فرودگاه";
            this.AirportCountryLabel.Click += new System.EventHandler(this.AirportCountryLabel_Click);
            // 
            // AirportCityLabel
            // 
            this.AirportCityLabel.AutoSize = true;
            this.AirportCityLabel.Location = new System.Drawing.Point(211, 135);
            this.AirportCityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AirportCityLabel.Name = "AirportCityLabel";
            this.AirportCityLabel.Size = new System.Drawing.Size(58, 20);
            this.AirportCityLabel.TabIndex = 7;
            this.AirportCityLabel.Text = "شهر فرودگاه";
            // 
            // SearchAirportButton
            // 
            this.SearchAirportButton.Location = new System.Drawing.Point(58, 212);
            this.SearchAirportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchAirportButton.Name = "SearchAirportButton";
            this.SearchAirportButton.Size = new System.Drawing.Size(116, 68);
            this.SearchAirportButton.TabIndex = 8;
            this.SearchAirportButton.Text = "جستجو";
            this.SearchAirportButton.UseVisualStyleBackColor = true;
            this.SearchAirportButton.Click += new System.EventHandler(this.SearchAirportButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AirportCountryTextBox);
            this.groupBox1.Controls.Add(this.AirportNameTextBox);
            this.groupBox1.Controls.Add(this.AirportCityLabel);
            this.groupBox1.Controls.Add(this.AirportCityTextBox);
            this.groupBox1.Controls.Add(this.AirportCountryLabel);
            this.groupBox1.Controls.Add(this.AirportNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(240, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(293, 191);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات جستجو";
            // 
            // DisplayAirportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(590, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchAirportButton);
            this.Controls.Add(this.AirportGridView);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayAirportsPage";
            this.Load += new System.EventHandler(this.DisplayAirportsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AirportGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}