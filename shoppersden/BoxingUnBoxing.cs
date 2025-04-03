using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden
{
    class BoxingUnBoxing
    {
        static void Main(string[] args)
        {
            //value type
            //stack
            long ProductId = Faker.RandomNumber.Next(5000, 100000);
            //ref type
            //heap
            //Boxing
            object ProductCode1 = ProductId;
            object ProductCode2 = ProductId;
            Console.WriteLine("ProductCode: " + ProductCode1);
            Console.WriteLine("ProductCode: " + ProductCode2);
            if (ProductCode1 == ProductCode2)
            {
                Console.WriteLine("ProductCode1 and ProductCode2 are equal");
            }
            else
            {
                Console.WriteLine("ProductCode1 and ProductCode2 are not equal");
            }
            
            //UnBoxing
            long ProductId1 = (long)ProductCode1;

        }
    }
}
