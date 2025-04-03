using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenv1.Models
{
    class Category : IEntity, IAuditable, ISoftDeletable
    {
        public long CategoryId { get; set; }
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Guid Id { get; set; }

        public bool IsDeleted { get; set; }

        public bool SoftDelete()
        {
            throw new NotImplementedException();
        }
    }
}
