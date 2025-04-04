using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden.Models
{
   public class Admin:Person
    {
        public Admin(string name, string adminId) : base(name)
        {
            AdminID = adminId;
        }

        public string AdminID { get; set; }

        public override string GeneratePassword()
        {
            return "A-"+Faker.Identification.MedicareBeneficiaryIdentifier();
        }

        public override string ToString()
        {
            return base.ToString() + ", AdminID: " + AdminID;
        }
    }
}
