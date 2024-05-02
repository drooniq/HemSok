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
                        Agency = new Agency(),
                        Nickname = "Spökplumpen",
                        Email = "SuperAdmin@SuperAdmin.com",
                        Username = "SuperAdmin@SuperAdmin.com",
                        Password = "SuperAdmin@1234",
                        Role = "SuperAdmin"
                    },
                    new AgentDTO
                    {
                        Firstname = "Bara",
                        Lastname = "Admin",
                        Agency = agencies[0],
                        Nickname = "Plumpen",
                        Email = "Admin@Admin.com",
                        Username = "Admin@Admin.com",
                        Password = "Admin@1234",
                        Role = "Admin"
                    },
                    new AgentDTO
                    {
                        Firstname = "Bara",
                        Lastname = "Mäklare",
                        Agency = agencies[0],
                        Nickname = "Stumpen",
                        Email = "Agent@Agent.com",
                        Username = "Agent@Agent.com",
                        Password = "Agent@1234",
                        Role = "Agent"
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
