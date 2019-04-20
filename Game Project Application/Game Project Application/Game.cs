using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    public class Game
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
        public Game(string title, string genre, string price, int quantity, string isUsed, int storeId, int gameId)
        {
            this.Title = title;
            this.Genre = genre;
            this.Price = price;
            this.Quantity = quantity;
            this.IsUsed = isUsed;
            this.StoreId = storeId;
            this.GameId = gameId;
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
