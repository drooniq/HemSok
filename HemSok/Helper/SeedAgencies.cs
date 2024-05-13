﻿using HemSok.Data;
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
                        ImagePath = "https://image.api.playstation.com/vulcan/ap/rnd/202208/0921/3XopdGAJGRy3xNQKnQDvaCRs.png"
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
