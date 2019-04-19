using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_Application
{
    interface IOrderRepository
    {
        List<Order> RetrieveOrders(SearchConditions sc);
    }
}
