using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Beds { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<CategoryPrice> CategoryPrices { get; set; }
        Category()
        {
            Guid.NewGuid();
            Rooms = new Collection<Room>();
            CategoryPrices = new Collection<CategoryPrice>();
        }
    }
}
