using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    interface IGameRepository
    {
        List<Game> RetrieveGames(Game g);

        List<Game> GetGame();

        Game CreateGame(int StoreId, string Title, decimal UnitPrice, bool IsUsed, int Quantity);
    }
}
