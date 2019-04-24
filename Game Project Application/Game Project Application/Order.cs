using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    public class Order
    {
        /// <summary>
        /// Order OrderList
        /// </summary>
        private ArrayList orderList;
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
        /// Order OrderID
        /// </summary>
        private int orderId;
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
        /// Order CustomerID
        /// </summary>
        private int customerId;
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
        /// Order RunningTotal
        /// </summary>
        private double runningTotal;
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
        /// Order Total
        /// </summary>
        private double total;
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
        /// Order First Name
        /// </summary>
        private string first;
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
        /// Order Last Name
        /// </summary>
        private string last;
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
        /// Order Email
        /// </summary>
        private string email;
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
        /// Order Quantity
        /// </summary>
        private int quantity;
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
        /// Order Count
        /// </summary>
        private int count;
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
                orderLine.SendToDatabase();
                total += orderLine.Quantity * orderLine.Price;
            }
        }

        /// <summary>
        /// an order joined with other info, to be displayed
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="orderId"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="email"></param>
        /// <param name="runningTotal"></param>
        /// <param name="total"></param>
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