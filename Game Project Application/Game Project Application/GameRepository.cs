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

                    connection.Open();

                    var reader = command.ExecuteReader();

                    var gameList = new List<Game>();

                    while (reader.Read())
                    {
                        gameList.Add(new Game(
                           reader.GetString(reader.GetOrdinal("Title")),
                           reader.GetString(reader.GetOrdinal("Genre")),
                           reader.GetString(reader.GetOrdinal("UnitPrice")),
                           reader.GetString(reader.GetOrdinal("Quantity")),
                           reader.GetString(reader.GetOrdinal("IsUsed")),
                           reader.GetInt32(reader.GetOrdinal("storeId")),
                           reader.GetInt32(reader.GetOrdinal("gameId"))));
                    }

                    return gameList;
                }
            }
        }
    }
}
