namespace FlightReservationSystem
{
    partial class ReservationPage
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
            this.GenderTextBox = new System.Windows.Forms.TextBox();
            this.NationalCodeTextBox = new System.Windows.Forms.TextBox();
            this.FlightIDTextBox = new System.Windows.Forms.TextBox();
            this.ReserveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(172, 48);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.Text = "iman";
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(172, 74);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 1;
            this.LastNameTextBox.Text = "jk";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(172, 100);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 2;
            this.AgeTextBox.Text = "20";
            // 
            // GenderTextBox
            // 
            this.GenderTextBox.Location = new System.Drawing.Point(172, 126);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenderTextBox.TabIndex = 3;
            this.GenderTextBox.Text = "male";
            // 
            // NationalCodeTextBox
            // 
            this.NationalCodeTextBox.Location = new System.Drawing.Point(172, 152);
            this.NationalCodeTextBox.Name = "NationalCodeTextBox";
            this.NationalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.NationalCodeTextBox.TabIndex = 4;
            this.NationalCodeTextBox.Text = "256";
            // 
            // FlightIDTextBox
            // 
            this.FlightIDTextBox.Location = new System.Drawing.Point(36, 48);
            this.FlightIDTextBox.Name = "FlightIDTextBox";
            this.FlightIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.FlightIDTextBox.TabIndex = 5;
            this.FlightIDTextBox.Text = "00000000-0000-0000-0000-000000000001";
            // 
            // ReserveButton
            // 
            this.ReserveButton.Location = new System.Drawing.Point(23, 136);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(86, 35);
            this.ReserveButton.TabIndex = 6;
            this.ReserveButton.Text = "Reserve";
            this.ReserveButton.UseVisualStyleBackColor = true;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // ReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ReserveButton);
            this.Controls.Add(this.FlightIDTextBox);
            this.Controls.Add(this.NationalCodeTextBox);
            this.Controls.Add(this.GenderTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Name = "ReservationPage";
            this.Text = "ReservationPage";
            this.Load += new System.EventHandler(this.ReservationPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox GenderTextBox;
        private System.Windows.Forms.TextBox NationalCodeTextBox;
        private System.Windows.Forms.TextBox FlightIDTextBox;
        private System.Windows.Forms.Button ReserveButton;
    }
}