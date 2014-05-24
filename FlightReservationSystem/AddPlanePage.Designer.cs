namespace FlightReservationSystem
{
    partial class AddPlanePage
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.CapacityLabel = new System.Windows.Forms.Label();
            this.CopmanyLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CapacityTextBox = new System.Windows.Forms.TextBox();
            this.CopmanyIDTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchCompanyIDButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(328, 45);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(19, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "نام";
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Location = new System.Drawing.Point(310, 96);
            this.CapacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(37, 20);
            this.CapacityLabel.TabIndex = 1;
            this.CapacityLabel.Text = "ظرفیت";
            // 
            // CopmanyLabel
            // 
            this.CopmanyLabel.AutoSize = true;
            this.CopmanyLabel.Location = new System.Drawing.Point(297, 147);
            this.CopmanyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CopmanyLabel.Name = "CopmanyLabel";
            this.CopmanyLabel.Size = new System.Drawing.Size(50, 20);
            this.CopmanyLabel.TabIndex = 2;
            this.CopmanyLabel.Text = "کد شرکت";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(151, 42);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(132, 27);
            this.NameTextBox.TabIndex = 3;
            // 
            // CapacityTextBox
            // 
            this.CapacityTextBox.Location = new System.Drawing.Point(151, 93);
            this.CapacityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CapacityTextBox.Name = "CapacityTextBox";
            this.CapacityTextBox.Size = new System.Drawing.Size(132, 27);
            this.CapacityTextBox.TabIndex = 4;
            // 
            // CopmanyIDTextBox
            // 
            this.CopmanyIDTextBox.Location = new System.Drawing.Point(97, 144);
            this.CopmanyIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CopmanyIDTextBox.Name = "CopmanyIDTextBox";
            this.CopmanyIDTextBox.Size = new System.Drawing.Size(186, 27);
            this.CopmanyIDTextBox.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(94, 238);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(136, 73);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "اضافه کردن";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchCompanyIDButton
            // 
            this.SearchCompanyIDButton.Location = new System.Drawing.Point(29, 144);
            this.SearchCompanyIDButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchCompanyIDButton.Name = "SearchCompanyIDButton";
            this.SearchCompanyIDButton.Size = new System.Drawing.Size(60, 27);
            this.SearchCompanyIDButton.TabIndex = 7;
            this.SearchCompanyIDButton.Text = "جستجو";
            this.SearchCompanyIDButton.UseVisualStyleBackColor = true;
            this.SearchCompanyIDButton.Click += new System.EventHandler(this.SearchCompanyIDButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchCompanyIDButton);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.CapacityLabel);
            this.groupBox1.Controls.Add(this.CopmanyIDTextBox);
            this.groupBox1.Controls.Add(this.CopmanyLabel);
            this.groupBox1.Controls.Add(this.CapacityTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(303, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(371, 209);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات";
            // 
            // AddPlanePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(708, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddButton);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddPlanePage";
            this.Load += new System.EventHandler(this.AddPlanePage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CapacityLabel;
        private System.Windows.Forms.Label CopmanyLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CapacityTextBox;
        private System.Windows.Forms.TextBox CopmanyIDTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SearchCompanyIDButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}