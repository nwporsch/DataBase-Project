using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    public class Customer
    {
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
        private string address;
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        private string city;
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }
        private string state;
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        private int customerId;

        public int CustomerId
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


        public Customer(string first, string last, string email, string address, string city, string state)
        {
            this.First = first;
            this.Last = last;
            this.Email = email;
            this.Address = address;
            this.City = city;
            this.State = state;
        }
    }
}
