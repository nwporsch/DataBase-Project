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
        /// The title provided by the user to search for.
        /// </summary>
        private string title;

        /// <summary>
        /// Getter and setter for title variable
        /// </summary>
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
        /// The platform provided by the user to search for.
        /// </summary>
        private string platform;

        /// <summary>
        /// Getter and setters for the platform variable
        /// </summary>
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
        /// The genre provided by the user to search for.
        /// </summary>
        private string genre;

        /// <summary>
        /// Getter and setters for the genre variable
        /// </summary>
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
        /// The minimum price provided by the user to search for.
        /// </summary>
        private double minPrice;

        /// <summary>
        /// Getter and setters for the minPrice
        /// </summary>
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
        /// The Max Price provided by the user to search for.
        /// </summary>
        private double maxPrice;

        /// <summary>
        /// Getter and Setter for the maxPrice
        /// </summary>
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
        /// The condition of the game provided by the user to search for.
        /// </summary>
        private int isUsed;

        /// <summary>
        /// Getter and Setters for isUsed
        /// </summary>
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
        /// The identifier of the store for where to search for the games
        /// </summary>
        private int storeId;

        /// <summary>
        /// Getter and setters for storeId
        /// </summary>
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
        /// The customerId that is to be used as a search condition to find receipts.
        /// </summary>
        private int customerId;

        /// <summary>
        /// Getter and setters for customerId
        /// </summary>
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
        /// The first name of the customer to search for when looking for receipts
        /// </summary>
        private string first;

        /// <summary>
        /// Getter and Setters first
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
        ///  The last name of the customer to search for when looking for receipts
        /// </summary>
        private string last;

        /// <summary>
        /// Getter and setters for last
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
        ///The email of the customer to search for when looking for receipts
        /// </summary>
        private string email;

        /// <summary>
        /// Getter and setters for the email
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
        /// This constructor is used to hold the criteria for finding games based off the criteria
        /// </summary>
        /// <param name="title">Game of the title to be searched for</param>
        /// <param name="genre">Genre to be searched for</param>
        /// <param name="platform">The platform to be searched for</param>
        /// <param name="minPrice">The minimum price to be searched for</param>
        /// <param name="maxPrice">The maximum price to be searched for</param>
        /// <param name="isUsed">The condition of the game to be searched for</param>
        /// <param name="storeId">The storeId for where to search for the games</param>
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
        /// This constructor is used to hold the criteria for finding running total
        /// </summary>
        /// <param name="customerId">The customer id related to the orders being searched for</param>
        /// <param name="first">The first name of the customer related to the orders being searched for</param>
        /// <param name="last">The last name of the customer related to the orders being searched for</param>
        /// <param name="email">The email of the customer related to the orders being searched for</param>
        public SearchConditions(int customerId, string first, string last, string email)
        {
            this.CustomerId = customerId;
            this.First = first;
            this.Last = last;
            this.Email = email;
        }
    }
}
