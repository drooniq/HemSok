using AutoMapper;
using HemSok.Data;
using HemSok.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

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
                IdentityUser user;
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
                        Password = "Patrik@1",
                        Role = "Agent",
                        ImagePath = "https://bilder.hemnet.se/images/broker_profile_large/53/47/53472eb67e182e2eb52ba36866950231.png"
                    },
                    new AgentDTO
                    {
                        Firstname = "Helen",
                        Lastname = "Lindström",
                        Agency = agencies[1],
                        Nickname = "Ellen",
                        Email = "helen.lindstrom@lansforsakringar.se",
                        Username = "helen.lindstrom@lansforsakringar.se",
                        Password = "Helen@1",
                        Role = "Admin",
                        ImagePath = "https://bilder.hemnet.se/images/broker_profile_large/7d/e0/7de0eceaf4b032a000cf86a9dabcb4af.jpg"
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
