using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int number = Faker.RandomNumber.Next(1, 10);
            Console.WriteLine($"Generated Number={number}");
            int reminder = 0;
            while (number > 0)
            {
                reminder = number % 2;
                stack.Push(reminder);
                number = number / 2;
            }

            Console.WriteLine($"Stack Size{stack.Count}");
            Console.Write($"Binary Number=");
            while (stack.Count > 0)
            {
                Console.Write($"{stack.Pop()}");
            }
        }
    }
}
