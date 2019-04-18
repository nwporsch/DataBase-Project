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
            Order o;
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
                o = new Order();
            }
            searchWindow = new ReceiptSearchResults();
            searchWindow.ShowDialog();
        }
    }
}
