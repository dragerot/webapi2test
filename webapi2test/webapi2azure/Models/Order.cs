using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapi2azure.Models
{
    public class Order
    {
        Dictionary<string, OrderItem> orderItems;
    }

    public class OrderItem
    {
        Order item { get; set; }
        int amount { get; set; }
    }

    public class Item
    {
        string id { get; set; }
        string name { get; set; }
    }
    
}
