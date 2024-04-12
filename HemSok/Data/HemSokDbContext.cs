using HemSok.Models;
using Microsoft.EntityFrameworkCore;

/*
 Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
 */
namespace HemSok.Data
{
    public class HemSokDbContext : DbContext
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
    }
}
