namespace FlightReservationSystem
{
    partial class DisplayReservationsPage
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
            this.ReservationGridView = new System.Windows.Forms.DataGridView();
            this.ReservationIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FlightIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReservationGridView
            // 
            this.ReservationGridView.AllowUserToAddRows = false;
            this.ReservationGridView.AllowUserToDeleteRows = false;
            this.ReservationGridView.AllowUserToResizeColumns = false;
            this.ReservationGridView.AllowUserToResizeRows = false;
            this.ReservationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReservationGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ReservationGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReservationGridView.Location = new System.Drawing.Point(0, 185);
            this.ReservationGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReservationGridView.MultiSelect = false;
            this.ReservationGridView.Name = "ReservationGridView";
            this.ReservationGridView.ReadOnly = true;
            this.ReservationGridView.Size = new System.Drawing.Size(921, 391);
            this.ReservationGridView.TabIndex = 2;
            // 
            // ReservationIDTextBox
            // 
            this.ReservationIDTextBox.Location = new System.Drawing.Point(59, 35);
            this.ReservationIDTextBox.Name = "ReservationIDTextBox";
            this.ReservationIDTextBox.Size = new System.Drawing.Size(280, 27);
            this.ReservationIDTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "شماره رزرو";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FlightIDTextBox);
            this.groupBox1.Controls.Add(this.ReservationIDTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(408, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(447, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(189, 76);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(124, 47);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "جستجو";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FlightIDTextBox
            // 
            this.FlightIDTextBox.Location = new System.Drawing.Point(59, 77);
            this.FlightIDTextBox.Name = "FlightIDTextBox";
            this.FlightIDTextBox.Size = new System.Drawing.Size(280, 27);
            this.FlightIDTextBox.TabIndex = 7;
            // 
            // DisplayReservationsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(921, 576);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReservationGridView);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayReservationsPage";
            this.Load += new System.EventHandler(this.DisplayReservationsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView ReservationGridView;
        private System.Windows.Forms.TextBox ReservationIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox FlightIDTextBox;
    }
}