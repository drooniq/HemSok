using HemSok.Data;
using HemSok.Models;
using Microsoft.EntityFrameworkCore;

/*
 Author: Emil Waara
 */
namespace HemSok.Helper
{
    public static class SeedResidences
    {
        // Seed Residences
        public static List<Residence> Seed(HemSokDbContext dbContext, List<Agent> agents, List<Municipality> municipalities, List<Category> categories)
        {
            if (!dbContext.Residences.Any())
            {
                var residences = new List<Residence>
                {
                    new Residence
                    {
                        Category = categories[0],
                        StreetName = "Testgatan 1",
                        City = "Teststad",
                        ZipCode = "12345",
                        Municipality = municipalities[0],
                        Agent = agents[0],
                        ListingPrice = 1000000,
                        Rooms = 3,
                        LivingArea = 100,
                        BiArea = 0,
                        PlotArea = 0,
                        MonthlyFee = 0,
                        OperationCost = 0,
                        ConstructionYear = 2021,
                        Description = "Testbeskrivning",
                        ImagePaths = new List<string> { "testbild1.jpg", "testbild2.jpg" }
                    }
                };

                dbContext.Residences.AddRange(residences);
                dbContext.SaveChanges();

                return residences;
            }
            return dbContext.Residences.ToList();
        }
    }
}