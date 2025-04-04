using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3
{
   class BitArrayDemo
    {
        private static BitArray bitArray= new BitArray(30);
      

       public static void AddQueueState(int pos,bool state)
        {
            if(state)
            {
                bitArray.Set(pos,true);
            }
            else
            {
                bitArray.Set(pos, false);
            }
            

        }
        public static void PrintQueueState()
        {
            IEnumerator enumerator=bitArray.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (bool.Parse(enumerator.Current.ToString()) == true)
                    Console.WriteLine("Message Enququed");
                else
                    Console.WriteLine("Message Deququed");
            }
        }
    }
}
