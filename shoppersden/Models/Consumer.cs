using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden.Models
{
  public  class Consumer:Person
    {
        public Consumer(string name, string phoneNo) : base(name)
        {
            PhoneNo = phoneNo;
        }

        public string PhoneNo { get; set; }

        public override string GeneratePassword()
        {
            return "C-"+Faker.Identification.MedicareBeneficiaryIdentifier();

        }

        public override string ToString()
        {
            return base.ToString()+" " + PhoneNo;
        }
    }
}
