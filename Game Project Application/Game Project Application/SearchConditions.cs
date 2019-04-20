using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    public class SearchConditions
    {
        private string title;
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }
        private string genre;
        public string Genre
        {
            get
            {
                return this.genre;
            }
            set
            {
                this.genre = value;
            }
        }
        private double minPrice;
        public double MinPrice
        {
            get
            {
                return this.minPrice;
            }
            set
            {
                this.minPrice = value;
            }
        }

        private double maxPrice;
        public double MaxPrice
        {
            get
            {
                return this.maxPrice;
            }
            set
            {
                this.maxPrice = value;
            }
        }

        private int isUsed;
        public int IsUsed
        {
            get
            {
                return this.isUsed;
            }
            set
            {
                this.isUsed = value;
            }
        }
        private int storeId;
        public int StoreId
        {
            get
            {
                return this.storeId;
            }
            set
            {
                this.storeId = value;
            }
        }
        private int orderId;
        public int OrderId
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

        public SearchConditions(string title, string genre, double minPrice, double maxPrice, int isUsed, int storeId)
        {
            this.title = title;
            this.genre = genre;
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
            this.isUsed = isUsed;
            this.storeId = storeId;
        }


        //return customer information from a given order
        public SearchConditions(int orderId, string first, string last, string email)
        {
            this.OrderId = orderId;
            this.First = first;
            this.Last = last;
            this.Email = email;
        }
    }
}
