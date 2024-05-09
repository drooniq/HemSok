using HemSok.Data;
using HemSok.Models;

/*
 Author: Emil Waara
 */
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
                    },
                    new Agency
                    {
                        Name = "Widerlöv Kungsholmen",
                        Description = "En byrå för bostäder i Stockholmsområdet.",
                        Address = "",
                        PhoneNumber = "070-8665301",
                        Email = "info@widerlov.se",
                        ImagePath = "https://bilder.hemnet.se/images/broker_logo_2_2x/77/f6/77f678c01f60aa6363f2700095ec6135.png"
                    },
                    new Agency
                    {
                        Name = "Länsförsäkringar Fastighetsförmedling",
                        Description = "Förmedling som säljer hus till vänster och höger",
                        Address = "",
                        PhoneNumber = "070-2190356",
                        Email = "fastighet@lansforsakringar.se",
                        ImagePath = "https://bilder.hemnet.se/images/broker_logo_2/73/c6/73c63376473b74a25e13711a82fcae60.png"
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
