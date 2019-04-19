using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    public class Order
    {
        private int orderId;

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

        //This constructor is used to make a full order given a list of Order Lines
        public Order(OrderLine[] orderList, int orderId, int customerId)
        {
            this.OrderList = orderList;
            this.OrderID = orderId;
            this.CustomerID = customerId;
        }

        //return customer information from a given order
        public Order()
        {

        }
    }
}