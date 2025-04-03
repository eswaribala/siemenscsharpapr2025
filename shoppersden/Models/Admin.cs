using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden.Models
{
    class Admin:Person
    {
        public Admin(string name, string password,string adminId) : base(name, password)
        {
            AdminID = adminId;
        }

        public string AdminID { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", AdminID: " + AdminID;
        }
    }
}
