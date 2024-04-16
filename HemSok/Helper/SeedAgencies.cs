using HemSok.Data;
using HemSok.Models;
using Microsoft.EntityFrameworkCore;

namespace HemSok.Helper
{
    public static class SeedAgencies
    {
        public static List<Agency> Seed(HemSokDbContext dbContext)
        {
            if (!dbContext.Agencies.Any())
            {
                var agencies = new List<Agency>
                {
                    new Agency
                    {
                        Name = "GhostBusters",
                        Description = "GhostBusters är en mäklarfirma dedikerad att hitta bästa möjliga bostad!",
                        Address = "North Moore vägen 14",
                        PhoneNumber = "076-1123456",
                        Email = "info@ghostbusters.com",
                        ImagePath = "https://media.wired.com/photos/593272de5c4fbd732b552b5c/master/w_2240,c_limit/ghostbusters-inline.jpg"
                    }
                };

                dbContext.Agencies.AddRange(agencies);
                dbContext.SaveChanges();

                return agencies;
            }
            return dbContext.Agencies.ToList();
        }
    }
}
