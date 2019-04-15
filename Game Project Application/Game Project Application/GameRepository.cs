using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    class GameRepository : IGameRepository
    {
        public Game GetGame(int gameId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Game> RetrieveGames()
        {
            throw new NotImplementedException();
        }
    }
}
