using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV2.Models
{
    class Order
    {
        public long OrderId { get; set; }
        public long OrderAmount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
