using HemSok.Data;
using HemSok.Models;
using Microsoft.EntityFrameworkCore;

namespace HemSok.Helper
{
    public static class SeedAgent
    { 
        public static List<Agent> Seed(HemSokDbContext dbContext, List<Agency> agencies)
        {
            if (!dbContext.Agents.Any())
            {
                var agents = new List<Agent>
                {
                    new Agent
                    {
                        FirstName = "Emil",
                        LastName = "Waara",
                        Agency = agencies[0],
                        Nickname = "Spökplumpen"
                    }
                };

                dbContext.Agents.AddRange(agents);
                dbContext.SaveChanges();

                return agents;
            }
            return dbContext.Agents.ToList();
        }
    }
}
