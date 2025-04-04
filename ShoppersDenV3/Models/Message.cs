using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3.Models
{
    class Message
    {
        public int MessageId { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }

        public override string ToString()
        {
            return MessageId+ " " + Sender + " " + Receiver + " " + Content;
        }
    }
}
