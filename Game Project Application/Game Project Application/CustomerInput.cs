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

            if (uxAddress.Text == "")
            {
                address = "*";
            }
            else
            {
                address = uxAddress.Text;
            }

            if (uxCity.Text == "")
            {
                city = "*";
            }
            else
            {
                city = uxCity.Text;
            }

            if (uxState.Text == "")
            {
                state = "*";
            }
            else
            {
                state = uxState.Text;
            }
            c = new Customer(first, last, email, address, city, state);
        }
    }
}
