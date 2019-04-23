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

        private void btnFindReceipt_Click(object sender, EventArgs e)
        {
            string first;
            string last;
            string email;
            int receiptId;
            SearchConditions o;
            if (uxReceiptId.Text == "")
            {
                MessageBox.Show("Please enter a Receipt Id.");
            }
            else
            {
                receiptId = Convert.ToInt32(uxReceiptId.Text);

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
                o = new SearchConditions(receiptId, first, last, email);
                searchWindow = new ReceiptSearchResults(this, o);
                searchWindow.ShowDialog();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxReceiptId_TextChanged(object sender, EventArgs e)
        {
            int index = uxReceiptId.SelectionStart;
            string text = uxReceiptId.Text;
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
                    uxReceiptId.Text = text;
                    if (index > 0)
                    {
                        uxReceiptId.SelectionStart = index - 1;
                    }
                    else
                    {
                        uxReceiptId.SelectionStart = index;
                    }
                }
            }
        }
    }
}
