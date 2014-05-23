namespace FlightReservationSystem
{
    partial class DisplayStaffsPage
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
            this.StaffGridView = new System.Windows.Forms.DataGridView();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.RankLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.RankComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffGridView
            // 
            this.StaffGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StaffGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StaffGridView.Location = new System.Drawing.Point(0, 208);
            this.StaffGridView.Name = "StaffGridView";
            this.StaffGridView.Size = new System.Drawing.Size(740, 150);
            this.StaffGridView.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(589, 40);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(588, 72);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name";
            // 
            // RankLabel
            // 
            this.RankLabel.AutoSize = true;
            this.RankLabel.Location = new System.Drawing.Point(589, 101);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(26, 13);
            this.RankLabel.TabIndex = 4;
            this.RankLabel.Text = "مقام";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(464, 148);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "جستجو";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(464, 37);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 6;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(464, 65);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 7;
            // 
            // RankComboBox
            // 
            this.RankComboBox.FormattingEnabled = true;
            this.RankComboBox.Items.AddRange(new object[] {
            "مدیر",
            "فروشنده"});
            this.RankComboBox.Location = new System.Drawing.Point(464, 98);
            this.RankComboBox.Name = "RankComboBox";
            this.RankComboBox.Size = new System.Drawing.Size(100, 21);
            this.RankComboBox.TabIndex = 8;
            // 
            // DisplayStaffsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 358);
            this.Controls.Add(this.RankComboBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RankLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.StaffGridView);
            this.Name = "DisplayStaffsPage";
            this.Text = "DisplayStaffsPage";
            this.Load += new System.EventHandler(this.DisplayStaffsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView StaffGridView;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label RankLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.ComboBox RankComboBox;
    }
}