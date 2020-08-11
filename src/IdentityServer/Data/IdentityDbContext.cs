using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Data
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
            IdentityUsersSeed(builder);
        }

        private void IdentityUsersSeed(ModelBuilder builder)
        {
            var password = "Pass123$";

            var zubair = new ApplicationUser
            {
                Id = "1",
                UserName = "zubair",
                NormalizedUserName = "ZUBAIR",
                Email = "zubair@ontec.com",
                NormalizedEmail = "Zubair@Ontec.com".ToUpper(),
                EmailConfirmed = true
            };
            zubair.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(zubair, password);

            var philip = new ApplicationUser
            {
                Id = "2",
                UserName = "philip",
                NormalizedUserName = "PHILIP",
                Email = "philip@ontec.com",
                NormalizedEmail = "Philip@Ontec.com".ToUpper(),
                EmailConfirmed = true,
            };
            philip.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(philip, password);

            builder.Entity<ApplicationUser>()
                .HasData(zubair, philip);


            builder.Entity<IdentityUserClaim<string>>()
                .HasData(
                    new IdentityUserClaim<string>
                    {
                        Id = 1,
                        UserId = "1",
                        ClaimType = "name",
                        ClaimValue = "Zubair Van Oudtshoorn"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 2,
                        UserId = "1",
                        ClaimType = "given_name",
                        ClaimValue = "Zubair"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 3,
                        UserId = "1",
                        ClaimType = "family_name",
                        ClaimValue = "Van Oudtshoorn"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 4,
                        UserId = "1",
                        ClaimType = "email",
                        ClaimValue = "zubair@ontec.com.com"
                    },
                   
                    new IdentityUserClaim<string>
                    {
                        Id = 6,
                        UserId = "2",
                        ClaimType = "name",
                        ClaimValue = "Philip Foster"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 7,
                        UserId = "2",
                        ClaimType = "given_name",
                        ClaimValue = "Philip"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 8,
                        UserId = "2",
                        ClaimType = "family_name",
                        ClaimValue = "Foster"
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 9,
                        UserId = "2",
                        ClaimType = "email",
                        ClaimValue = "philip@ontec.com"
                    },
                    
                    new IdentityUserClaim<string>
                    {
                        Id = 11,
                        UserId = "1",
                        ClaimType = "email_verified",
                        ClaimValue = true.ToString()
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = 12,
                        UserId = "2",
                        ClaimType = "email_verified",
                        ClaimValue = true.ToString()
                    });
        }
    }
}
