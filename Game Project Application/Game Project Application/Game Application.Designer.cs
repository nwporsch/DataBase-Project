namespace Game_Project_Application
{
    partial class uxStoreApplication
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
            this.uxTitleLabel = new System.Windows.Forms.Label();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.uxConditionLabel = new System.Windows.Forms.Label();
            this.uxPriceLabel = new System.Windows.Forms.Label();
            this.uxPlatformLabel = new System.Windows.Forms.Label();
            this.uxTitle = new System.Windows.Forms.TextBox();
            this.uxGenre = new System.Windows.Forms.TextBox();
            this.uxPlatform = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAddToReceipt = new System.Windows.Forms.Button();
            this.uxStoreId = new System.Windows.Forms.TextBox();
            this.uxStoreIdLabel = new System.Windows.Forms.Label();
            this.uxReceipt = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.uxPriceRange = new System.Windows.Forms.ComboBox();
            this.uxCondition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uxTitleLabel
            // 
            this.uxTitleLabel.AutoSize = true;
            this.uxTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.uxTitleLabel.Name = "uxTitleLabel";
            this.uxTitleLabel.Size = new System.Drawing.Size(55, 25);
            this.uxTitleLabel.TabIndex = 0;
            this.uxTitleLabel.Text = "Title:";
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGenreLabel.Location = new System.Drawing.Point(13, 58);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(72, 25);
            this.uxGenreLabel.TabIndex = 1;
            this.uxGenreLabel.Text = "Genre:";
            // 
            // uxConditionLabel
            // 
            this.uxConditionLabel.AutoSize = true;
            this.uxConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxConditionLabel.Location = new System.Drawing.Point(13, 261);
            this.uxConditionLabel.Name = "uxConditionLabel";
            this.uxConditionLabel.Size = new System.Drawing.Size(101, 25);
            this.uxConditionLabel.TabIndex = 3;
            this.uxConditionLabel.Text = "Condition:";
            // 
            // uxPriceLabel
            // 
            this.uxPriceLabel.AutoSize = true;
            this.uxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPriceLabel.Location = new System.Drawing.Point(13, 161);
            this.uxPriceLabel.Name = "uxPriceLabel";
            this.uxPriceLabel.Size = new System.Drawing.Size(62, 25);
            this.uxPriceLabel.TabIndex = 4;
            this.uxPriceLabel.Text = "Price:";
            // 
            // uxPlatformLabel
            // 
            this.uxPlatformLabel.AutoSize = true;
            this.uxPlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlatformLabel.Location = new System.Drawing.Point(13, 109);
            this.uxPlatformLabel.Name = "uxPlatformLabel";
            this.uxPlatformLabel.Size = new System.Drawing.Size(89, 25);
            this.uxPlatformLabel.TabIndex = 5;
            this.uxPlatformLabel.Text = "Platform:";
            // 
            // uxTitle
            // 
            this.uxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitle.Location = new System.Drawing.Point(124, 12);
            this.uxTitle.Name = "uxTitle";
            this.uxTitle.Size = new System.Drawing.Size(470, 30);
            this.uxTitle.TabIndex = 6;
            this.uxTitle.TextChanged += new System.EventHandler(this.uxTitle_TextChanged);
            // 
            // uxGenre
            // 
            this.uxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGenre.Location = new System.Drawing.Point(124, 62);
            this.uxGenre.Name = "uxGenre";
            this.uxGenre.Size = new System.Drawing.Size(470, 30);
            this.uxGenre.TabIndex = 7;
            // 
            // uxPlatform
            // 
            this.uxPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlatform.Location = new System.Drawing.Point(124, 109);
            this.uxPlatform.Name = "uxPlatform";
            this.uxPlatform.Size = new System.Drawing.Size(470, 30);
            this.uxPlatform.TabIndex = 8;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(18, 300);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(84, 34);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAddToReceipt
            // 
            this.btnAddToReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToReceipt.Location = new System.Drawing.Point(124, 300);
            this.btnAddToReceipt.Name = "btnAddToReceipt";
            this.btnAddToReceipt.Size = new System.Drawing.Size(204, 34);
            this.btnAddToReceipt.TabIndex = 13;
            this.btnAddToReceipt.Text = "Add to Receipt";
            this.btnAddToReceipt.UseVisualStyleBackColor = true;
            // 
            // uxStoreId
            // 
            this.uxStoreId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStoreId.Location = new System.Drawing.Point(124, 208);
            this.uxStoreId.Name = "uxStoreId";
            this.uxStoreId.Size = new System.Drawing.Size(470, 30);
            this.uxStoreId.TabIndex = 15;
            // 
            // uxStoreIdLabel
            // 
            this.uxStoreIdLabel.AutoSize = true;
            this.uxStoreIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStoreIdLabel.Location = new System.Drawing.Point(13, 208);
            this.uxStoreIdLabel.Name = "uxStoreIdLabel";
            this.uxStoreIdLabel.Size = new System.Drawing.Size(81, 25);
            this.uxStoreIdLabel.TabIndex = 14;
            this.uxStoreIdLabel.Text = "StoreId:";
            // 
            // uxReceipt
            // 
            this.uxReceipt.FormattingEnabled = true;
            this.uxReceipt.ItemHeight = 16;
            this.uxReceipt.Location = new System.Drawing.Point(18, 350);
            this.uxReceipt.Name = "uxReceipt";
            this.uxReceipt.Size = new System.Drawing.Size(576, 148);
            this.uxReceipt.TabIndex = 16;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(349, 299);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(245, 34);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove from Receipt";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // uxPriceRange
            // 
            this.uxPriceRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxPriceRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPriceRange.FormattingEnabled = true;
            this.uxPriceRange.Items.AddRange(new object[] {
            " ",
            "$0 - $9.99",
            "$10 - $19.99",
            "$20 - $29.99",
            "$30 - $39.99",
            "$40 - $49.99",
            "$50 - $59.99",
            "$60 - $69.99",
            "$70 - $79.99",
            "Above $80"});
            this.uxPriceRange.Location = new System.Drawing.Point(124, 158);
            this.uxPriceRange.Name = "uxPriceRange";
            this.uxPriceRange.Size = new System.Drawing.Size(470, 33);
            this.uxPriceRange.TabIndex = 18;
            // 
            // uxCondition
            // 
            this.uxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCondition.FormattingEnabled = true;
            this.uxCondition.Items.AddRange(new object[] {
            " ",
            "New",
            "Used"});
            this.uxCondition.Location = new System.Drawing.Point(124, 253);
            this.uxCondition.Name = "uxCondition";
            this.uxCondition.Size = new System.Drawing.Size(470, 33);
            this.uxCondition.TabIndex = 19;
            // 
            // uxStoreApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 522);
            this.Controls.Add(this.uxCondition);
            this.Controls.Add(this.uxPriceRange);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.uxReceipt);
            this.Controls.Add(this.uxStoreId);
            this.Controls.Add(this.uxStoreIdLabel);
            this.Controls.Add(this.btnAddToReceipt);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.uxPlatform);
            this.Controls.Add(this.uxGenre);
            this.Controls.Add(this.uxTitle);
            this.Controls.Add(this.uxPlatformLabel);
            this.Controls.Add(this.uxPriceLabel);
            this.Controls.Add(this.uxConditionLabel);
            this.Controls.Add(this.uxGenreLabel);
            this.Controls.Add(this.uxTitleLabel);
            this.Name = "uxStoreApplication";
            this.Text = "Store Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxTitleLabel;
        private System.Windows.Forms.Label uxGenreLabel;
        private System.Windows.Forms.Label uxConditionLabel;
        private System.Windows.Forms.Label uxPriceLabel;
        private System.Windows.Forms.Label uxPlatformLabel;
        private System.Windows.Forms.TextBox uxTitle;
        private System.Windows.Forms.TextBox uxGenre;
        private System.Windows.Forms.TextBox uxPlatform;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAddToReceipt;
        private System.Windows.Forms.TextBox uxStoreId;
        private System.Windows.Forms.Label uxStoreIdLabel;
        private System.Windows.Forms.ListBox uxReceipt;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox uxPriceRange;
        private System.Windows.Forms.ComboBox uxCondition;
    }
}

