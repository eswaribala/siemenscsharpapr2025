using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3.Repositories
{
    class GenericRepository<T> : IGenericRepository<T>
    {
        private readonly List<T> _dataStore = new List<T>();

        public void AddData(T entity)
        {
            _dataStore.Add(entity);
        }

        public IEnumerable<T> GetValues()
        {
            return _dataStore;
        }
    }
}
