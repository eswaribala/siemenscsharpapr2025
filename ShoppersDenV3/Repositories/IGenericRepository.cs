using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3.Repositories
{
    interface IGenericRepository<T>
    {
        void AddData(T entity);
        IEnumerable<T> GetValues();
    }
}
