using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    public class OrderLine
    {
        private int orderLineId;
        private string title;
        public string Title
        {   
            get
            {
                return this.Title;
            }
            set
            {
                this.Title = value;
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
        private double price;
        public double Price
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
        private int gameId;
        public int GameID
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
        private int storeId;
        public int StoreID
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

        //This constructor is given all the information need for one purchase made of a certain game
        public OrderLine(string title, int quantity, double price, int gameId, int storeId)
        {

        }


    }
}
