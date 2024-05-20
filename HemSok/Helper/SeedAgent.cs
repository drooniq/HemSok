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
                        Firstname = "Green",
                        Lastname = "Ghost",
                        Agency = agencies[0],
                        Nickname = "Onionhead",
                        Email = "green.ghost@ghostbusters.se",
                        Username = "green.ghost@ghostbusters.se",
                        Password = "Super@1",
                        Role = "SuperAdmin",
                        ImagePath = "http://www.solidimagearts.com/Digital/Digital_Images/slimer.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Nicholas",
                        Lastname = "de Mimsy-Porpington",
                        Agency = agencies[1],
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
                        Agency = agencies[1],
                        Nickname = "Moaning Myrtle",
                        Email = "warren@hogwartshemligahem.se",
                        Username = "warren@hogwartshemligahem.se",
                        Password = "Warren@1",
                        Role = "Agent",
                        ImagePath = "https://yt3.ggpht.com/-6DzA-RYzCaA/AAAAAAAAAAI/AAAAAAAAAAA/nsLEw40RKKU/s900-c-k-no/photo.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Sir Simon",
                        Lastname = "de Canterville",
                        Agency = agencies[8],
                        Nickname = "The Canterville Ghost",
                        Email = "simon.canterville@hauntedhaven.se",
                        Username = "simon.canterville@hauntedhaven.se",
                        Password = "Canterville@1",
                        Role = "Admin",
                        ImagePath = "https://i.pinimg.com/originals/e9/07/e6/e907e6162817cac025d8ff7bcdfeb59e.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Tove",
                        Lastname = "Jansson",
                        Agency = agencies[7],
                        Nickname = "Mårran",
                        Email = "tove.jansson@wraithresidences.se",
                        Username = "tove.jansson@wraithresidences.se",
                        Password = "Jansson@1",
                        Role = "Agent",
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
                        Agency = agencies[8],
                        Nickname = "The Friendly Ghost",
                        Email = "casper.ghost@hauntedhaven.se",
                        Username = "casper.ghost@hauntedhaven.se",
                        Password = "Ghost@1",
                        Phonenumber = "0730551498",
                        Role = "Agent",
                        ImagePath = "https://th.bing.com/th/id/R.cd19f1a1ffb22cb9d0a3e5b9eba9b52c?rik=bRWygfFyscygqw&riu=http%3a%2f%2fimages6.fanpop.com%2fimage%2fphotos%2f39900000%2fCasper-casper-the-ghost-39982351-808-960.jpg&ehk=pNL3c52nVoYamlAtK%2fBFbQQq%2bFCAv7BT94T0S1%2fJDpI%3d&risl=&pid=ImgRaw&r=0"
                    },
                    new AgentDTO
                    {
                        Firstname = "Winston",
                        Lastname = "Zeddemore",
                        Agency = agencies[0],
                        Nickname = "",
                        Email = "winston.zeddemore@ghostbusters.se",
                        Username = "winston.zeddemore@ghostbusters.se",
                        Password = "Zeddemore@1",
                        Phonenumber = "0731112233",
                        Role = "Admin",
                        ImagePath = "https://upload.wikimedia.org/wikipedia/en/5/53/Winston_Zeddemore_%28Ernie_Hudson%29.jpg?20220124081144"
                    },
                    new AgentDTO
                    {
                        Firstname = "Raymond",
                        Lastname = "Stantz",
                        Agency = agencies[0],
                        Nickname = "Ray",
                        Email = "raymond.stantz@ghostbusters.se",
                        Username = "raymond.stantz@ghostbusters.se",
                        Password = "Stantz@1",
                        Phonenumber = "0731112244",
                        Role = "Agent",
                        ImagePath = "https://th.bing.com/th/id/R.7f453069a9fa50d68404d9e832741bed?rik=bDr6SBLojkLZJg&riu=http%3a%2f%2fimages4.wikia.nocookie.net%2f__cb20101210000637%2fghostbusters%2fimages%2f9%2f90%2fStantz_01.jpg&ehk=IGPrZj3LS1VLvK4oFqxRd283Zv6cHMXEzxcWXx92RWc%3d&risl=&pid=ImgRaw&r=0"
                    },
                    new AgentDTO
                    {
                        Firstname = "Vlad",
                        Lastname = "Dracula",
                        Agency = agencies[9],
                        Nickname = "Pålspetsaren",
                        Email = "vlad.dracula@mysticmansions.se",
                        Username = "vlad.dracula@mysticmansions.se",
                        Password = "Dracula@1",
                        Phonenumber = "0732223344",
                        Role = "Admin",
                        ImagePath = "https://media1.s-nbcnews.com/j/streams/2013/october/131031/8c9549782-131031-vladphoto-hmed-1015a-files.nbcnews-ux-2880-1000.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Morticia",
                        Lastname = "Addams",
                        Agency = agencies[9],
                        Nickname = "Plum-lipped Cupid",
                        Email = "morticia.addams@mysticmansions.se",
                        Username = "morticia.addams@mysticmansions.se",
                        Password = "Morticia@1",
                        Phonenumber = "0732223355",
                        Role = "Agent",
                        ImagePath = "https://upload.wikimedia.org/wikipedia/en/2/23/Morticia_adams_origional.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Morgana",
                        Lastname = "Talbot",
                        Agency = agencies[2],
                        Nickname = "Elvira: Mistress of the Dark",
                        Email = "morgana.talbot@boorealty.se",
                        Username = "morgana.talbot@boorealty.se",
                        Password = "Talbot@1",
                        Phonenumber = "0733334455",
                        Role = "Admin",
                        ImagePath = "https://th.bing.com/th/id/OIP.M09xZjgYErpLCV0BL59qIgHaLH?rs=1&pid=ImgDetMain"
                    },
                    new AgentDTO
                    {
                        Firstname = "Beetlejuice",
                        Lastname = "Beetlejuice",
                        Agency = agencies[2],
                        Nickname = "BJ",
                        Email = "beetlejuice@boorealty.se",
                        Username = "beetlejuice@boorealty.se",
                        Password = "Beetlejuice@1",
                        Phonenumber = "0733334466",
                        Role = "Agent",
                        ImagePath = "https://th.bing.com/th/id/R.67282bab0fc0c1b6a3df4b14f8044006?rik=PnKAkFdADBaBfQ&pid=ImgRaw&r=0"
                    },
                    new AgentDTO
                    {
                        Firstname = "Mary I",
                        Lastname = "Tudor",
                        Agency = agencies[3],
                        Nickname = "Bloody Mary",
                        Email = "mary.tudor@poltergeistproperties.se",
                        Username = "mary.tudor@poltergeistproperties.se",
                        Password = "Tudor@1",
                        Phonenumber = "0734445566",
                        Role = "Admin",
                        ImagePath = "https://www.historyonthenet.com/wp-content/uploads/2017/05/mary-tudor.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Lady Jane",
                        Lastname = "Grey",
                        Agency = agencies[3],
                        Nickname = "Nine Days' Queen",
                        Email = "jane.grey@poltergeistproperties.se",
                        Username = "jane.grey@poltergeistproperties.se",
                        Password = "Grey@1",
                        Phonenumber = "0734445577",
                        Role = "Agent",
                        ImagePath = "https://images.twinkl.co.uk/tw1n/image/private/t_630/u/ux/twinkl-lady-jane-grey-1_ver_1.png"
                    },
                    new AgentDTO
                    {
                        Firstname = "Jason",
                        Lastname = "Voorhees",
                        Agency = agencies[4],
                        Nickname = "Camp Crystal Lake Killer",
                        Email = "jason.voorhees@skrackfastigheter.se",
                        Username = "jason.voorhees@skrackfastigheter.se",
                        Password = "Voorhees@1",
                        Phonenumber = "0735556677",
                        Role = "Admin",
                        ImagePath = "https://morbidlybeautiful.com/wp-content/uploads/2016/06/jason-voorhees-friday-the-13th.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Robert",
                        Lastname = "Gray",
                        Agency = agencies[4],
                        Nickname = "Bob",
                        Email = "robert.Gray@skrackfastigheter.se",
                        Username = "robert.Gray@skrackfastigheter.se",
                        Password = "Gray@1",
                        Phonenumber = "0735556688",
                        Role = "Agent",
                        ImagePath = "https://images.hdqwalls.com/download/pennywise-wu-1280x720.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Samara",
                        Lastname = "Morgan",
                        Agency = agencies[7],
                        Nickname = "The girl from the well",
                        Email = "samara.morgan@wraithresidences.se",
                        Username = "samara.morgan@wraithresidences.se",
                        Password = "Samara@1",
                        Phonenumber = "0736667788",
                        Role = "Admin",
                        ImagePath = "https://th.bing.com/th/id/OIP.MSFxEbiTcS0Hb3cyM-IPKgHaFJ?rs=1&pid=ImgDetMain"
                    },
                    new AgentDTO
                    {
                        Firstname = "Kayako",
                        Lastname = "Saeki",
                        Agency = agencies[7],
                        Nickname = "The housewife",
                        Email = "kayako.saeki@wraithresidences.se",
                        Username = "kayako.saeki@wraithresidences.se",
                        Password = "Kayako@1",
                        Phonenumber = "0736667799",
                        Role = "Agent",
                        ImagePath = "https://th.bing.com/th/id/R.e0f1e4620f2529a13bc063ace9440b2e?rik=1I%2fNGPPbveP42A&riu=http%3a%2f%2fimages1.fanpop.com%2fimages%2fphotos%2f1900000%2fkayako-saeki-the-grudge-1979258-270-270.jpg&ehk=g6Wy2cvCU3SlI4MJ%2b11d2KbxZHMj5hdT3v7OfZlzYTc%3d&risl=&pid=ImgRaw&r=0&sres=1&sresct=1"
                    },
                    new AgentDTO
                    {
                        Firstname = "Jack",
                        Lastname = "Torrance",
                        Agency = agencies[6],
                        Nickname = "Johnny",
                        Email = "jack.torrance@spookyestates.se",
                        Username = "jack.torrance@spookyestates.se",
                        Password = "Torrance@1",
                        Phonenumber = "0737778899",
                        Role = "Admin",
                        ImagePath = "https://www.slashfilm.com/img/gallery/finding-the-right-voice-for-jack-torrance-was-key-to-the-shinings-success/l-intro-1671756580.jpg"
                    },
                    new AgentDTO
                    {
                        Firstname = "Lydia",
                        Lastname = "Deetz",
                        Agency = agencies[6],
                        Nickname = "The goth girl",
                        Email = "lydia.deetz@spookyestates.se",
                        Username = "lydia.deetz@spookyestates.se",
                        Password = "Deetz@1",
                        Phonenumber = "0737778898",
                        Role = "Agent",
                        ImagePath = "https://th.bing.com/th/id/OIP.UZB4XB4zDO2IkrFJqo_pQgHaHH?rs=1&pid=ImgDetMain"
                    },
                    new AgentDTO
                    {
                        Firstname = "Kit",
                        Lastname = "Walker",
                        Agency = agencies[5],
                        Nickname = "Fantomen",
                        Email = "kit.walker@phantomrealty.se",
                        Username = "kit.walker@phantomrealty.se",
                        Password = "Walker@1",
                        Phonenumber = "0738889900",
                        Role = "Admin",
                        ImagePath = "https://th.bing.com/th/id/R.8d8d99c510eafa92521caef327ce1ce0?rik=EMpyfGTL5QkpCw&riu=http%3a%2f%2f2.bp.blogspot.com%2f_Y8m29ZLX5ag%2fTCGbt44T2EI%2fAAAAAAAAFoc%2fk8jkrmclJkg%2fs400%2fPHANTOM%2bART%2bFRAME.jpg&ehk=cPmvJ6Jay0INq9mAj8kg2Kj2AaC7O2WK4mMGj0zB%2fVQ%3d&risl=&pid=ImgRaw&r=0"
                    },
                    new AgentDTO
                    {
                        Firstname = "Christine",
                        Lastname = "Daaé",
                        Agency = agencies[5],
                        Nickname = "The Swedish Nightingale",
                        Email = "christine.daae@phantomrealty.se",
                        Username = "christine.daae@phantomrealty.se",
                        Password = "Daaé@1",
                        Phonenumber = "0738889901",
                        Role = "Agent",
                        ImagePath = "https://vignette4.wikia.nocookie.net/poto/images/e/e8/Christine-daae-and-christines-lace-chemise-gallery.jpg/revision/latest?cb=20111119221243"
                    },
                    new AgentDTO
                    {
                        Firstname = "Marcus",
                        Lastname = "Friberg",
                        Agency = agencies[10],
                        Nickname = "The Professor",
                        Email = "marcus.friberg@happy.se",
                        Username = "marcus.friberg@happy.se",
                        Password = "Friberg@1",
                        Phonenumber = "073165789",
                        Role = "Admin",
                        ImagePath = "https://filerepository.itslearning.com/e7aec601-7d83-4d49-901e-38b7cdeed767"
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
