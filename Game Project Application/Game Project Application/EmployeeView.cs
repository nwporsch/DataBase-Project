using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Project_Application
{
    /// <summary>
    /// EmployeeView allows an employee to look for receipts for a customer based
    /// off of their customerId, First Name, Last Name, and Email.
    /// </summary>
    public partial class EmployeeView : Form
    {
        /// <summary>
        /// A form which works in tandem with Employee View to show search results.
        /// </summary>
        private ReceiptSearchResults searchWindow;

        /// <summary>
        /// Constructor for the Employee View form.
        /// </summary>
        public EmployeeView()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles a click event on the Find Receipt Button, Takes given input and creates a new SearchConditions; 
        /// then opens a window that displays the matching customer's orders and information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindReceipt_Click(object sender, EventArgs e)
        {
            string first;
            string last;
            string email;
            int customerId;
            SearchConditions c;
            if (uxCustomerId.Text == "")
            {
                customerId = -1;
            }
            else
            {
                customerId = Convert.ToInt32(uxCustomerId.Text);
            }
            if (uxEmail.Text == "")
            {
                email = "*";
            }
            else
            {
                email = uxEmail.Text;
            }

            if (uxLastName.Text == "")
            {
                last = "*";
            }
            else
            {
                last = uxLastName.Text;
            }

            if (uxFirstName.Text == "")
            {
                first = "*";
            }
            else
            {
                first = uxFirstName.Text;
            }
            c = new SearchConditions(customerId, first, last, email);
            searchWindow = new ReceiptSearchResults(this, c);
            searchWindow.ShowDialog();
        }


        /// <summary>
        /// Button which closes the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Makes sure only numerical values are allowed in uxCustomerId text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxReceiptId_TextChanged(object sender, EventArgs e)
        {
            int index = uxCustomerId.SelectionStart;
            string text = uxCustomerId.Text;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] < '0' || text[i] > '9')
                {
                    if (i == 0)
                    {
                        text = text.Substring(1, text.Length - 1);
                    }
                    else if (i == text.Length - 1)
                    {
                        text = text.Substring(0, text.Length - 1);
                    }
                    else
                    {
                        text = text.Substring(0, i) + text.Substring(i + 1, text.Length - i - 1);
                    }
                    uxCustomerId.Text = text;
                    if (index > 0)
                    {
                        uxCustomerId.SelectionStart = index - 1;
                    }
                    else
                    {
                        uxCustomerId.SelectionStart = index;
                    }
                }
            }
        }
    }
}
