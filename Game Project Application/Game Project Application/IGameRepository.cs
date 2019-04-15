using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    interface IGameRepository
    {
        IReadOnlyList<Game> RetrieveGames();

        Game GetGame(int gameId);

    }
}
