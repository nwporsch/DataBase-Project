using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Project_Application
{
    /// <summary>
    /// GameRepository retrieves a list of games based off given conditions from the database.
    /// </summary>
    class GameRepository : IGameRepository
    {
        /// <summary>
        /// When provided a SearchConditions object the method may query the database for any game with the given search conditions.
        /// </summary>
        /// <param name="sc">Search Condition Object which holds the conditions from the user for search games.</param>
        /// <returns>A list of games that match the criteria given by the Search Conditions object</returns>
        public List<Game> RetrieveGames(SearchConditions sc)
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=cis560_team21; Integrated Security=true";
            string condition = "";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("GameStore.RetrieveGames", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        if (sc.IsUsed == 0)
                        {
                            condition = "New";
                        }
                        else if (sc.IsUsed == 1)
                        {
                            condition = "Used";
                        }
                        else
                        {
                            condition = "*";
                        }


                        command.Parameters.AddWithValue("Title", sc.Title);
                        command.Parameters.AddWithValue("Genre", sc.Genre);
                        command.Parameters.AddWithValue("MinPrice", sc.MinPrice);
                        command.Parameters.AddWithValue("MaxPrice", sc.MaxPrice);
                        command.Parameters.AddWithValue("StoreId", sc.StoreId);
                        command.Parameters.AddWithValue("IsUsed", condition);
                        command.Parameters.AddWithValue("Platform", sc.Platform);
                        connection.Open();

                        var reader = command.ExecuteReader();

                        var gameList = new List<Game>();

                        while (reader.Read())
                        {


                            if (reader.GetBoolean(reader.GetOrdinal("Condition")) == true)
                            {
                                condition = "used";
                            }
                            else
                            {
                                condition = "new";
                            }

                            gameList.Add(new Game(
                               reader.GetString(reader.GetOrdinal("Title")),
                               reader.GetString(reader.GetOrdinal("GenreName")),
                               reader.GetString(reader.GetOrdinal("PlatformName")),
                               reader.GetDecimal(reader.GetOrdinal("UnitPrice")).ToString(),
                               reader.GetInt32(reader.GetOrdinal("Quantity")),
                               condition,
                               reader.GetInt32(reader.GetOrdinal("StoreId")),
                               reader.GetInt32(reader.GetOrdinal("GameStoreInfoId"))));
                        }

                        return gameList;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect to database.");
            }
        }
    }
}
