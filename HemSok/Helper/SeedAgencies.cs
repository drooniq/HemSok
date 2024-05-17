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
                        Address = "Norra Moravägen 14, 78231, MALUNG",
                        PhoneNumber = "076-1123456",
                        Email = "info@ghostbusters.com",
                        Website = "www.ghostbusters.se",
                        ImagePath = "https://media.wired.com/photos/593272de5c4fbd732b552b5c/master/w_2240,c_limit/ghostbusters-inline.jpg"
                    },
                    new Agency
                    {
                        Name = "Widerlöv Kungsholmen",
                        Description = "En byrå för bostäder i Stockholmsområdet.",
                        Address = "Norr Mälarstrand 72, 112 35, Stockholm",
                        PhoneNumber = "070-8665301",
                        Email = "info@widerlov.se",
                        Website = "www.widerlov.se",
                        ImagePath = "https://bilder.hemnet.se/images/broker_logo_2_2x/77/f6/77f678c01f60aa6363f2700095ec6135.png"
                    },
                    new Agency
                    {
                        Name = "Länsförsäkringar Fastighetsförmedling",
                        Description = "Förmedling som säljer hus till vänster och höger",
                        Address = "Tegeluddsvägen 11, 115 41, Stockholm",
                        PhoneNumber = "070-2190356",
                        Email = "fastighet@lansforsakringar.se",
                        Website = "www.lansforsakringar.se",
                        ImagePath = "https://bilder.hemnet.se/images/broker_logo_2/73/c6/73c63376473b74a25e13711a82fcae60.png"
                    },
                    new Agency
                    {
                        Name = "Hogwarts Hemliga Hem",
                        Description = "Vi specialiserar oss på att hitta det perfekta hemmet för varje trollkarl, häxa och magisk varelse",
                        Address = "Gamla Riksvägen 52, 891 51, Örnsköldsvik",
                        PhoneNumber = "070-6248930",
                        Email = "info@hogwartshemligahem.se",
                        Website = "www.hogwartshemligahem.se",
                        ImagePath = "https://th.bing.com/th/id/OIP.vBs7bbHGdXLfYtrOz6PziAHaEK?rs=1&pid=ImgDetMain"
                    },
                    new Agency
                    {
                        Name = "Skräckfastigheter AB",
                        Description = "Vi säljer fastigheter som får ditt hjärta att slå snabbare!",
                        Address = "Rådhusgatan 1, 541 30, Skövde",
                        PhoneNumber = "070-3158469",
                        Email = "info@skrackfastigheter.se",
                        Website = "www.skrackfastigheter.se",
                        ImagePath = "https://image.elle.se/spokhus-hyra-ibl-4849862.jpg?imageId=4849862&width=1600&height=913&compression=80"
                    },
                    new Agency
                    {
                        Name = "Poltergeist Properties",
                        Description = "Våra fastigheter har en egen vilja!",
                        Address = "Mörkö, 153 93, Mörkö",
                        PhoneNumber = "08-15515500",
                        Email = "info@poltergeistproperties.se",
                        Website = "www.poltergeistproperties.se",
                        ImagePath = "https://hemsoktaplatser.se/____impro/1/onewebmedia/engsholmsslott42.JPG?etag=%22868a9-5f8f5c1a%22&sourceContentType=image%2Fjpeg&ignoreAspectRatio&resize=1180%2B1180&extract=0%2B278%2B1180%2B497&quality=85"
                    },
                    new Agency
                    {
                        Name = "Spooky Estates",
                        Description = "Din dröm hem, om dina drömmar är fyllda av spöken och skräck!",
                        Address = "Storgatan 1, 111 29, Stockholm",
                        PhoneNumber = "070-9876543",
                        Email = "contact@spookyestates.se",
                        Website = "www.spookyestates.se",
                        ImagePath = "https://cdn.dribbble.com/userupload/6936842/file/original-11e3a4d3a251d92e90ab31974c573fba.jpg?compress=1&resize=400x300"
                    },
                    new Agency
                    {
                        Name = "Phantom Realty",
                        Description = "Vi hittar de mest hemsökta fastigheterna för dig!",
                        Address = "Kungsgatan 12, 411 19, Göteborg",
                        PhoneNumber = "070-4567890",
                        Email = "support@phantomrealty.se",
                        Website = "www.phantomrealty.se",
                        ImagePath = "https://th.bing.com/th/id/OIP.q50tuby2rjQuBDOoUkh0rAHaDO?rs=1&pid=ImgDetMain"
                    },
                    new Agency
                    {
                        Name = "Mystic Mansions",
                        Description = "Upptäck mystiska och magiska hem med oss.",
                        Address = "Drottninggatan 7, 702 10, Örebro",
                        PhoneNumber = "070-1239876",
                        Email = "info@mysticmansions.se",
                        Website = "www.mysticmansions.se",
                        ImagePath = "https://i.ytimg.com/vi/_rhrjOdd43o/maxresdefault.jpg"
                    },
                    new Agency
                    {
                        Name = "Boo Realty",
                        Description = "Hem så bra att spöken aldrig vill lämna dem!",
                        Address = "Nygatan 5, 903 27, Umeå",
                        PhoneNumber = "070-5432198",
                        Email = "contact@boorealty.se",
                        Website = "www.boorealty.se",
                        ImagePath = "https://www.booerealty.com/sites/default/files/paragraphs/images/value-proposition/booe-crew.jpg"
                    },
                    new Agency
                    {
                        Name = "Haunted Haven",
                        Description = "Specialiserade på fastigheter med ett paranormalt förflutet.",
                        Address = "Stora Nygatan 22, 211 37, Malmö",
                        PhoneNumber = "070-1234567",
                        Email = "support@hauntedhaven.se",
                        Website = "www.hauntedhaven.se",
                        ImagePath = "https://th.bing.com/th/id/OIP.0i3qxEgcKWUMBaYiqxUqjwHaD4?rs=1&pid=ImgDetMain"
                    },
                    new Agency
                    {
                        Name = "Wraith Residences",
                        Description = "Där spöken och människor samexisterar i harmoni.",
                        Address = "Östra Storgatan 18, 553 21, Jönköping",
                        PhoneNumber = "070-0987654",
                        Email = "info@wraithresidences.se",
                        Website = "www.wraithresidences.se",
                        ImagePath = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/89a5dbac-600c-4ec6-886f-bf464a8f8ea1/dfv1vxt-e3c86176-3c05-4764-b1ae-1f8e55ea5ca7.jpg/v1/fill/w_1177,h_679,q_70,strp/wraith_by_nostalgicsuperfan_dfv1vxt-pre.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MTEwOCIsInBhdGgiOiJcL2ZcLzg5YTVkYmFjLTYwMGMtNGVjNi04ODZmLWJmNDY0YThmOGVhMVwvZGZ2MXZ4dC1lM2M4NjE3Ni0zYzA1LTQ3NjQtYjFhZS0xZjhlNTVlYTVjYTcuanBnIiwid2lkdGgiOiI8PTE5MjAifV1dLCJhdWQiOlsidXJuOnNlcnZpY2U6aW1hZ2Uub3BlcmF0aW9ucyJdfQ.M4nWBZMCuCs1awK4Hu0MzW9_xqhMDhFnbKt9xeQLz7k"
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
