using ShoppersDenV2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3
{
    class NonGenericArrayList
    {
        static void Main(string[] args)
        {
            int number = 100;
            object data = number;
            IList list = new ArrayList();
            list.Add("Parameswari");
            list.Add(560000);
            list.Add(158.5F);
            list.Add(true);
            list.Add(data);
            list.Add('A');
            list.Add(new Order());
            IEnumerator enumerator = list.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

           
            

        }
    }
}
