using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Checkin
    {
        public Guid Id { get; set; }
        public virtual Guest Guest { get; set; }
        public virtual Room Room { get; set; }
        public bool Check_in { get; set; }
        public bool Check_out { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
