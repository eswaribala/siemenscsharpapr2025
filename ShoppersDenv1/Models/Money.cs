using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenv1.Models
{
    //immutability
    //value type
    readonly struct Money
    {
        public int Notes { get; }
        public int Coins { get;}
        public Money(int notes, int coins)
        {
            Notes = notes;
            Coins = coins;
        }
    }
}
