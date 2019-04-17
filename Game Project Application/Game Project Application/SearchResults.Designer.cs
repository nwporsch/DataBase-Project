namespace Game_Project_Application
{
    partial class SearchResults
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
            this.uxSearchResults = new System.Windows.Forms.ListBox();
            this.btnAddToReceipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxSearchResults
            // 
            this.uxSearchResults.FormattingEnabled = true;
            this.uxSearchResults.ItemHeight = 16;
            this.uxSearchResults.Location = new System.Drawing.Point(12, 12);
            this.uxSearchResults.Name = "uxSearchResults";
            this.uxSearchResults.Size = new System.Drawing.Size(776, 404);
            this.uxSearchResults.TabIndex = 0;
            // 
            // btnAddToReceipt
            // 
            this.btnAddToReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToReceipt.Location = new System.Drawing.Point(12, 422);
            this.btnAddToReceipt.Name = "btnAddToReceipt";
            this.btnAddToReceipt.Size = new System.Drawing.Size(776, 34);
            this.btnAddToReceipt.TabIndex = 22;
            this.btnAddToReceipt.Text = "Add to Receipt";
            this.btnAddToReceipt.UseVisualStyleBackColor = true;
            this.btnAddToReceipt.Click += new System.EventHandler(this.btnAddToReceipt_Click);
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.btnAddToReceipt);
            this.Controls.Add(this.uxSearchResults);
            this.Name = "SearchResults";
            this.Text = "Search Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxSearchResults;
        private System.Windows.Forms.Button btnAddToReceipt;
    }
}