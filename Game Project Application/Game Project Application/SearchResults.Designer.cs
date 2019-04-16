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
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.uxSearchResults);
            this.Name = "SearchResults";
            this.Text = "Search Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxSearchResults;
    }
}