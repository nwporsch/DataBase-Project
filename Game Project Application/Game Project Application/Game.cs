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



        public Game(string title, string genre, string price, string isUsed)
        {
            this.title = title;
            this.genre = genre;
            this.price = price;
            this.isUsed = isUsed;

        }

        public Game(string title, string isUsed)
        {
            this.title = title;
            this.isUsed = isUsed;
            this.genre = "*";
            this.price = "*";
        }

    }
}
