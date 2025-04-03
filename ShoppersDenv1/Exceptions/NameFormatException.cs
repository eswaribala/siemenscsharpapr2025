using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenv1.Exceptions
{
    class NameFormatException : ApplicationException
    {
        public NameFormatException()
        {
        }

        public NameFormatException(string message) : base(message)
        {
        }
    }
}
