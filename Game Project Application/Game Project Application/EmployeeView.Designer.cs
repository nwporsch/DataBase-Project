namespace Game_Project_Application
{
    partial class EmployeeView
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
            this.uxCondition = new System.Windows.Forms.ComboBox();
            this.uxStoreIdLabel = new System.Windows.Forms.Label();
            this.uxPlatformLabel = new System.Windows.Forms.Label();
            this.uxPriceLabel = new System.Windows.Forms.Label();
            this.uxConditionLabel = new System.Windows.Forms.Label();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.uxTitleLabel = new System.Windows.Forms.Label();
            this.uxPriceRange = new System.Windows.Forms.ComboBox();
            this.uxStoreId = new System.Windows.Forms.TextBox();
            this.uxPlatform = new System.Windows.Forms.TextBox();
            this.uxGenre = new System.Windows.Forms.TextBox();
            this.uxTitle = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uxView = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEmployeeView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxCondition
            // 
            this.uxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCondition.FormattingEnabled = true;
            this.uxCondition.Items.AddRange(new object[] {
            "-- Select Condition --",
            "New",
            "Used"});
            this.uxCondition.Location = new System.Drawing.Point(98, 184);
            this.uxCondition.Margin = new System.Windows.Forms.Padding(2);
            this.uxCondition.Name = "uxCondition";
            this.uxCondition.Size = new System.Drawing.Size(354, 28);
            this.uxCondition.TabIndex = 40;
            // 
            // uxStoreIdLabel
            // 
            this.uxStoreIdLabel.AutoSize = true;
            this.uxStoreIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStoreIdLabel.Location = new System.Drawing.Point(11, 157);
            this.uxStoreIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxStoreIdLabel.Name = "uxStoreIdLabel";
            this.uxStoreIdLabel.Size = new System.Drawing.Size(66, 20);
            this.uxStoreIdLabel.TabIndex = 47;
            this.uxStoreIdLabel.Text = "StoreId:";
            // 
            // uxPlatformLabel
            // 
            this.uxPlatformLabel.AutoSize = true;
            this.uxPlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlatformLabel.Location = new System.Drawing.Point(11, 95);
            this.uxPlatformLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPlatformLabel.Name = "uxPlatformLabel";
            this.uxPlatformLabel.Size = new System.Drawing.Size(72, 20);
            this.uxPlatformLabel.TabIndex = 46;
            this.uxPlatformLabel.Text = "Platform:";
            // 
            // uxPriceLabel
            // 
            this.uxPriceLabel.AutoSize = true;
            this.uxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPriceLabel.Location = new System.Drawing.Point(11, 125);
            this.uxPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPriceLabel.Name = "uxPriceLabel";
            this.uxPriceLabel.Size = new System.Drawing.Size(48, 20);
            this.uxPriceLabel.TabIndex = 45;
            this.uxPriceLabel.Text = "Price:";
            // 
            // uxConditionLabel
            // 
            this.uxConditionLabel.AutoSize = true;
            this.uxConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxConditionLabel.Location = new System.Drawing.Point(11, 187);
            this.uxConditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxConditionLabel.Name = "uxConditionLabel";
            this.uxConditionLabel.Size = new System.Drawing.Size(80, 20);
            this.uxConditionLabel.TabIndex = 44;
            this.uxConditionLabel.Text = "Condition:";
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGenreLabel.Location = new System.Drawing.Point(11, 65);
            this.uxGenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(58, 20);
            this.uxGenreLabel.TabIndex = 43;
            this.uxGenreLabel.Text = "Genre:";
            // 
            // uxTitleLabel
            // 
            this.uxTitleLabel.AutoSize = true;
            this.uxTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitleLabel.Location = new System.Drawing.Point(11, 35);
            this.uxTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxTitleLabel.Name = "uxTitleLabel";
            this.uxTitleLabel.Size = new System.Drawing.Size(42, 20);
            this.uxTitleLabel.TabIndex = 42;
            this.uxTitleLabel.Text = "Title:";
            // 
            // uxPriceRange
            // 
            this.uxPriceRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxPriceRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPriceRange.FormattingEnabled = true;
            this.uxPriceRange.Items.AddRange(new object[] {
            "-- Select Price --",
            "$0 - $9.99",
            "$10 - $19.99",
            "$20 - $29.99",
            "$30 - $39.99",
            "$40 - $49.99",
            "$50 - $59.99",
            "$60 - $69.99",
            "$70 - $79.99",
            "Above $80"});
            this.uxPriceRange.Location = new System.Drawing.Point(98, 122);
            this.uxPriceRange.Margin = new System.Windows.Forms.Padding(2);
            this.uxPriceRange.Name = "uxPriceRange";
            this.uxPriceRange.Size = new System.Drawing.Size(354, 28);
            this.uxPriceRange.TabIndex = 39;
            // 
            // uxStoreId
            // 
            this.uxStoreId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStoreId.Location = new System.Drawing.Point(98, 154);
            this.uxStoreId.Margin = new System.Windows.Forms.Padding(2);
            this.uxStoreId.Name = "uxStoreId";
            this.uxStoreId.Size = new System.Drawing.Size(354, 26);
            this.uxStoreId.TabIndex = 38;
            // 
            // uxPlatform
            // 
            this.uxPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlatform.Location = new System.Drawing.Point(98, 92);
            this.uxPlatform.Margin = new System.Windows.Forms.Padding(2);
            this.uxPlatform.Name = "uxPlatform";
            this.uxPlatform.Size = new System.Drawing.Size(354, 26);
            this.uxPlatform.TabIndex = 37;
            // 
            // uxGenre
            // 
            this.uxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGenre.Location = new System.Drawing.Point(98, 62);
            this.uxGenre.Margin = new System.Windows.Forms.Padding(2);
            this.uxGenre.Name = "uxGenre";
            this.uxGenre.Size = new System.Drawing.Size(354, 26);
            this.uxGenre.TabIndex = 36;
            // 
            // uxTitle
            // 
            this.uxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitle.Location = new System.Drawing.Point(98, 32);
            this.uxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.uxTitle.Name = "uxTitle";
            this.uxTitle.Size = new System.Drawing.Size(354, 26);
            this.uxTitle.TabIndex = 35;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uxView
            // 
            this.uxView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxEmployeeView});
            this.uxView.Name = "uxView";
            this.uxView.Size = new System.Drawing.Size(44, 20);
            this.uxView.Text = "View";
            // 
            // uxEmployeeView
            // 
            this.uxEmployeeView.Name = "uxEmployeeView";
            this.uxEmployeeView.Size = new System.Drawing.Size(154, 22);
            this.uxEmployeeView.Text = "Customer View";
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.uxCondition);
            this.Controls.Add(this.uxStoreIdLabel);
            this.Controls.Add(this.uxPlatformLabel);
            this.Controls.Add(this.uxPriceLabel);
            this.Controls.Add(this.uxConditionLabel);
            this.Controls.Add(this.uxGenreLabel);
            this.Controls.Add(this.uxTitleLabel);
            this.Controls.Add(this.uxPriceRange);
            this.Controls.Add(this.uxStoreId);
            this.Controls.Add(this.uxPlatform);
            this.Controls.Add(this.uxGenre);
            this.Controls.Add(this.uxTitle);
            this.Controls.Add(this.menuStrip1);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxCondition;
        private System.Windows.Forms.Label uxStoreIdLabel;
        private System.Windows.Forms.Label uxPlatformLabel;
        private System.Windows.Forms.Label uxPriceLabel;
        private System.Windows.Forms.Label uxConditionLabel;
        private System.Windows.Forms.Label uxGenreLabel;
        private System.Windows.Forms.Label uxTitleLabel;
        private System.Windows.Forms.ComboBox uxPriceRange;
        private System.Windows.Forms.TextBox uxStoreId;
        private System.Windows.Forms.TextBox uxPlatform;
        private System.Windows.Forms.TextBox uxGenre;
        private System.Windows.Forms.TextBox uxTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uxView;
        private System.Windows.Forms.ToolStripMenuItem uxEmployeeView;
    }
}