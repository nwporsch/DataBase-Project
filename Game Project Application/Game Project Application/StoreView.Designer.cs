namespace Game_Project_Application
{
    partial class StoreView
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
            this.uxReceiptIdLabel = new System.Windows.Forms.Label();
            this.uxStoreId = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnStoreInfo = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxReceiptIdLabel
            // 
            this.uxReceiptIdLabel.AutoSize = true;
            this.uxReceiptIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReceiptIdLabel.Location = new System.Drawing.Point(11, 19);
            this.uxReceiptIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxReceiptIdLabel.Name = "uxReceiptIdLabel";
            this.uxReceiptIdLabel.Size = new System.Drawing.Size(89, 25);
            this.uxReceiptIdLabel.TabIndex = 44;
            this.uxReceiptIdLabel.Text = "Store ID:";
            // 
            // uxStoreId
            // 
            this.uxStoreId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStoreId.Location = new System.Drawing.Point(102, 16);
            this.uxStoreId.Margin = new System.Windows.Forms.Padding(2);
            this.uxStoreId.Name = "uxStoreId";
            this.uxStoreId.Size = new System.Drawing.Size(354, 30);
            this.uxStoreId.TabIndex = 43;
            this.uxStoreId.TextChanged += new System.EventHandler(this.uxStoreId_TextChanged);
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(15, 121);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(441, 28);
            this.btnFinish.TabIndex = 52;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnStoreInfo
            // 
            this.btnStoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreInfo.Location = new System.Drawing.Point(15, 57);
            this.btnStoreInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnStoreInfo.Name = "btnStoreInfo";
            this.btnStoreInfo.Size = new System.Drawing.Size(441, 28);
            this.btnStoreInfo.TabIndex = 51;
            this.btnStoreInfo.Text = "Store Information";
            this.btnStoreInfo.UseVisualStyleBackColor = true;
            this.btnStoreInfo.Click += new System.EventHandler(this.btnStoreInfo_Click);
            // 
            // btnSales
            // 
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(15, 89);
            this.btnSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(441, 28);
            this.btnSales.TabIndex = 53;
            this.btnSales.Text = "Sales Information";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // StoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 160);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStoreInfo);
            this.Controls.Add(this.uxReceiptIdLabel);
            this.Controls.Add(this.uxStoreId);
            this.Name = "StoreView";
            this.Text = "StoreView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxReceiptIdLabel;
        private System.Windows.Forms.TextBox uxStoreId;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnStoreInfo;
        private System.Windows.Forms.Button btnSales;
    }
}