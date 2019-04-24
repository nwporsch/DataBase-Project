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
    /// OrderRepository retrieves a list of orders based off given conditions from the database.
    /// </summary>
    class OrderRepository : IOrderRepository
    {
        /// <summary>
        /// When provided a SearchConditions object, the method may query the database for any order with the given search conditions.
        /// </summary>
        /// <param name="sc">Search Condition Object which holds the conditions from the user for searching orders.</param>
        /// <returns>A list of orders that match the criteria given by the Search Conditions object</returns>
        public List<Order> RetrieveOrders(SearchConditions sc)
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=cis560_team21; Integrated Security=true";

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("GameStore.RetrieveCustomerOrders", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;



                    command.Parameters.AddWithValue("CustomerId", sc.CustomerId);
                    command.Parameters.AddWithValue("First", sc.First);
                    command.Parameters.AddWithValue("Last", sc.Last);
                    command.Parameters.AddWithValue("Email", sc.Email);
                    connection.Open();
                    
                    var reader = command.ExecuteReader();
                    
                    var orderList = new List<Order>();

                    while (reader.Read())
                    {
                        orderList.Add(new Order(
                            reader.GetInt32(reader.GetOrdinal("CustomerId")),
                            reader.GetInt32(reader.GetOrdinal("OrderId")),
                            reader.GetString(reader.GetOrdinal("FirstName")),
                            reader.GetString(reader.GetOrdinal("LastName")),
                            reader.GetString(reader.GetOrdinal("Email")),
                            Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("RunningTotal"))),
                            Convert.ToDouble(reader.GetDecimal(reader.GetOrdinal("OrderTotal")))));
                    }
                    
                    return orderList;
                }
            }
        }
    }
}
