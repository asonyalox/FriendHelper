using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Friender.Models
{
    public class FrienderContext: IdentityDbContext<User>
    {
        public FrienderContext(DbContextOptions<FrienderContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
