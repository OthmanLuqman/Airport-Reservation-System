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
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(420, 61);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(20, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "نام";
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Location = new System.Drawing.Point(420, 119);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(37, 13);
            this.CapacityLabel.TabIndex = 1;
            this.CapacityLabel.Text = "ظرفیت";
            // 
            // CopmanyLabel
            // 
            this.CopmanyLabel.AutoSize = true;
            this.CopmanyLabel.Location = new System.Drawing.Point(420, 169);
            this.CopmanyLabel.Name = "CopmanyLabel";
            this.CopmanyLabel.Size = new System.Drawing.Size(51, 13);
            this.CopmanyLabel.TabIndex = 2;
            this.CopmanyLabel.Text = "کد شرکت";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(302, 61);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // CapacityTextBox
            // 
            this.CapacityTextBox.Location = new System.Drawing.Point(302, 119);
            this.CapacityTextBox.Name = "CapacityTextBox";
            this.CapacityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CapacityTextBox.TabIndex = 4;
            // 
            // CopmanyIDTextBox
            // 
            this.CopmanyIDTextBox.Location = new System.Drawing.Point(302, 166);
            this.CopmanyIDTextBox.Name = "CopmanyIDTextBox";
            this.CopmanyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CopmanyIDTextBox.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(313, 207);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "اضافه کردن";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchCompanyIDButton
            // 
            this.SearchCompanyIDButton.Location = new System.Drawing.Point(266, 164);
            this.SearchCompanyIDButton.Name = "SearchCompanyIDButton";
            this.SearchCompanyIDButton.Size = new System.Drawing.Size(30, 23);
            this.SearchCompanyIDButton.TabIndex = 7;
            this.SearchCompanyIDButton.Text = "ج";
            this.SearchCompanyIDButton.UseVisualStyleBackColor = true;
            this.SearchCompanyIDButton.Click += new System.EventHandler(this.SearchCompanyIDButton_Click);
            // 
            // AddPlanePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 261);
            this.Controls.Add(this.SearchCompanyIDButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CopmanyIDTextBox);
            this.Controls.Add(this.CapacityTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CopmanyLabel);
            this.Controls.Add(this.CapacityLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "AddPlanePage";
            this.Text = "AddPlanePage";
            this.Load += new System.EventHandler(this.AddPlanePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}