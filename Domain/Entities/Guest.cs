using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Guest
    {
        public Guid Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birth { get; set; }
        public string Passport { get; set; }
        public string Mobile { get; set; }
        public virtual ICollection<Checkin> Checkins { get; set; }

        public Guest()
        {
            Id = Guid.NewGuid();
            Checkins = new Collection<Checkin>();
        }
    }
}
