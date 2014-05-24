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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaffGridView
            // 
            this.StaffGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StaffGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StaffGridView.Location = new System.Drawing.Point(0, 281);
            this.StaffGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StaffGridView.Name = "StaffGridView";
            this.StaffGridView.Size = new System.Drawing.Size(768, 231);
            this.StaffGridView.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(264, 35);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(19, 20);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "نام";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(224, 105);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(59, 20);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "نام خانوادگی";
            // 
            // RankLabel
            // 
            this.RankLabel.AutoSize = true;
            this.RankLabel.Location = new System.Drawing.Point(251, 177);
            this.RankLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(32, 20);
            this.RankLabel.TabIndex = 4;
            this.RankLabel.Text = "سمت";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(230, 149);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(115, 72);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "جستجو";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(84, 32);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(132, 27);
            this.FirstNameTextBox.TabIndex = 6;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(84, 98);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(132, 27);
            this.LastNameTextBox.TabIndex = 7;
            // 
            // RankComboBox
            // 
            this.RankComboBox.FormattingEnabled = true;
            this.RankComboBox.Items.AddRange(new object[] {
            "مدیر",
            "فروشنده"});
            this.RankComboBox.Location = new System.Drawing.Point(84, 169);
            this.RankComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RankComboBox.Name = "RankComboBox";
            this.RankComboBox.Size = new System.Drawing.Size(132, 28);
            this.RankComboBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FirstNameTextBox);
            this.groupBox1.Controls.Add(this.RankComboBox);
            this.groupBox1.Controls.Add(this.FirstNameLabel);
            this.groupBox1.Controls.Add(this.LastNameTextBox);
            this.groupBox1.Controls.Add(this.LastNameLabel);
            this.groupBox1.Controls.Add(this.RankLabel);
            this.groupBox1.Location = new System.Drawing.Point(413, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(307, 249);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات جستجو";
            // 
            // DisplayStaffsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(768, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.StaffGridView);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayStaffsPage";
            this.Load += new System.EventHandler(this.DisplayStaffsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}