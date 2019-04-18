namespace Game_Project_Application
{
    partial class ReceiptSearchResults
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
            this.SuspendLayout();
            // 
            // uxSearchResults
            // 
            this.uxSearchResults.FormattingEnabled = true;
            this.uxSearchResults.Location = new System.Drawing.Point(11, 11);
            this.uxSearchResults.Margin = new System.Windows.Forms.Padding(2);
            this.uxSearchResults.Name = "uxSearchResults";
            this.uxSearchResults.Size = new System.Drawing.Size(561, 433);
            this.uxSearchResults.TabIndex = 1;
            // 
            // ReceiptSearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 456);
            this.Controls.Add(this.uxSearchResults);
            this.Name = "ReceiptSearchResults";
            this.Text = "Receipt Search Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxSearchResults;
    }
}