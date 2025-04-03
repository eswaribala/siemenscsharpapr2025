using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden.Models
{
    abstract class Person
    {
        protected string Name { get; set; }
        public string Password { get; set; }

        public Person(string name)
        {
            Name = name;
            
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Password: " + Password;
        }
        // Abstract method
        public abstract string GeneratePassword();
    }
}
