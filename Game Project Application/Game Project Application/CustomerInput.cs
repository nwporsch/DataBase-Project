using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Project_Application
{
    public partial class CustomerInput : Form
    {

        private GameApplication ga;

        public CustomerInput(GameApplication ga)
        {
            InitializeComponent();
            this.ga = ga;
        }

        //Handles a click event on the Input button, takes given input and creates a new Customer
        private void btnInput_Click(object sender, EventArgs e)
        {
            string first;
            string last;
            string email;
            string address;
            string city;
            string state;
            bool foundCustomerId = false;
            bool legitCustomer = false;
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
                string connectionString = "Server=mssql.cs.ksu.edu;Database=cis560_team21; Integrated Security=true";

                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("GameStore.CreateCustomer", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("FirstName", c.First);
                        command.Parameters.AddWithValue("LastName", c.Last);
                        command.Parameters.AddWithValue("Email", c.Email);
                        command.Parameters.AddWithValue("Address", c.Address);
                        command.Parameters.AddWithValue("City", c.City);
                        command.Parameters.AddWithValue("State", c.State);
                        connection.Open();

                        try
                        {
                            int k = command.ExecuteNonQuery();
                            connection.Close();
                            if (k != 0)
                            {
                                MessageBox.Show("Added to our system!");
                            }
                        }
                        catch(Exception)
                        {
                            legitCustomer = getCustomer(c);
                            foundCustomerId = true;
                        }

                        if (!foundCustomerId)
                        {
                            legitCustomer = getCustomer(c);
                        }

                        
                    }

                    this.Close();
                    if (legitCustomer)
                    {
                        ga.CreateOrder();
                    }
                    

                }
            }
        }
        //Establishes a connection to the database and adds a new customer to the database then returns true, if there is a duplicate email then it fails and returns false
        private bool getCustomer(Customer c)
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=cis560_team21; Integrated Security=true";
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("GameStore.GetCustomerId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Email", c.Email);
                    command.Parameters.AddWithValue("FirstName", c.First);
                    command.Parameters.AddWithValue("LastName", c.Last);
                    connection.Open();

                    var k = command.ExecuteReader();
                    k.Read();
                    int cid = k.GetInt32(k.GetOrdinal("CustomerId"));
                    k.Close();
                    c.CustomerId = cid;

                    if(c.CustomerId > 0)
                    {
                        ga.Customer = c;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Email already exists with a different user.");
                        this.Close();
                        return false;
                    }
                }
            }
        }
    }
}
