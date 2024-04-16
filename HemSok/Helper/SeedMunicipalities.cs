using HemSok.Data;
using HemSok.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace HemSok.Helper
{
    public static class SeedMunicipalities
    {
        public static List<Municipality> Seed(HemSokDbContext dbContext, List<County> Counties)
        {
            if (!dbContext.Municipalities.Any())
            {
                List<Municipality> municipalities = new List<Municipality>();

                municipalities.Add(new Municipality { Name = "Upplands Väsby", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Vallentuna", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Österåker", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Värmdö", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Järfälla", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Ekerö", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Huddinge", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Botkyrka", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Salem", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Haninge", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Tyresö", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Upplands-Bro", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Nykvarn", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Täby", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Danderyd", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Sollentuna", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Stockholm", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Södertälje", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Nacka", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Sundbyberg", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Solna", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Lidingö", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Vaxholm", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Norrtälje", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Sigtuna", County = Counties[0] });
                municipalities.Add(new Municipality { Name = "Nynäshamn", County = Counties[0] });

                municipalities.Add(new Municipality { Name = "Håbo", County = Counties[1] });
                municipalities.Add(new Municipality { Name = "Älvkarleby", County = Counties[1] });
                municipalities.Add(new Municipality { Name = "Knivsta", County = Counties[1] });
                municipalities.Add(new Municipality { Name = "Heby", County = Counties[1] });
                municipalities.Add(new Municipality { Name = "Tierp", County = Counties[1] });
                municipalities.Add(new Municipality { Name = "Uppsala", County = Counties[1] });
                municipalities.Add(new Municipality { Name = "Enköping", County = Counties[1] });
                municipalities.Add(new Municipality { Name = "Östhammar", County = Counties[1] });

                municipalities.Add(new Municipality { Name = "Vingåker", County = Counties[2] });
                municipalities.Add(new Municipality { Name = "Gnesta", County = Counties[2] });
                municipalities.Add(new Municipality { Name = "Nyköping", County = Counties[2] });
                municipalities.Add(new Municipality { Name = "Oxelösund", County = Counties[2] });
                municipalities.Add(new Municipality { Name = "Flen", County = Counties[2] });
                municipalities.Add(new Municipality { Name = "Katrineholm", County = Counties[2] });
                municipalities.Add(new Municipality { Name = "Eskilstuna", County = Counties[2] });
                municipalities.Add(new Municipality { Name = "Strängnäs", County = Counties[2] });
                municipalities.Add(new Municipality { Name = "Trosa", County = Counties[2] });

                municipalities.Add(new Municipality { Name = "Ödeshög", County = Counties[3] });
                municipalities.Add(new Municipality { Name = "Ydre", County = Counties[3] });
                municipalities.Add(new Municipality { Name = "Kinda", County = Counties[3] });
                municipalities.Add(new Municipality { Name = "Boxholm", County = Counties[3] });
                municipalities.Add(new Municipality { Name = "Åtvidaberg", County = Counties[3] });
                municipalities.Add(new Municipality { Name = "Finspång", County = Counties[3] });
                municipalities.Add(new Municipality { Name = "Valdemarsvik", County = Counties[3] });
                municipalities.Add(new Municipality { Name = "Linköping", County = Counties[3] });
                municipalities.Add(new Municipality { Name = "Norrköping", County = Counties[3] });
                municipalities.Add(new Municipality { Name = "Söderköping", County = Counties[3] });
                municipalities.Add(new Municipality { Name = "Motala", County = Counties[3] });
                municipalities.Add(new Municipality { Name = "Vadstena", County = Counties[3] });
                municipalities.Add(new Municipality { Name = "Mjölby", County = Counties[3] });

                municipalities.Add(new Municipality { Name = "Aneby", County = Counties[4] });
                municipalities.Add(new Municipality { Name = "Gnosjö", County = Counties[4] });
                municipalities.Add(new Municipality { Name = "Mullsjö", County = Counties[4] });
                municipalities.Add(new Municipality { Name = "Habo", County = Counties[4] });
                municipalities.Add(new Municipality { Name = "Gislaved", County = Counties[4] });
                municipalities.Add(new Municipality { Name = "Vaggeryd", County = Counties[4] });
                municipalities.Add(new Municipality { Name = "Jönköping", County = Counties[4] });
                municipalities.Add(new Municipality { Name = "Nässjö", County = Counties[4] });
                municipalities.Add(new Municipality { Name = "Värnamo", County = Counties[4] });
                municipalities.Add(new Municipality { Name = "Sävsjö", County = Counties[4] });
                municipalities.Add(new Municipality { Name = "Vetlanda", County = Counties[4] });
                municipalities.Add(new Municipality { Name = "Eksjö", County = Counties[4] });
                municipalities.Add(new Municipality { Name = "Tranås", County = Counties[4] });

                municipalities.Add(new Municipality { Name = "Uppvidinge", County = Counties[5] });
                municipalities.Add(new Municipality { Name = "Lessebo", County = Counties[5] });
                municipalities.Add(new Municipality { Name = "Tingsryd", County = Counties[5] });
                municipalities.Add(new Municipality { Name = "Alvesta", County = Counties[5] });
                municipalities.Add(new Municipality { Name = "Älmhult", County = Counties[5] });
                municipalities.Add(new Municipality { Name = "Markaryd", County = Counties[5] });
                municipalities.Add(new Municipality { Name = "Växjö", County = Counties[5] });
                municipalities.Add(new Municipality { Name = "Ljungby", County = Counties[5] });

                municipalities.Add(new Municipality { Name = "Högsby", County = Counties[6] });
                municipalities.Add(new Municipality { Name = "Torsås", County = Counties[6] });
                municipalities.Add(new Municipality { Name = "Mörbylånga", County = Counties[6] });
                municipalities.Add(new Municipality { Name = "Hultsfred", County = Counties[6] });
                municipalities.Add(new Municipality { Name = "Mönsterås", County = Counties[6] });
                municipalities.Add(new Municipality { Name = "Emmaboda", County = Counties[6] });
                municipalities.Add(new Municipality { Name = "Kalmar", County = Counties[6] });
                municipalities.Add(new Municipality { Name = "Nybro", County = Counties[6] });
                municipalities.Add(new Municipality { Name = "Oskarshamn", County = Counties[6] });
                municipalities.Add(new Municipality { Name = "Västervik", County = Counties[6] });
                municipalities.Add(new Municipality { Name = "Vimmerby", County = Counties[6] });
                municipalities.Add(new Municipality { Name = "Borgholm", County = Counties[6] });

                municipalities.Add(new Municipality { Name = "Gotland", County = Counties[7] });

                municipalities.Add(new Municipality { Name = "Olofström", County = Counties[8] });
                municipalities.Add(new Municipality { Name = "Karlskrona", County = Counties[8] });
                municipalities.Add(new Municipality { Name = "Ronneby", County = Counties[8] });
                municipalities.Add(new Municipality { Name = "Karlshamn", County = Counties[8] });
                municipalities.Add(new Municipality { Name = "Sölvesborg", County = Counties[8] });

                municipalities.Add(new Municipality { Name = "Svalöv", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Staffanstorp", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Burlöv", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Vellinge", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Östra Göinge", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Örkelljunga", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Bjuv", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Kävlinge", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Lomma", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Svedala", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Skurup", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Sjöbo", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Hörby", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Höör", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Tomelilla", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Bromölla", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Osby", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Perstorp", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Klippan", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Åstorp", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Båstad", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Malmö", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Lund", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Landskrona", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Helsingborg", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Höganäs", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Eslöv", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Ystad", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Trelleborg", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Kristianstad", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Simrishamn", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Ängelholm", County = Counties[9] });
                municipalities.Add(new Municipality { Name = "Hässleholm", County = Counties[9] });

                municipalities.Add(new Municipality { Name = "Hylte", County = Counties[10] });
                municipalities.Add(new Municipality { Name = "Halmstad", County = Counties[10] });
                municipalities.Add(new Municipality { Name = "Laholm", County = Counties[10] });
                municipalities.Add(new Municipality { Name = "Falkenberg", County = Counties[10] });
                municipalities.Add(new Municipality { Name = "Varberg", County = Counties[10] });
                municipalities.Add(new Municipality { Name = "Kungsbacka", County = Counties[10] });

                municipalities.Add(new Municipality { Name = "Härryda", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Partille", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Öckerö", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Stenungsund", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Tjörn", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Orust", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Sotenäs", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Munkedal", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Tanum", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Dals-Ed", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Färgelanda", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Ale", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Lerum", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Vårgårda", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Bollebygd", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Grästorp", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Essunga", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Karlsborg", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Gullspång", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Tranemo", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Bengtsfors", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Mellerud", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Lilla Edet", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Mark", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Svenljunga", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Herrljunga", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Vara", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Götene", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Tibro", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Töreboda", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Göteborg", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Mölndal", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Kungälv", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Lysekil", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Uddevalla", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Strömstad", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Vänersborg", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Trollhättan", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Alingsås", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Borås", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Ulricehamn", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Åmål", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Mariestad", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Lidköping", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Skara", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Skövde", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Hjo", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Tidaholm", County = Counties[11] });
                municipalities.Add(new Municipality { Name = "Falköping", County = Counties[11] });

                municipalities.Add(new Municipality { Name = "Kil", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Eda", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Torsby", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Storfors", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Hammarö", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Munkfors", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Forshaga", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Grums", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Årjäng", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Sunne", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Karlstad", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Kristinehamn", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Filipstad", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Hagfors", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Arvika", County = Counties[12] });
                municipalities.Add(new Municipality { Name = "Säffle", County = Counties[12] });

                municipalities.Add(new Municipality { Name = "Lekeberg", County = Counties[13] });
                municipalities.Add(new Municipality { Name = "Laxå", County = Counties[13] });
                municipalities.Add(new Municipality { Name = "Hallsberg", County = Counties[13] });
                municipalities.Add(new Municipality { Name = "Degerfors", County = Counties[13] });
                municipalities.Add(new Municipality { Name = "Hällefors", County = Counties[13] });
                municipalities.Add(new Municipality { Name = "Ljusnarsberg", County = Counties[13] });
                municipalities.Add(new Municipality { Name = "Örebro", County = Counties[13] });
                municipalities.Add(new Municipality { Name = "Kumla", County = Counties[13] });
                municipalities.Add(new Municipality { Name = "Askersund", County = Counties[13] });
                municipalities.Add(new Municipality { Name = "Karlskoga", County = Counties[13] });
                municipalities.Add(new Municipality { Name = "Nora", County = Counties[13] });
                municipalities.Add(new Municipality { Name = "Lindesberg", County = Counties[13] });

                municipalities.Add(new Municipality { Name = "Skinnskatteberg", County = Counties[14] });
                municipalities.Add(new Municipality { Name = "Surahammar", County = Counties[14] });
                municipalities.Add(new Municipality { Name = "Kungsör", County = Counties[14] });
                municipalities.Add(new Municipality { Name = "Hallstahammar", County = Counties[14] });
                municipalities.Add(new Municipality { Name = "Norberg", County = Counties[14] });
                municipalities.Add(new Municipality { Name = "Västerås", County = Counties[14] });
                municipalities.Add(new Municipality { Name = "Sala", County = Counties[14] });
                municipalities.Add(new Municipality { Name = "Fagersta", County = Counties[14] });
                municipalities.Add(new Municipality { Name = "Köping", County = Counties[14] });
                municipalities.Add(new Municipality { Name = "Arboga", County = Counties[14] });

                municipalities.Add(new Municipality { Name = "Vansbro", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Malung-Sälen", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Gagnef", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Leksand", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Rättvik", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Orsa", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Älvdalen", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Smedjebacken", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Mora", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Falun", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Borlänge", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Säter", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Hedemora", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Avesta", County = Counties[15] });
                municipalities.Add(new Municipality { Name = "Ludvika", County = Counties[15] });

                municipalities.Add(new Municipality { Name = "Ockelbo", County = Counties[16] });
                municipalities.Add(new Municipality { Name = "Hofors", County = Counties[16] });
                municipalities.Add(new Municipality { Name = "Ovanåker", County = Counties[16] });
                municipalities.Add(new Municipality { Name = "Nordanstig", County = Counties[16] });
                municipalities.Add(new Municipality { Name = "Ljusdal", County = Counties[16] });
                municipalities.Add(new Municipality { Name = "Gävle", County = Counties[16] });
                municipalities.Add(new Municipality { Name = "Sandviken", County = Counties[16] });
                municipalities.Add(new Municipality { Name = "Söderhamn", County = Counties[16] });
                municipalities.Add(new Municipality { Name = "Bollnäs", County = Counties[16] });
                municipalities.Add(new Municipality { Name = "Hudiksvall", County = Counties[16] });

                municipalities.Add(new Municipality { Name = "Ånge", County = Counties[17] });
                municipalities.Add(new Municipality { Name = "Timrå", County = Counties[17] });
                municipalities.Add(new Municipality { Name = "Härnösand", County = Counties[17] });
                municipalities.Add(new Municipality { Name = "Sundsvall", County = Counties[17] });
                municipalities.Add(new Municipality { Name = "Kramfors", County = Counties[17] });
                municipalities.Add(new Municipality { Name = "Sollefteå", County = Counties[17] });
                municipalities.Add(new Municipality { Name = "Örnsköldsvik", County = Counties[17] });

                municipalities.Add(new Municipality { Name = "Ragunda", County = Counties[18] });
                municipalities.Add(new Municipality { Name = "Bräcke", County = Counties[18] });
                municipalities.Add(new Municipality { Name = "Krokom", County = Counties[18] });
                municipalities.Add(new Municipality { Name = "Strömsund", County = Counties[18] });
                municipalities.Add(new Municipality { Name = "Åre", County = Counties[18] });
                municipalities.Add(new Municipality { Name = "Berg", County = Counties[18] });
                municipalities.Add(new Municipality { Name = "Härjedalen", County = Counties[18] });
                municipalities.Add(new Municipality { Name = "Östersund", County = Counties[18] });

                municipalities.Add(new Municipality { Name = "Nordmaling", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Bjurholm", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Vindeln", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Robertsfors", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Norsjö", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Malå", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Storuman", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Sorsele", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Dorotea", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Vännäs", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Vilhelmina", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Åsele", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Umeå", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Lycksele", County = Counties[19] });
                municipalities.Add(new Municipality { Name = "Skellefteå", County = Counties[19] });

                municipalities.Add(new Municipality { Name = "Arvidsjaur", County = Counties[20] });
                municipalities.Add(new Municipality { Name = "Arjeplog", County = Counties[20] });
                municipalities.Add(new Municipality { Name = "Jokkmokk", County = Counties[20] });
                municipalities.Add(new Municipality { Name = "Överkalix", County = Counties[20] });
                municipalities.Add(new Municipality { Name = "Kalix", County = Counties[20] });
                municipalities.Add(new Municipality { Name = "Övertorneå", County = Counties[20] });
                municipalities.Add(new Municipality { Name = "Pajala", County = Counties[20] });
                municipalities.Add(new Municipality { Name = "Gällivare", County = Counties[20] });
                municipalities.Add(new Municipality { Name = "Älvsbyn", County = Counties[20] });
                municipalities.Add(new Municipality { Name = "Luleå", County = Counties[20] });
                municipalities.Add(new Municipality { Name = "Piteå", County = Counties[20] });
                municipalities.Add(new Municipality { Name = "Boden", County = Counties[20] });
                municipalities.Add(new Municipality { Name = "Haparanda", County = Counties[20] });
                municipalities.Add(new Municipality { Name = "Kiruna", County = Counties[20] });

                dbContext.Municipalities.AddRange(municipalities);
                dbContext.SaveChanges();

                return municipalities;
            }
            return dbContext.Municipalities.ToList();
        }
    }
}
