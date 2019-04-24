//GameStore App designer
namespace Game_Project_Application
{
    partial class GameApplication
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
            this.uxStoreId = new System.Windows.Forms.TextBox();
            this.uxStoreIdLabel = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.uxPriceRange = new System.Windows.Forms.ComboBox();
            this.uxCondition = new System.Windows.Forms.ComboBox();
            this.btnFinishTransaction = new System.Windows.Forms.Button();
            this.uxReceipt = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.uxView = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEmployeeView = new System.Windows.Forms.ToolStripMenuItem();
            this.storeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.uxReceipt)).BeginInit();
            this.uxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxTitleLabel
            // 
            this.uxTitleLabel.AutoSize = true;
            this.uxTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitleLabel.Location = new System.Drawing.Point(11, 50);
            this.uxTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxTitleLabel.Name = "uxTitleLabel";
            this.uxTitleLabel.Size = new System.Drawing.Size(55, 25);
            this.uxTitleLabel.TabIndex = 0;
            this.uxTitleLabel.Text = "Title:";
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGenreLabel.Location = new System.Drawing.Point(11, 80);
            this.uxGenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(72, 25);
            this.uxGenreLabel.TabIndex = 1;
            this.uxGenreLabel.Text = "Genre:";
            // 
            // uxConditionLabel
            // 
            this.uxConditionLabel.AutoSize = true;
            this.uxConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxConditionLabel.Location = new System.Drawing.Point(11, 202);
            this.uxConditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxConditionLabel.Name = "uxConditionLabel";
            this.uxConditionLabel.Size = new System.Drawing.Size(101, 25);
            this.uxConditionLabel.TabIndex = 3;
            this.uxConditionLabel.Text = "Condition:";
            // 
            // uxPriceLabel
            // 
            this.uxPriceLabel.AutoSize = true;
            this.uxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPriceLabel.Location = new System.Drawing.Point(11, 140);
            this.uxPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPriceLabel.Name = "uxPriceLabel";
            this.uxPriceLabel.Size = new System.Drawing.Size(62, 25);
            this.uxPriceLabel.TabIndex = 4;
            this.uxPriceLabel.Text = "Price:";
            // 
            // uxPlatformLabel
            // 
            this.uxPlatformLabel.AutoSize = true;
            this.uxPlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlatformLabel.Location = new System.Drawing.Point(11, 110);
            this.uxPlatformLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPlatformLabel.Name = "uxPlatformLabel";
            this.uxPlatformLabel.Size = new System.Drawing.Size(89, 25);
            this.uxPlatformLabel.TabIndex = 5;
            this.uxPlatformLabel.Text = "Platform:";
            // 
            // uxTitle
            // 
            this.uxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitle.Location = new System.Drawing.Point(92, 47);
            this.uxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.uxTitle.Name = "uxTitle";
            this.uxTitle.Size = new System.Drawing.Size(453, 30);
            this.uxTitle.TabIndex = 6;
            this.uxTitle.TextChanged += new System.EventHandler(this.uxTitle_TextChanged);
            // 
            // uxGenre
            // 
            this.uxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGenre.Location = new System.Drawing.Point(92, 77);
            this.uxGenre.Margin = new System.Windows.Forms.Padding(2);
            this.uxGenre.Name = "uxGenre";
            this.uxGenre.Size = new System.Drawing.Size(453, 30);
            this.uxGenre.TabIndex = 7;
            // 
            // uxPlatform
            // 
            this.uxPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPlatform.Location = new System.Drawing.Point(92, 107);
            this.uxPlatform.Margin = new System.Windows.Forms.Padding(2);
            this.uxPlatform.Name = "uxPlatform";
            this.uxPlatform.Size = new System.Drawing.Size(453, 30);
            this.uxPlatform.TabIndex = 8;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(92, 231);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(124, 28);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // uxStoreId
            // 
            this.uxStoreId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStoreId.Location = new System.Drawing.Point(92, 169);
            this.uxStoreId.Margin = new System.Windows.Forms.Padding(2);
            this.uxStoreId.Name = "uxStoreId";
            this.uxStoreId.Size = new System.Drawing.Size(453, 30);
            this.uxStoreId.TabIndex = 15;
            this.uxStoreId.TextChanged += new System.EventHandler(this.uxStoreId_TextChanged);
            // 
            // uxStoreIdLabel
            // 
            this.uxStoreIdLabel.AutoSize = true;
            this.uxStoreIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStoreIdLabel.Location = new System.Drawing.Point(11, 172);
            this.uxStoreIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxStoreIdLabel.Name = "uxStoreIdLabel";
            this.uxStoreIdLabel.Size = new System.Drawing.Size(81, 25);
            this.uxStoreIdLabel.TabIndex = 14;
            this.uxStoreIdLabel.Text = "StoreId:";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(268, 231);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(277, 28);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove from Receipt";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.uxPriceRange.Location = new System.Drawing.Point(92, 137);
            this.uxPriceRange.Margin = new System.Windows.Forms.Padding(2);
            this.uxPriceRange.Name = "uxPriceRange";
            this.uxPriceRange.Size = new System.Drawing.Size(453, 33);
            this.uxPriceRange.TabIndex = 18;
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
            this.uxCondition.Location = new System.Drawing.Point(92, 199);
            this.uxCondition.Margin = new System.Windows.Forms.Padding(2);
            this.uxCondition.Name = "uxCondition";
            this.uxCondition.Size = new System.Drawing.Size(453, 33);
            this.uxCondition.TabIndex = 19;
            // 
            // btnFinishTransaction
            // 
            this.btnFinishTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishTransaction.Location = new System.Drawing.Point(14, 410);
            this.btnFinishTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinishTransaction.Name = "btnFinishTransaction";
            this.btnFinishTransaction.Size = new System.Drawing.Size(531, 28);
            this.btnFinishTransaction.TabIndex = 20;
            this.btnFinishTransaction.Text = "Finish Transaction";
            this.btnFinishTransaction.UseVisualStyleBackColor = true;
            this.btnFinishTransaction.Click += new System.EventHandler(this.btnFinishTransaction_Click);
            // 
            // uxReceipt
            // 
            this.uxReceipt.AllowUserToAddRows = false;
            this.uxReceipt.AllowUserToDeleteRows = false;
            this.uxReceipt.AllowUserToOrderColumns = true;
            this.uxReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Genre,
            this.Price,
            this.Condition,
            this.GameId,
            this.StoreId,
            this.Quantity,
            this.Platform});
            this.uxReceipt.Location = new System.Drawing.Point(15, 263);
            this.uxReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.uxReceipt.Name = "uxReceipt";
            this.uxReceipt.ReadOnly = true;
            this.uxReceipt.RowTemplate.Height = 24;
            this.uxReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxReceipt.Size = new System.Drawing.Size(530, 143);
            this.uxReceipt.TabIndex = 21;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 87;
            // 
            // Condition
            // 
            this.Condition.HeaderText = "Condition";
            this.Condition.Name = "Condition";
            this.Condition.ReadOnly = true;
            // 
            // GameId
            // 
            this.GameId.HeaderText = "GameId";
            this.GameId.Name = "GameId";
            this.GameId.ReadOnly = true;
            this.GameId.Visible = false;
            // 
            // StoreId
            // 
            this.StoreId.HeaderText = "StoreId";
            this.StoreId.Name = "StoreId";
            this.StoreId.ReadOnly = true;
            this.StoreId.Visible = false;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Visible = false;
            // 
            // Platform
            // 
            this.Platform.HeaderText = "Platform";
            this.Platform.Name = "Platform";
            this.Platform.ReadOnly = true;
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxView});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(561, 28);
            this.uxMenuStrip.TabIndex = 42;
            this.uxMenuStrip.Text = "Views";
            // 
            // uxView
            // 
            this.uxView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxEmployeeView,
            this.storeViewToolStripMenuItem});
            this.uxView.Name = "uxView";
            this.uxView.Size = new System.Drawing.Size(53, 24);
            this.uxView.Text = "View";
            // 
            // uxEmployeeView
            // 
            this.uxEmployeeView.Name = "uxEmployeeView";
            this.uxEmployeeView.Size = new System.Drawing.Size(186, 26);
            this.uxEmployeeView.Text = "Employee View";
            this.uxEmployeeView.Click += new System.EventHandler(this.uxEmployeeView_Click);
            // 
            // storeViewToolStripMenuItem
            // 
            this.storeViewToolStripMenuItem.Name = "storeViewToolStripMenuItem";
            this.storeViewToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.storeViewToolStripMenuItem.Text = "Store View";
            this.storeViewToolStripMenuItem.Click += new System.EventHandler(this.storeViewToolStripMenuItem_Click);
            // 
            // GameApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 444);
            this.Controls.Add(this.uxMenuStrip);
            this.Controls.Add(this.uxReceipt);
            this.Controls.Add(this.btnFinishTransaction);
            this.Controls.Add(this.uxCondition);
            this.Controls.Add(this.uxPriceRange);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.uxStoreId);
            this.Controls.Add(this.uxStoreIdLabel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.uxPlatform);
            this.Controls.Add(this.uxGenre);
            this.Controls.Add(this.uxTitle);
            this.Controls.Add(this.uxPlatformLabel);
            this.Controls.Add(this.uxPriceLabel);
            this.Controls.Add(this.uxConditionLabel);
            this.Controls.Add(this.uxGenreLabel);
            this.Controls.Add(this.uxTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GameApplication";
            this.Text = "Store Application";
            this.Load += new System.EventHandler(this.uxStoreApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxReceipt)).EndInit();
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
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
        private System.Windows.Forms.TextBox uxStoreId;
        private System.Windows.Forms.Label uxStoreIdLabel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox uxPriceRange;
        private System.Windows.Forms.ComboBox uxCondition;
        private System.Windows.Forms.Button btnFinishTransaction;
        private System.Windows.Forms.DataGridView uxReceipt;
        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uxView;
        private System.Windows.Forms.ToolStripMenuItem uxEmployeeView;
        private System.Windows.Forms.ToolStripMenuItem storeViewToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
    }
}

