using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    /// <summary>
    /// Interface for the GameRepository Object.
    /// </summary>
    interface IGameRepository
    {
        /// <summary>
        /// When provided a searchcondition object the method will return a list of game object that match the criteria.
        /// </summary>
        /// <param name="sc">A Search Condtion object with the provided criteria</param>
        /// <returns>A list of games that match the criteria.</returns>
        List<Game> RetrieveGames(SearchConditions sc);

    }
}
