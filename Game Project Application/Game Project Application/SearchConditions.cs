using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    /// <summary>
    /// Object representing input search conditions when making queries to the database
    /// </summary>
    public class SearchConditions
    {
        /// <summary>
        /// SearchConditions Title
        /// </summary>
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
        /// <summary>
        /// SearchConditions Platform
        /// </summary>
        private string platform;
        public string Platform
        {
            get
            {
                return this.platform;
            }
            set
            {
                this.platform = value;
            }
        }
        /// <summary>
        /// SearchConditions Genre
        /// </summary>
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
        /// <summary>
        /// SearchConditions Minimum Price
        /// </summary>
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
        /// <summary>
        /// SearchConditions Maximum Price
        /// </summary>
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
        /// <summary>
        /// SearchConditions Game Condition (new, used)
        /// </summary>
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
        /// <summary>
        /// SearchConditions StoreID
        /// </summary>
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
        /// <summary>
        /// SearchConditions CustomerID
        /// </summary>
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
        /// <summary>
        /// SearchConditions First Name
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
        /// SearchConditions Last Name
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
        /// SearchConditions Email
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
        /// Constructor for a SearchConditions that wishes to return a game
        /// </summary>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="platform"></param>
        /// <param name="minPrice"></param>
        /// <param name="maxPrice"></param>
        /// <param name="isUsed"></param>
        /// <param name="storeId"></param>
        public SearchConditions(string title, string genre, string platform, double minPrice, double maxPrice, int isUsed, int storeId)
        {
            this.title = title.ToLower();
            this.genre = genre.ToLower();
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
            this.isUsed = isUsed;
            this.storeId = storeId;
            this.platform = platform.ToLower();
        }
        /// <summary>
        /// Constructor for a SearchConditions that wishes to return an order
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="email"></param>
        public SearchConditions(int customerId, string first, string last, string email)
        {
            this.CustomerId = customerId;
            this.First = first;
            this.Last = last;
            this.Email = email;
        }
    }
}
