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
            }
        }
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

        //This constructor is used to make a full order given a list of Order Lines
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
                orderLine.SendToDatabase(orderId);
                total += orderLine.Quantity * orderLine.Price;
            }
        }

        //an order joined with other info, to be displayed
        public Order(int orderId, string first, string last, string email, int count, double total)
        {
            this.OrderID = orderId;
            this.First = first;
            this.Last = last;
            this.Email = email;
            this.Count = count;
            this.Total = total;
        }
    }
}