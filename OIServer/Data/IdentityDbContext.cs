using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OIServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OIServer.Data
{
    public class IdentityDbContext : IdentityDbContext<ApplicationUser>
    {

        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
            : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //IdentityUsersSeed(builder);
        }
    }
}
