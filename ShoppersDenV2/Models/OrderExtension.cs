using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV2.Models
{
    static class OrderExtension
    {
        public static bool IsValidOrder(this Order order)
        {
            if (order == null) return false;
           
            if (order.OrderAmount <= 500) return false;
            
            return true;
        }
    }
}
