using AutoMapper;
using HemSok.Data;
using HemSok.Models;
using Microsoft.AspNetCore.Identity;

/*
 Author: Emil Waara
 */
namespace HemSok.Helper
{
    public static class SeedAgent
    { 
        public static List<Agent> Seed(HemSokDbContext dbContext,
                                       List<Agency> agencies,
                                       UserManager<Agent> userManager,
                                       RoleManager<IdentityRole> roleManager,
                                       IMapper Mapper)
        {
            if (!dbContext.Agents.Any())
            {
                IdentityResult result;

                var agents = new List<AgentDTO>
                {
                    new AgentDTO
                    {
                        Firstname = "Super",
                        Lastname = "Admin",
                        Agency = agencies[0],
                        Nickname = "Spökplumpen",
                        Email = "SuperAdmin@SuperAdmin.com",
                        Username = "SuperAdmin@SuperAdmin.com",
                        Password = "SuperAdmin@1234",
                        Role = "SuperAdmin",
                        ImagePath = "http://www.solidimagearts.com/Digital/Digital_Images/slimer.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Richard",
                        Lastname = "Sörman",
                        Agency = agencies[1],
                        Nickname = "Ricardo",
                        Email = "richard.sorman@widerlov.se",
                        Username = "richard.sorman@widerlov.se",
                        Password = "Ricardo@1",
                        Role = "Admin",
                        ImagePath = "https://bilder.hemnet.se/images/broker_profile_large/aa/50/aa5011334fddb7fc28af82f0fd9e3eb1.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Nicholas",
                        Lastname = "de Mimsy-Porpington",
                        Agency = agencies[3],
                        Nickname = "Nearly Headless Nick",
                        Email = "porpington@hogwartshemligahem.se",
                        Username = "porpington@hogwartshemligahem.se",
                        Password = "Porpington@1",
                        Role = "Admin",
                        ImagePath = "https://pbs.twimg.com/media/Fo-QVYhaYAAAE1Z.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Myrtle",
                        Lastname = "Warren",
                        Agency = agencies[3],
                        Nickname = "Moaning Myrtle",
                        Email = "warren@hogwartshemligahem.se",
                        Username = "warren@hogwartshemligahem.se",
                        Password = "Warren@1",
                        Role = "Admin",
                        ImagePath = "https://yt3.ggpht.com/-6DzA-RYzCaA/AAAAAAAAAAI/AAAAAAAAAAA/nsLEw40RKKU/s900-c-k-no/photo.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Erik",
                        Lastname = "Lundkvist",
                        Agency = agencies[1],
                        Nickname = "Erika",
                        Email = "erik.lundkvist@widerlov.se",
                        Username = "erik.lundkvist@widerlov.se",
                        Password = "Erik@1",
                        Role = "Agent",
                        ImagePath = "https://bilder.hemnet.se/images/broker_profile_large/9f/5f/9f5f78fdc4a36a40edff23ef17a92e90.png"
                    },
                    new AgentDTO
                    {
                        Firstname = "Patrik",
                        Lastname = "Lundberg",
                        Agency = agencies[1],
                        Nickname = "Patte",
                        Email = "patrik.lundberg@widerlov.se",
                        Username = "patrik.lundberg@widerlov.se",
                        Password = "Lundberg@1",
                        Role = "Agent",
                        ImagePath = "https://bilder.hemnet.se/images/broker_profile_large/53/47/53472eb67e182e2eb52ba36866950231.png"
                    },
                    new AgentDTO
                    {
                        Firstname = "Helen",
                        Lastname = "Lindström",
                        Agency = agencies[2],
                        Nickname = "Ellen",
                        Email = "helen.lindstrom@lansforsakringar.se",
                        Username = "helen.lindstrom@lansforsakringar.se",
                        Password = "Lindström@1",
                        Role = "Admin",
                        ImagePath = "https://bilder.hemnet.se/images/broker_profile_large/7d/e0/7de0eceaf4b032a000cf86a9dabcb4af.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Sir Simon",
                        Lastname = "de Canterville",
                        Agency = agencies[0],
                        Nickname = "The Canterville Ghost",
                        Email = "simon.canterville@ghostbusters.se",
                        Username = "simon.canterville@ghostbusters.se",
                        Password = "Canterville@1",
                        Role = "Admin",
                        ImagePath = "https://i.pinimg.com/originals/e9/07/e6/e907e6162817cac025d8ff7bcdfeb59e.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Tove",
                        Lastname = "Jansson",
                        Agency = agencies[5],
                        Nickname = "Mårran",
                        Email = "tove.jansson@poltergeistproperties.se",
                        Username = "tove.jansson@poltergeistproperties.se",
                        Password = "Jansson@1",
                        Role = "Admin",
                        ImagePath = "https://i.pinimg.com/originals/92/73/99/927399cbae443d7b95fe9d6a755d787e.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Freddy",
                        Lastname = "Krueger",
                        Agency = agencies[4],
                        Nickname = "The Springwood Slasher",
                        Email = "freddy.krueger@skrackfastigheter.se",
                        Username = "freddy.krueger@skrackfastigheter.se",
                        Password = "Krueger@1",
                        Role = "Admin",
                        ImagePath = "https://i.pinimg.com/originals/4b/85/78/4b8578038aab7ee8a38c2fba231fa075.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Casper",
                        Lastname = "Ghost",
                        Agency = agencies[0],
                        Nickname = "The Friendly Ghost",
                        Email = "casper.ghost@ghostbusters.se",
                        Username = "casper.ghost@ghostbusters.se",
                        Password = "Ghost@1",
                        Phonenumber = "0730551498",
                        Role = "Agent",
                        ImagePath = "https://th.bing.com/th/id/R.cd19f1a1ffb22cb9d0a3e5b9eba9b52c?rik=bRWygfFyscygqw&riu=http%3a%2f%2fimages6.fanpop.com%2fimage%2fphotos%2f39900000%2fCasper-casper-the-ghost-39982351-808-960.jpg&ehk=pNL3c52nVoYamlAtK%2fBFbQQq%2bFCAv7BT94T0S1%2fJDpI%3d&risl=&pid=ImgRaw&r=0"
                    }
                };

                foreach (var agentdto in agents)
                {
                    var agent = Mapper.Map<Agent>(agentdto);
                    result = userManager.CreateAsync(agent, agentdto.Password).Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(agent, agentdto?.Role??"").Wait();
                    }
                }
            }
            return dbContext.Agents.ToList();
        }
    }
}
