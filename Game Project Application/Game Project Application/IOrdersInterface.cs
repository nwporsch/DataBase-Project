using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    /// <summary>
    /// Interface for the Orders Object
    /// </summary>
    interface IOrdersInterface
    {
        /// <summary>
        /// The interface method for the RetrieveOrders method in the Orders object
        /// </summary>
        /// <returns></returns>
        IReadOnlyList<Order> RetrieveOrders();

        /// <summary>
        /// The interface method for the GetOrder method in the Orders object
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        Order GetOrder(int orderId);
    }
}
