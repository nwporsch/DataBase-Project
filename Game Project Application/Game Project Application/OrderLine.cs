using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                return this.title;
            }
            set
            {
                this.title = value;
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

        public void SendToDatabase(int orderId)
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=cis560_team21; Integrated Security=true";

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("GameStore.CreateOrderLines", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //OrderId GameId Quantity Unit Price
                    command.Parameters.AddWithValue("OrderId", orderId);
                    command.Parameters.AddWithValue("GameStoreInfoId", gameId);
                    command.Parameters.AddWithValue("Quantity", quantity);
                    command.Parameters.AddWithValue("UnitPrice", price);
                    connection.Open();

                    int k = command.ExecuteNonQuery();
                    connection.Close();


                }
            }
        }

        //This constructor is given all the information need for one purchase made of a certain game
        public OrderLine(string title, int quantity, double price, int gameId, int storeId)
        {
            this.Title = title;
            this.Quantity = quantity;
            this.Price = price;
            this.GameID = gameId;
            this.StoreID = storeId;
        }


    }
}
