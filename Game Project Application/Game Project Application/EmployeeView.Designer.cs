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
            this.uxEmailLabel = new System.Windows.Forms.Label();
            this.uxLastNameLabel = new System.Windows.Forms.Label();
            this.uxFirstNameLabel = new System.Windows.Forms.Label();
            this.uxCustomerIdLabel = new System.Windows.Forms.Label();
            this.uxEmail = new System.Windows.Forms.TextBox();
            this.uxLastName = new System.Windows.Forms.TextBox();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxCustomerId = new System.Windows.Forms.TextBox();
            this.btnFindReceipt = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxEmailLabel
            // 
            this.uxEmailLabel.AutoSize = true;
            this.uxEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEmailLabel.Location = new System.Drawing.Point(19, 104);
            this.uxEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxEmailLabel.Name = "uxEmailLabel";
            this.uxEmailLabel.Size = new System.Drawing.Size(52, 20);
            this.uxEmailLabel.TabIndex = 47;
            this.uxEmailLabel.Text = "Email:";
            // 
            // uxLastNameLabel
            // 
            this.uxLastNameLabel.AutoSize = true;
            this.uxLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLastNameLabel.Location = new System.Drawing.Point(19, 74);
            this.uxLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLastNameLabel.Name = "uxLastNameLabel";
            this.uxLastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.uxLastNameLabel.TabIndex = 46;
            this.uxLastNameLabel.Text = "Last Name:";
            // 
            // uxFirstNameLabel
            // 
            this.uxFirstNameLabel.AutoSize = true;
            this.uxFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFirstNameLabel.Location = new System.Drawing.Point(19, 44);
            this.uxFirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxFirstNameLabel.Name = "uxFirstNameLabel";
            this.uxFirstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.uxFirstNameLabel.TabIndex = 43;
            this.uxFirstNameLabel.Text = "First Name:";
            // 
            // uxCustomerIdLabel
            // 
            this.uxCustomerIdLabel.AutoSize = true;
            this.uxCustomerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCustomerIdLabel.Location = new System.Drawing.Point(19, 14);
            this.uxCustomerIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxCustomerIdLabel.Name = "uxCustomerIdLabel";
            this.uxCustomerIdLabel.Size = new System.Drawing.Size(103, 20);
            this.uxCustomerIdLabel.TabIndex = 42;
            this.uxCustomerIdLabel.Text = "Customer ID:";
            // 
            // uxEmail
            // 
            this.uxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEmail.Location = new System.Drawing.Point(124, 101);
            this.uxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.uxEmail.Name = "uxEmail";
            this.uxEmail.Size = new System.Drawing.Size(354, 26);
            this.uxEmail.TabIndex = 38;
            // 
            // uxLastName
            // 
            this.uxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLastName.Location = new System.Drawing.Point(124, 71);
            this.uxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(354, 26);
            this.uxLastName.TabIndex = 37;
            // 
            // uxFirstName
            // 
            this.uxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFirstName.Location = new System.Drawing.Point(124, 41);
            this.uxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(354, 26);
            this.uxFirstName.TabIndex = 36;
            // 
            // uxCustomerId
            // 
            this.uxCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCustomerId.Location = new System.Drawing.Point(124, 11);
            this.uxCustomerId.Margin = new System.Windows.Forms.Padding(2);
            this.uxCustomerId.Name = "uxCustomerId";
            this.uxCustomerId.Size = new System.Drawing.Size(354, 26);
            this.uxCustomerId.TabIndex = 35;
            this.uxCustomerId.TextChanged += new System.EventHandler(this.uxReceiptId_TextChanged);
            // 
            // btnFindReceipt
            // 
            this.btnFindReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindReceipt.Location = new System.Drawing.Point(124, 131);
            this.btnFindReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindReceipt.Name = "btnFindReceipt";
            this.btnFindReceipt.Size = new System.Drawing.Size(232, 28);
            this.btnFindReceipt.TabIndex = 48;
            this.btnFindReceipt.Text = "Find Receipt";
            this.btnFindReceipt.UseVisualStyleBackColor = true;
            this.btnFindReceipt.Click += new System.EventHandler(this.btnFindReceipt_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(360, 131);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(118, 28);
            this.btnFinish.TabIndex = 50;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 170);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnFindReceipt);
            this.Controls.Add(this.uxEmailLabel);
            this.Controls.Add(this.uxLastNameLabel);
            this.Controls.Add(this.uxFirstNameLabel);
            this.Controls.Add(this.uxCustomerIdLabel);
            this.Controls.Add(this.uxEmail);
            this.Controls.Add(this.uxLastName);
            this.Controls.Add(this.uxFirstName);
            this.Controls.Add(this.uxCustomerId);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uxEmailLabel;
        private System.Windows.Forms.Label uxLastNameLabel;
        private System.Windows.Forms.Label uxFirstNameLabel;
        private System.Windows.Forms.Label uxCustomerIdLabel;
        private System.Windows.Forms.TextBox uxEmail;
        private System.Windows.Forms.TextBox uxLastName;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.TextBox uxCustomerId;
        private System.Windows.Forms.Button btnFindReceipt;
        private System.Windows.Forms.Button btnFinish;
    }
}