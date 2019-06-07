using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Friender.Models
{
    public class User:IdentityUser
    {
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }

        public List<UserCategory> UserCategories { get; set; }

       

        
    }
}
