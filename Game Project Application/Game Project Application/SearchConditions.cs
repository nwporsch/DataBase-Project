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

        public SearchConditions(string title, string genre, double minPrice, double maxPrice, int isUsed, int storeId)
        {
            this.title = title;
            this.genre = genre;
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
            this.isUsed = isUsed;
            this.storeId = storeId;
        }

    }
}
