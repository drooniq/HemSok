using HemSok.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

/*
 Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
 */
namespace HemSok.Data
{
    public class HemSokDbContext : IdentityDbContext<Agent>
    {
        public HemSokDbContext(DbContextOptions<HemSokDbContext> options) : base(options)
        {
        }

        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Residence> Residences { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Municipality> Municipalities { get; set;}
        public DbSet<County> Counties { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "SuperAdmin",
                    NormalizedName = "SUPERADMIN"
                },
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "Agent",
                    NormalizedName = "AGENT"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
