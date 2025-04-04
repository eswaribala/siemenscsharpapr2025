using ShoppersDenV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue<Message> messages = new Queue<Message>();
            Message message = null;
            for (int i = 0; i < 10; i++)
            {
                message = new Message();
                message.MessageId = Faker.RandomNumber.Next(1, 100);
                message.Sender=Faker.Name.FullName();
                message.Receiver = Faker.Name.FullName();
                message.Content = Faker.Lorem.Sentence();
                message.TimeStamp=DateTime.Now;
                messages.Enqueue(message);
                BitArrayDemo.AddQueueState(i, true);

            }

            int count = 0;
            while(messages.Count > 0)
            {
                count = messages.Count;
                Console.WriteLine(messages.Dequeue());
                BitArrayDemo.AddQueueState(count+10, false);
            }

            BitArrayDemo.PrintQueueState();
        }
    }
}
