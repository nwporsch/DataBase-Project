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
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxSalesText
            // 
            this.uxSalesText.Location = new System.Drawing.Point(13, 13);
            this.uxSalesText.Multiline = true;
            this.uxSalesText.Name = "uxSalesText";
            this.uxSalesText.ReadOnly = true;
            this.uxSalesText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxSalesText.Size = new System.Drawing.Size(785, 425);
            this.uxSalesText.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(13, 456);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(785, 49);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // SalesInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 517);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.uxSalesText);
            this.Name = "SalesInformation";
            this.Text = "SalesInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxSalesText;
        private System.Windows.Forms.Button btnOk;
    }
}