using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenv1.Models
{
    interface IAuditable
    {
        DateTime CreatedAt { get;}
        DateTime UpdatedAt { get;}
    }
}
