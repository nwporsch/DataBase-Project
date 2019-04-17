using System;
using System.Collections.Generic;
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
        public List<Game> GetGame(Game g)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Game> RetrieveGames()
        {
            throw new NotImplementedException();
        }
    }
}
