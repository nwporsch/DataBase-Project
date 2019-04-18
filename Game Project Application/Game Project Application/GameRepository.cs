using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    class GameRepository : IGameRepository
    {
        public Game CreateGame(int storeId, string gameTitle, decimal UnitPrice, bool isUsed, int quantity)
        {
            throw new NotImplementedException();
        }
        public List<Game> GetGame()
        {
            throw new NotImplementedException();
        }

        public List<Game> RetrieveGames(Game g)
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=cis560_team21; Integrated Security=true";

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("GameStore.RetrieveGames", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    string title = "ALL";
                    string genre = "ALL";

                    if (g.Title != "*")
                    {
                        title = g.Title;
                    }

                    if (g.Genre != "*")
                    {
                        genre = g.Genre;
                    }



                    command.Parameters.AddWithValue("Title", title);
                    command.Parameters.AddWithValue("Genre", genre);
                    command.Parameters.AddWithValue("UnitPrice", "*");
                    if (g.IsUsed == "Used")
                    {
                        command.Parameters.AddWithValue("IsUsed", 1);
                    }
                    else if (g.IsUsed == "New")
                    {
                        command.Parameters.AddWithValue("IsUsed", 0);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("IsUsed", '*');
                    }
                    connection.Open();

                    var reader = command.ExecuteReader();

                    var gameList = new List<Game>();

                    while (reader.Read())
                    {
                        string condition;

                        if (reader.GetBoolean(reader.GetOrdinal("IsUsed")) == true) {
                            condition = "Used";
                        }
                        else
                        {
                            condition = "New";
                        }

                        gameList.Add(new Game(
                           reader.GetString(reader.GetOrdinal("Title")),
                           "GENRE",
                           reader.GetDecimal(reader.GetOrdinal("UnitPrice")).ToString(),
                           reader.GetInt32(reader.GetOrdinal("Quantity")).ToString(),
                           condition,
                           reader.GetInt32(reader.GetOrdinal("storeId")),
                           reader.GetInt32(reader.GetOrdinal("gameId"))));
                    }

                    return gameList;
                }
            }
        }
    }
}
