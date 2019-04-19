using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    public class Order
    {

        private OrderLine[] orderList;
        public OrderLine[] OrderList
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

        //This constructor is used to make a full order given a list of Order Lines
        public Order(OrderLine[] orderList, int orderId, int customerId)
        {
            this.OrderList = orderList;
            this.OrderID = orderId;
            this.CustomerID = customerId;
            total = 0;
            foreach(OrderLine orderLine in orderList)
            {
                total += orderLine.Quantity * orderLine.Price;
            }
        }

        //return customer information from a given order
        public Order(int orderId, string first, string last, string email, int quantity, double total)
        {
            this.OrderID = orderId;
            
        }
    }
}