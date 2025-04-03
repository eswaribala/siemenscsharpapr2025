using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden.Models
{
    class CustomerSorter : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
