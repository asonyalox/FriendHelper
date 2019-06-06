using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friender.Models
{
    public class UserCategory
    {
        public int Id { get; set; }


        public string UserId { get; set; }
        public User User { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
