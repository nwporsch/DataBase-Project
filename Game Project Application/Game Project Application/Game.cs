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
        /// Game Title
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
        /// Game Genre
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
        /// Game Price
        /// </summary>
        private string price;
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
        /// Game Condition (new or used)
        /// </summary>
        private string isUsed;
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
        /// Game Platform
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
        /// Game StoreId
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
        /// Game GameId
        /// </summary>
        private int gameId;
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
        /// Game Quantity
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
