using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    /// <summary>
    /// Object referring to a specific Game and its attributes
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The title of the game
        /// </summary>
        private string title;

        /// <summary>
        /// Getter and Setters for title
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
        /// The Genre of the game
        /// </summary>
        private string genre;

        /// <summary>
        /// Getter and Setters for genre
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
        /// The price of the game
        /// </summary>
        private string price;

        /// <summary>
        /// Getter and Setter for price
        /// </summary>
        public string Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        /// <summary>
        /// The condition of the game. The game can either be new or used.
        /// </summary>
        private string isUsed;

        /// <summary>
        /// Getter and Setters for isUsed
        /// </summary>
        public string IsUsed
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
        /// The platform for the game
        /// </summary>
        private string platform;

        /// <summary>
        /// Getter and Setters for platform
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
        /// The storeId that holds this store
        /// </summary>
        private int storeId;

        /// <summary>
        /// Getter and setters for StoreId
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
        /// The identifier for the game in the database
        /// </summary>
        private int gameId;

        /// <summary>
        /// Getter and setter for gameId
        /// </summary>
        public int GameId
        {
            get
            {
                return this.gameId;
            }
            set
            {
                this.gameId = value;
            }
        }

        /// <summary>
        /// The quantity of this game stored in the database.
        /// </summary>
        private int quantity;

        /// <summary>
        /// Getter and Setter of quantity
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
        /// This constructor is used when the data from the sql database is pulled down for a search
        /// </summary>
        public Game(string title, string genre, string platform, string price, int quantity, string isUsed, int storeId, int gameId)
        {
            this.Title = title;
            this.Genre = genre;
            this.Price = price;
            this.Quantity = quantity;
            this.IsUsed = isUsed;
            this.StoreId = storeId;
            this.GameId = gameId;
            this.Platform = platform;
        }

        /// <summary>
        /// This constructor is the default if all data is known except title
        /// </summary>
        public Game(string genre, string price, string isUsed, int storeId)
        {
            this.Title = "*";
            this.Genre = genre;
            this.Price = price;
            this.IsUsed = isUsed;
            this.StoreId = storeId;
        }

        /// <summary>
        /// This constructor is used if only the title and condition is known
        /// </summary>
        public Game(string title, string isUsed, int storeId)
        {
            this.Title = title;
            this.IsUsed = isUsed;
            this.Genre = "*";
            this.Price = "*";
            this.StoreId = storeId;
        }

    }
}
