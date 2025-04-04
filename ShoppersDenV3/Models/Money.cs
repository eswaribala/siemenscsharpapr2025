using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3.Models
{
    //immutability
    //value type
    //no inheritance
    //faster retrieval
    //thread safety
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
