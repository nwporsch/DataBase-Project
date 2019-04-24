using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    /// <summary>
    /// Represents an object or series of the same object purchased by a customer in a given order.
    /// </summary>
    public class OrderLine
    {

        /// <summary>
        /// The identifier for the Orderline Object
        /// </summary>
        private int orderLineId;

        /// <summary>
        /// The getter and setter functions to access the orderLineId
        /// </summary>
        public int OrderLineId
        {
            get
            {
                return this.orderLineId;
            }
            set
            {
                this.orderLineId = value;
            }
        }

        /// <summary>
        /// The title of the game being purchased
        /// </summary>
        private string title;

        /// <summary>
        /// The getter and setter functions to access the title
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
        /// The number of the specific game the customer purchased.
        /// </summary>
        private int quantity;

        /// <summary>
        /// The getter and setter functions to access the quantity
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
        /// The Unit price of the item being ordered by the customer
        /// </summary>
        private double price;

        /// <summary>
        /// The getter and setter functions to access the price
        /// </summary>
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


        /// <summary>
        /// The identifier of the game object to this specific orderLine
        /// </summary>
        private int gameId;

        /// <summary>
        /// The getter and setter functions to access the gameId
        /// </summary>
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

        /// <summary>
        /// The identifier for the store where the customer purchased his order
        /// </summary>
        private int storeId;

        /// <summary>
        /// getter and setter functions for storeId
        /// </summary>
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

        /// <summary>
        /// The identifier for the order connected to this orderline
        /// </summary>
        private int orderId;

        /// <summary>
        /// getter and setter functions for orderId
        /// </summary>
        public int OrderID
        {
            get
            {
                return this.orderId;
            }
            set
            {
                this.orderId = value;
            }
        }

        /// <summary>
        /// When given an orderId the orderline will then be sent to the database to be added to the system.
        /// </summary>
        /// <param name="orderId">The identifier of the order for the specific orderline</param>
        public void SendToDatabase()
        {

            string connectionString = "Server=mssql.cs.ksu.edu;Database=cis560_team21; Integrated Security=true";
            GetOrderLineId();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("GameStore.CreateOrderLines", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //OrderId GameId Quantity Unit Price
                    command.Parameters.AddWithValue("OrderId", orderId);
                    command.Parameters.AddWithValue("OrderLineId", orderLineId);
                    command.Parameters.AddWithValue("GameStoreInfoId", gameId);
                    command.Parameters.AddWithValue("Quantity", quantity);
                    command.Parameters.AddWithValue("UnitPrice", price);
                    connection.Open();

                    int k = command.ExecuteNonQuery();
                    connection.Close();


                }
            }
        }
        /// <summary>
        /// Establishes a connection to the database then gets an OrderLine
        /// </summary>
        public void GetOrderLineId()
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=cis560_team21; Integrated Security=true";

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("GameStore.GetOrderLineId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //OrderId GameId Quantity Unit Price
                    command.Parameters.AddWithValue("OrderId", orderId);
                    command.Parameters.AddWithValue("GameStoreInfoId", gameId);
                    connection.Open();

                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        orderLineId = reader.GetInt32(reader.GetOrdinal("OrderLineId"));
                    }
                    else
                    {
                        orderLineId = -1;
                    }

                    connection.Close();


                }
            }
        }

        /// <summary>
        /// The constructor for an orderline object
        /// </summary>
        /// <param name="title">The title of the game being purchased</param>
        /// <param name="quantity">How many of the specific game are being purchased</param>
        /// <param name="price">The unit price of the game</param>
        /// <param name="gameId">The gameId of the game being purchased</param>
        /// <param name="storeId">The storeId for where the game was purchased</param>
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
