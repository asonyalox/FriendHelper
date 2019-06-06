using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Friender.Models
{
    public class User:IdentityUser
    {
        public List<UserCategory> UserCategories { get; set; }

        //public int LocationId { get; set; }
        //public Location Location { get; set; }

        
    }
}
