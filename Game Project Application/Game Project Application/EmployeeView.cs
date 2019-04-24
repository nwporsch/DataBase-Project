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
    public partial class EmployeeView : Form
    {

        private ReceiptSearchResults searchWindow;
        public EmployeeView()
        {
            InitializeComponent();
        }
        //Handles a click event on the Find Receipt Button, Takes given input and creates a new SearchConditions then opens a window that displays the customer that was searched for
        private void btnFindReceipt_Click(object sender, EventArgs e)
        {
            string first;
            string last;
            string email;
            int customerId;
            SearchConditions c;
            if (uxCustomerId.Text == "")
            {
                MessageBox.Show("Please enter a Receipt Id.");
            }
            else
            {
                customerId = Convert.ToInt32(uxCustomerId.Text);

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
        }
        //Closes the Window
        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Handles a TextChange Event on the ReceiptId text box
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
