﻿using System;
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
    public partial class ReceiptSearchResults : Form
    {
        private EmployeeView ev;
        public ReceiptSearchResults(EmployeeView ev, SearchConditions o)
        {
            this.ev = ev;

            OrderRepository or = new OrderRepository();
            List<Order> lo = or.RetrieveOrders(o);

            InitializeComponent();
            foreach (Order order in lo)
            {
                string[] s = { order.OrderID.ToString(), order.First, order.Last, order.Email, order.Count.ToString(), order.Total.ToString() };
                this.uxResults.Rows.Add(s);
            }
        }
    }
}
