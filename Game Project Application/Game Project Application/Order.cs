using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Project_Application
{
    public class Order
    {
        /// <summary>
        /// Holds a list of order objects
        /// </summary>
        private ArrayList orderList;

        /// <summary>
        /// When an orderLine is added to the orderList their orderId's are set to this object's orderId
        /// </summary>
        public ArrayList OrderList
        {
            get
            {
                return this.orderList;
            }
            set
            {
                this.orderList = value;
                foreach (OrderLine ol in orderList)
                {
                    ol.OrderID = orderId;
                }
            }
        }
        /// <summary>
        ///The identifier of the order object
        /// </summary>
        private int orderId;

        /// <summary>
        /// The getter and setter functions for the orderId
        /// </summary>
        public int OrderID
        {
            get
            {
                return this.orderId;
            }
            set
            {
                this.orderId = value;
            }
        }
        /// <summary>
        /// The customerId related to this order object
        /// </summary>
        private int customerId;

        /// <summary>
        /// Getter and setters for customerIds
        /// </summary>
        public int CustomerID
        {
            get
            {
                return this.customerId;
            }
            set
            {
                this.customerId = value;
            }
        }
        /// <summary>
        /// The running total based off all the orderLines in the order
        /// </summary>
        private double runningTotal;

        /// <summary>
        /// Getter and Setter for runningtotal
        /// </summary>
        public double RunningTotal
        {
            get
            {
                return this.runningTotal;
            }
            set
            {
                this.runningTotal = value;
            }
        }
        /// <summary>
        /// The sum total of all the orderLines added together
        /// </summary>
        private double total;

        /// <summary>
        /// Getter and Setters
        /// </summary>
        public double Total
        {
            get
            {
                return this.total;
            }
            set
            {
                this.total = value;
            }
        }
        /// <summary>
        /// The Firstname of the customer associated with this order
        /// </summary>
        private string first;
        
        /// <summary>
        /// Getter and Setters to the firstname
        /// </summary>
        public string First
        {
            get
            {
                return this.first;
            }
            set
            {
                this.first = value;
            }
        }

        /// <summary>
        /// The Lastname of the customer associated with this order
        /// </summary>
        private string last;

        /// <summary>
        /// Getter and Setters to the last variable
        /// </summary>
        public string Last
        {
            get
            {
                return this.last;
            }
            set
            {
                this.last = value;
            }
        }
        /// <summary>
        /// Email of the customer associated with this order
        /// </summary>
        private string email;

        /// <summary>
        /// Getter and Setter for email
        /// </summary>
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        /// <summary>
        /// The total number of items purchased in this order
        /// </summary>
        private int quantity;

        /// <summary>
        /// Getter and Setter for quantity
        /// </summary>
        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }

        /// <summary>
        /// The number of orderLines in the order.
        /// </summary>
        private int count;

        /// <summary>
        /// Getter and Setters for count
        /// </summary>
        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
            }
        }

        /// <summary>
        /// This constructor is used to make a full order given a list of Order Lines
        /// </summary>
        /// <param name="c"></param>
        /// <param name="orderList"></param>
        public Order(Customer c, ArrayList orderList)
        {
            this.CustomerID = c.CustomerId;
            this.OrderList = orderList;
            string connectionString = "Server=mssql.cs.ksu.edu;Database=cis560_team21; Integrated Security=true";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("GameStore.CreateOrder", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("CustomerId", this.CustomerID);
                        connection.Open();

                        int k = command.ExecuteNonQuery();

                        connection.Close();
                    }

                    using (var command = new SqlCommand("GameStore.GetOrderId", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("CustomerId", c.CustomerId);
                        connection.Open();

                        var k = command.ExecuteReader();
                        k.Read();
                        orderId = k.GetInt32(k.GetOrdinal("OrderId"));
                        k.Close();
                    }
                }


                foreach (OrderLine orderLine in orderList)
                {
                    orderLine.OrderID = orderId;
                    orderLine.SendToDatabase();
                    total += orderLine.Quantity * orderLine.Price;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect to database.");
            }
        }

        /// <summary>
        /// A constructor for the order object if given all the information
        /// </summary>
        /// <param name="customerId">The customerId connected to this customer</param>
        /// <param name="orderId">The orderId associated with this order</param>
        /// <param name="first">The first name of the customer associated with this order</param>
        /// <param name="last">The last name of the customer associated with this order</param>
        /// <param name="email">The email of the customer associated with this order</param>
        /// <param name="runningTotal">The runningTotal of the order </param>
        /// <param name="total">The total slaes of the Order</param>
        public Order(int customerId, int orderId, string first, string last, string email, double runningTotal, double total)
        {
            this.CustomerID = customerId;
            this.OrderID = orderId;
            this.First = first;
            this.Last = last;
            this.Email = email;
            this.RunningTotal = runningTotal;
            this.Total = total;
        }
    }
}