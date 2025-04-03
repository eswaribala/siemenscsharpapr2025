using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden.Models
{
    class Consumer:Person
    {
        public Consumer(string name, string password,string phoneNo) : base(name, password)
        {
            PhoneNo = phoneNo;
        }

        public string PhoneNo { get; set; }

        public override string ToString()
        {
            return base.ToString()+" " + PhoneNo;
        }
    }
}
