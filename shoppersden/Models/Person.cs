using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden.Models
{
    class Person
    {
        protected string Name { get; set; }
        protected string Password { get; set; }

        public Person(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Password: " + Password;
        }
    }
}
