namespace FlightReservationSystem
{
    partial class DisplayAirplanesPage
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
            this.PlanesGridView = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlanesGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlanesGridView
            // 
            this.PlanesGridView.AllowUserToAddRows = false;
            this.PlanesGridView.AllowUserToDeleteRows = false;
            this.PlanesGridView.AllowUserToResizeColumns = false;
            this.PlanesGridView.AllowUserToResizeRows = false;
            this.PlanesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlanesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PlanesGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlanesGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PlanesGridView.Location = new System.Drawing.Point(0, 226);
            this.PlanesGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlanesGridView.MultiSelect = false;
            this.PlanesGridView.Name = "PlanesGridView";
            this.PlanesGridView.ReadOnly = true;
            this.PlanesGridView.Size = new System.Drawing.Size(615, 314);
            this.PlanesGridView.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(107, 89);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(117, 55);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "جستجو";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(88, 42);
            this.CompanyNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(153, 27);
            this.CompanyNameTextBox.TabIndex = 4;
            this.CompanyNameTextBox.TextChanged += new System.EventHandler(this.CompanyNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "نام شرکت";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CompanyNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(282, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(306, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات جستجو";
            // 
            // DisplayAirplanesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(615, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PlanesGridView);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayAirplanesPage";
            this.Load += new System.EventHandler(this.DisplayAirPlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlanesGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView PlanesGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}