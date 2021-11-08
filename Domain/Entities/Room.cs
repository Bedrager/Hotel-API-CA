using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Room
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Checkin> Checkins { get; set; }
        public Room()
        {
            Id = Guid.NewGuid();
            Checkins = new Collection<Checkin>();
        }
    }
}
