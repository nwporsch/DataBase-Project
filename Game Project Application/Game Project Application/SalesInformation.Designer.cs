namespace Game_Project_Application
{
    partial class SalesInformation
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
            this.uxSalesText = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.uxYearLabel = new System.Windows.Forms.Label();
            this.uxYearText = new System.Windows.Forms.TextBox();
            this.uxbtnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxSalesText
            // 
            this.uxSalesText.Location = new System.Drawing.Point(13, 35);
            this.uxSalesText.Multiline = true;
            this.uxSalesText.Name = "uxSalesText";
            this.uxSalesText.ReadOnly = true;
            this.uxSalesText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxSalesText.Size = new System.Drawing.Size(785, 403);
            this.uxSalesText.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(13, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(785, 49);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // uxYearLabel
            // 
            this.uxYearLabel.AutoSize = true;
            this.uxYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxYearLabel.Location = new System.Drawing.Point(12, 9);
            this.uxYearLabel.Name = "uxYearLabel";
            this.uxYearLabel.Size = new System.Drawing.Size(91, 20);
            this.uxYearLabel.TabIndex = 2;
            this.uxYearLabel.Text = "Sales Year:";
            // 
            // uxYearText
            // 
            this.uxYearText.Location = new System.Drawing.Point(109, 9);
            this.uxYearText.Name = "uxYearText";
            this.uxYearText.Size = new System.Drawing.Size(80, 20);
            this.uxYearText.TabIndex = 3;
            // 
            // uxbtnSearch
            // 
            this.uxbtnSearch.Location = new System.Drawing.Point(207, 9);
            this.uxbtnSearch.Name = "uxbtnSearch";
            this.uxbtnSearch.Size = new System.Drawing.Size(136, 23);
            this.uxbtnSearch.TabIndex = 4;
            this.uxbtnSearch.Text = "Search";
            this.uxbtnSearch.UseVisualStyleBackColor = true;
            this.uxbtnSearch.Click += new System.EventHandler(this.uxbtnSearch_Click);
            // 
            // SalesInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 517);
            this.Controls.Add(this.uxbtnSearch);
            this.Controls.Add(this.uxYearText);
            this.Controls.Add(this.uxYearLabel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.uxSalesText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesInformation";
            this.Text = "SalesInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxSalesText;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label uxYearLabel;
        private System.Windows.Forms.TextBox uxYearText;
        private System.Windows.Forms.Button uxbtnSearch;
    }
}