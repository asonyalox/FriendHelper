using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Friender.Models
{
    public class Event
    {
       public int Id { get; set; }
       public string Photos { get; set; }
       public string Category { get; set; }
       [DataType(DataType.Date)]
       public DateTime EventDates { get; set; }
       public string Owner { get; set; }
       public string Description { get; set; }         

        public List<EventCategory> EventCategories { get; set; }

        //public int LocationId { get; set; }
       // public Location Location { get; set; }
    }
}
