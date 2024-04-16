using HemSok.Data;
using HemSok.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace HemSok.Helper
{
    public static class SeedCounty
    {
        public static List<County> Seed(HemSokDbContext dbContext)
        {
            if (!dbContext.Counties.Any())
            {
                List<County> counties = new List<County>();

                counties.Add(new County() { Name = "Stockholms län" });
                counties.Add(new County() { Name = "Uppsala län" });
                counties.Add(new County() { Name = "Södermanlands län" });
                counties.Add(new County() { Name = "Östergötlands län" });
                counties.Add(new County() { Name = "Jönköpings län" });
                counties.Add(new County() { Name = "Kronobergs län" });
                counties.Add(new County() { Name = "Kalmar län" });
                counties.Add(new County() { Name = "Gotlands län" });
                counties.Add(new County() { Name = "Blekinge län" });
                counties.Add(new County() { Name = "Skåne län" });
                counties.Add(new County() { Name = "Hallands län" });
                counties.Add(new County() { Name = "Västra Götalands län" });
                counties.Add(new County() { Name = "Värmlands län" });
                counties.Add(new County() { Name = "Örebro län" });
                counties.Add(new County() { Name = "Västmanlands län" });
                counties.Add(new County() { Name = "Dalarnas län" });
                counties.Add(new County() { Name = "Gävleborgs län" });
                counties.Add(new County() { Name = "Västernorrlands län" });
                counties.Add(new County() { Name = "Jämtlands län" });
                counties.Add(new County() { Name = "Västerbottens län" });
                counties.Add(new County() { Name = "Norrbottens län" });

                dbContext.Counties.AddRange(counties);
                dbContext.SaveChanges();

                return counties;
            }
            return dbContext.Counties.ToList();
        }
    }
}
