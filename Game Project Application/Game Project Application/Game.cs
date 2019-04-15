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
        private string genre;
        private string price;
        private string isUsed;
        private int storeId;
        private int gameId;

        /// <summary>
        /// This constructor is used when the data from the sql database is pulled down for a search
        /// </summary>
        public Game(string title, string genre, string price, string isUsed, int storeId, int gameId)
        {
            this.title = title;
            this.genre = genre;
            this.price = price;
            this.isUsed = isUsed;
            this.storeId = storeId;
            this.gameId = gameId;

        }

        /// <summary>
        /// This constructor is the default if all data is known except title
        /// </summary>
        public Game(string genre, string price, string isUsed, int storeId)
        {
            this.title = "*";
            this.genre = genre;
            this.price = price;
            this.isUsed = isUsed;
            this.storeId = storeId;

        }

        /// <summary>
        /// This constructor is used if only the title and condition is known
        /// </summary>
        public Game(string title, string isUsed, int storeId)
        {
            this.title = title;
            this.isUsed = isUsed;
            this.genre = "*";
            this.price = "*";
            this.storeId = storeId;
        }

    }
}
