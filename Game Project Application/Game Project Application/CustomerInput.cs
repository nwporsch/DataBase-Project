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
    public partial class CustomerInput : Form
    {
        public CustomerInput()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string first;
            string last;
            string email;
            string address;
            string city;
            string state;
            Customer c;
            if (uxEmail.Text == "")
            {
                MessageBox.Show("Please enter an Email address.");
            }
            else
            {
                email = uxEmail.Text;
                last = uxLastName.Text;
                first = uxFirstName.Text;
                address = uxAddress.Text;
                city = uxCity.Text;
                state = uxState.Text;
                c = new Customer(first, last, email, address, city, state);
            }
        }
    }
}
