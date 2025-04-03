using ShoppersDenv1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShoppersDenv1.Models
{
    class Category : IEntity, IAuditable, ISoftDeletable
    {
        private string name;

        public void SetName(string name)
        {
            string Pattern = @"^[a-zA-Z]{5,25}$";
            Regex regex = new Regex(Pattern);
            if (!regex.IsMatch(name))
            {
                throw new NameFormatException("Name must be between 5 and 25 characters long and contain only letters.");
            }
            else
            {
                this.name = name;
            }
               
        }
        public string GetName()
        {
            return name;
        }

        //public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Guid Id { get; set; }

        public bool IsDeleted { get; set; }

        public void SoftDelete()
        {
            IsDeleted = true;
            UpdatedAt = DateTime.Now;
        }
    }
}
