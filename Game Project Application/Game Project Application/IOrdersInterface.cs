using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    interface IOrdersInterface
    {
        IReadOnlyList<Order> RetrieveOrders();

        Order GetOrder(int orderId);
    }
}
