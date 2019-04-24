using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    /// <summary>
    /// Interface for the OrderRepository Object
    /// </summary>
    interface IOrderRepository
    {
        /// <summary>
        /// When provided a SearchCondition object the method will return a list of orders that match the criteria
        /// </summary>
        /// <param name="sc"></param>
        /// <returns>return a list of orders that match the criteria</returns>
        List<Order> RetrieveOrders(SearchConditions sc);
    }
}
