using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friender.Models
{
    public class Event
    {
       public int Id { get; set; }
       public string Photos { get; set; }
       public string Category { get; set; }
       public DateTime Dates { get; set; }
       public string Owner { get; set; }
       public string Description { get; set; }         

    }
}
