using HemSok.Data;
using HemSok.Models;
using static System.Net.WebRequestMethods;

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
                        Category = categories[2],
                        StreetName = "Godegård 52",
                        City = "Motala",
                        ZipCode = "12345",
                        Municipality = municipalities[53],
                        Agent = agents[4],
                        ListingPrice = 900000,
                        Rooms = 4,
                        LivingArea = 85,
                        BiArea = 68,
                        PlotArea = 4070,
                        MonthlyFee = 0,
                        OperationCost = 0,
                        ConstructionYear = 2021,
                        Description = "Om du älskar livet på landet och vill uppleva naturen på nära håll, då har du möjlighet att förvärva ett lantlig boende med ostört läge utanför Godegård 3 mil norr om Motala. I närheten av fastigheten går Östgötaleden som bjuder på fantastiska möjligheter till varierade natur- och kulturupplevelser genom Östergötlands vackra landskap. Vintertid kan man nyttja skidanläggning i närheten, på sommaren finns fin badplats i trakten och det finns bra möjlighet till MTB-åkning. Huset kan passa både som permanentboende eller som fritidshusbostad. På fastigheten finns förutom ett bostadshus även två uthus och är vackert belägen med skog och sjö som närmsta granne. Huset är i gott skick och består av hall, kök, vardagsrum och två sovrum på entréplan. En trappa upp finns hall, sovrum samt WC-rum och i källarplan finns sovrum, badrum, samt verkstad och pannrum med tvättmaskin. Huset har låga driftskostnader tack vare vattenburen värme via bergvärmepump samt solceller. Varmt välkommen att anmäla dig till visningen!",
                        ImagePaths = new List<string> { "https://bilder.hemnet.se/images/1024x/13/42/13422fd0410f890a0672bab2e38487a1.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/a8/6c/a86c000110adea23270ec7c6f9b4c444.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/d6/c4/d6c406f2790f3f273f9a9557e1a1d495.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/69/7c/697ce7fa6e081e93c17e98273708481b.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/5a/60/5a60437cd02aa239c6a3625398926782.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/bd/43/bd43271c31313cad72566e735f874b0c.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/f3/ad/f3adf5f19a7784526cd86aa89da5c6e8.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/69/a0/69a00f3afc4777a1d887b422ebffad44.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/ed/1c/ed1c9d7bf11c901812bd05ae6d7708f0.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/c8/4c/c84c458bd699fefd93f3480ae84b94b7.png"}
                    },
                    new Residence
                    {
                        Category = categories[0],
                        StreetName = "Riksvägen 50C",
                        City = "Umeå",
                        ZipCode = "90345",
                        Municipality = municipalities[273],
                        Agent = agents[4],
                        ListingPrice = 14500000,
                        Rooms = 1,
                        LivingArea = 28,
                        BiArea = 0,
                        PlotArea = 0,
                        MonthlyFee = 1973,
                        OperationCost = 0,
                        ConstructionYear = 1956,
                        Description = "Kontakta mäklare för visningstid!\r\nKvadratsmart och trivsam etta på omtyckta Teg på vån 2 där originaldetaljer som innerdörr med glaspartier och fönsterbänkar i marmor ger en ombonad känsla.Trevlig hall med praktiska klinkers på golv, plats för förvaring i flera inbyggda garderober och öppet lättmöblerat allrum med avskild sovalkov för säng med bredd upp till 1,80. Helkaklat badrum med golvvärme, handukstork och dusch med vikväggar i glas. Arbetskök med gott om arbetsytor, förvaring och öppningsbart fönster vilket ger ett fantastiskt ljusinsläpp. i dagsläget finns kyl och frys placerat i hallen men går även att flytta in strax utanför köket.\r\nLåg månadsavgift som inkluderar allt i en mycket stabil förening där värme, vatten, internet, tv och hushållsel ingår i månadsavgiften. Denna lägenhet passar perfekt som första lägenhet, övernattningslägenhet eller studentboende.\r\n\r\nHär bor du med närhet till affärer, restauranger, träningsanläggningar och vacker natur.Till Avion och Ikea har ni ett bekvämt gång- och cykelavstånd.\r\n\r\nTill lägenheten finns två tillhörande förråd, ett i källare och ett på vinden. Tillträde kan ske omgående.\r\nVälkommen på visning!",
                        ImagePaths = new List<string> { "https://bilder.hemnet.se/images/1024x/88/88/8888790e48c442fc73a839ee634fcd4c.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/fa/f2/faf203b7158ab52ee49a7d9c47427484.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/fa/f2/faf203b7158ab52ee49a7d9c47427484.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/8f/1b/8f1b5a19d6f4e6811d4302c52f4c49e9.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/00/18/0018b6605c2336f26e7e378ba5133039.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/35/0d/350d4f2426930cbd1cb0f9b6f1533dc6.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/86/e0/86e01e9a43df10b5474760756825a563.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/56/92/569202abaeffcc84cdcd343b4914a21f.jpg" }
                    },
                    new Residence
                    {
                        Category = categories[0],
                        StreetName = "Riksvägen 52A",
                        City = "Umeå",
                        ZipCode = "90345",
                        Municipality = municipalities[273],
                        Agent = agents[3],
                        ListingPrice = 20950000,
                        Rooms = 3,
                        LivingArea = 54,
                        BiArea = 0,
                        PlotArea = 0,
                        MonthlyFee = 3753,
                        OperationCost = 0,
                        ConstructionYear = 1956,
                        Description = "Välkommen till Riksvägen 52A! Denna fina tvårumslägenhet har genomgått en noggrann och elegant renovering, vilket resulterar i en harmonisk kombination av modern design och bekvämlighet, välutrustat kök som inte bara erbjuder en elegant plats att laga mat, utan också en naturlig samlingsplats för middagar med vänner och familj.\r\nVälkommen på visning!",
                        ImagePaths = new List<string> { "https://bilder.hemnet.se/images/1024x/d8/2c/d82c7090b6cc504488735eb1d054a29e.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/f5/77/f577c4208064cc58f35ed5da42b3d31b.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/7e/2a/7e2adc8e5727eba2ba12916b58352fb7.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/ed/ba/edba3ae19ed7951f7f915cc598742179.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/89/e2/89e20faa7866e032d96b2d14019e0504.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/2d/5d/2d5d119cbf8128c408785fe63373e2b2.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/ca/b9/cab9e6c7118490238cabd66faff9d36c.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/c6/63/c66370ff95c69a4e59985a439f55dafa.jpg" }
                    },
                    new Residence
                    {
                        Category = categories[0],
                        StreetName = "Riksvägen 52C",
                        City = "Umeå",
                        ZipCode = "90345",
                        Municipality = municipalities[273],
                        Agent = agents[3],
                        ListingPrice = 23950000,
                        Rooms = 3,
                        LivingArea = 70,
                        BiArea = 0,
                        PlotArea = 0,
                        MonthlyFee = 4624,
                        OperationCost = 0,
                        ConstructionYear = 1956,
                        Description = "Välkommen till ditt nya drömhem på Riksvägen 52C! Denna fantastiska bostad erbjuder en perfekt kombination av komfort, stil och bekvämlighet. Med tre rymliga rum och en ljus, öppen planlösning på 69,5 kvadratmeter blir detta ditt ultimata boende.\r\n\r\nBrf Tegshus är en stark förening med en belåning på 4539 kr/ m2 vilket gör denna förening stark mot konjukturer.\r\n\r\nDen moderna och välplanerade köksdelen är hjärtat i hemmet, utrustad med toppmoderna apparater och generöst med förvaringsutrymme. Här kan du enkelt bjuda in vänner och familj för härliga middagar och minnesvärda stunder. Den öppna planlösningen ger en känsla av rymd och skapar en inbjudande atmosfär.\r\n\r\nDe tre väl tilltagna rummen ger möjligheter till både avkoppling och arbete. Med stilfulla detaljer och fina ytskikt blir varje rum en fristad där du kan trivas och skapa ditt eget personliga utrymme.\r\n\r\nLäget på Riksvägen 52C är optimalt med närhet till allt du behöver. Här har du smidig access till viktiga kommunikationsvägar och bekväm närhet till affärer, skolor och rekreation. Området erbjuder en harmonisk miljö samtidigt som du har staden inom räckhåll.\r\n\r\nDenna bostad är inte bara ett hem, det är en investering i din livsstil. Missa inte chansen att bli ägare till denna pärla på Riksvägen 52C. Kontakta oss för visning och upplev själv allt som detta fantastiska boende har att erbjuda!\r\n",
                        ImagePaths = new List<string> { "https://bilder.hemnet.se/images/1024x/8b/eb/8beb5a5d865b6b44594885f32cb91bda.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/e8/0f/e80ff530efd0e28f93ec305a881d0560.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/65/a1/65a10fc8c65861871a9211a39d8dea2b.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/6d/d6/6dd684d9db3c07404dc5ab20aa717ce2.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/17/57/17579593642897c0d6ecc817a45da33d.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/db/d1/dbd11aac3552c04f8e3df2f0a3f6ecdb.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/9c/78/9c78fe598b457ce2ad5a2350dd3010cf.jpg",
                                                        "https://bilder.hemnet.se/images/1024x/92/50/9250cccd2635ae6807698f64b3fbb7de.jpg" }
                    },
                    new Residence
                    {
                        Category = categories[2],
                        StreetName = "Kohrsgatu 4",
                        City = "Vikarbyn",
                        ZipCode = "79570",
                        Municipality = municipalities[225],
                        Agent = agents[9],
                        ListingPrice = 35000000,
                        Rooms = 6,
                        LivingArea = 200,
                        BiArea = 700,
                        PlotArea =  544736,
                        MonthlyFee = 0,
                        OperationCost = 6700,
                        ConstructionYear = 1934,
                        Description = "Denna unika fastighet, belägen vid Köhrsgatu 4 i det idylliska området Vikarbyn, erbjuder en sällsynt möjlighet att uppleva den nordiska naturens skönhet och stillhet på första parkett. Med en imponerande skogsomgivning som sträcker sig över 544736 kvadratmeter marker, är detta inte bara en bostad - det är en port till äventyr och fridfullhet.Köhrsgatu 4 välkomnar dig till en värld där naturlig charm möter modern komfort. Den välplanerade bostaden är designad för att smälta sömlöst in i den omgivande miljön samtidigt som den erbjuder bekvämligheter och stil. Med sina generösa ytor och ljusa interiör skapar detta hem en atmosfär av lugn och trivsel.Den omfattande skogsmarken som omger Köhrsgatu 4 är mer än bara ett landskap - det är en resurs och en möjlighet. Med sina 544736 kvadratmeter mark erbjuder det en rad möjligheter för den naturälskande köparen. Från vandringar och utflykter till jakt och avkoppling, är detta ett paradis för den som söker en nära kontakt med naturen.Beläget i Vikarbyn, ett område känt för sin pittoreska skönhet och gemenskapliga anda, erbjuder Köhrsgatu 4 en unik livsstil där lugn och stillhet möter lokal charm och värme. Med närhet till lokala bekvämligheter och sevärdheter, inklusive butiker, restauranger och kulturella evenemang, är detta en plats där man kan njuta av det bästa av både landsbygd och stadsliv.Köhrsgatu 4 är inte bara en bostad, det är en investering i en livsstil. Med sin unika kombination av naturskönhet, komfort och gemenskap, erbjuder denna fastighet en möjlighet att skapa minnen och uppleva livet på ett helt nytt sätt. Missa inte chansen att bli ägare till denna enastående egendom och upptäck allt den har att erbjuda.",
                        ImagePaths = new List<string> { "/images/Kohrsgatu5.JPG",
                                                        "/images/Kohrsgatu4.JPG",
                                                        "/images/Kohrsgatu3.JPG",
                                                        "/images/Kohrsgatu2.JPG",
                                                        "/images/Kohrsgatu1.JPG"}
                    },
                    new Residence
                    {
                        Category = categories[2],
                        StreetName = "Södra Prästholm 534",
                        City = "Råneå",
                        ZipCode = "95591",
                        Municipality = municipalities[285],
                        Agent = agents[9],
                        ListingPrice = 250000,
                        Rooms = 6,
                        LivingArea = 200,
                        BiArea = 50,
                        PlotArea =   3043,
                        MonthlyFee = 0,
                        OperationCost = 3300,
                        ConstructionYear = 1928,
                        Description = "Välkommen till Södra Prästholm 534, det legendariska spökhuset som nu är till salu i Råneå! Denna unika fastighet har fångat fantasin hos många med sin mystiska historia och kusliga charm. Beläget i det pittoreska Råneå, erbjuder detta spökhus en spännande möjlighet för den äventyrlige köparen. Med sina uråldriga murar och dunkla korridorer bär det på en atmosfär av gåtfullhet och mystik som väntar på att utforskas. Trots sin ovanliga rykte bär detta hus på en omisskännlig karaktär och potential för den som vågar ta sig an dess utmaningar. Med närhet till naturen och lokala bekvämligheter, är detta en plats där det övernaturliga möter vardagen. Missa inte chansen att bli ägare till detta fascinerande spökhus och upptäck allt det har att erbjuda!",
                        ImagePaths = new List<string> { "https://wp-assets.hemnet.se/wp-content/uploads/2023/11/spokhus-590.jpg",
                                                        "https://wp-assets.hemnet.se/wp-content/uploads/2023/11/kusligt-590.jpg",
                                                        "https://wp-assets.hemnet.se/wp-content/uploads/2023/11/kusligt-3-590.jpg",
                                                        "https://wp-assets.hemnet.se/wp-content/uploads/2023/11/kuslig-2-590.jpg"}
                    },
                    new Residence
                    {
                        Category = categories[3],
                        StreetName = "Fällforsvägen 98",
                        City = "Vännäs",
                        ZipCode = "91134",
                        Municipality = municipalities[270],
                        Agent = agents[4],
                        ListingPrice = 4900000,
                        Rooms = 8,
                        LivingArea = 138,
                        BiArea = 197,
                        PlotArea =   41456,
                        MonthlyFee = 0,
                        OperationCost = 6800,
                        ConstructionYear = 1993,
                        Description = "Välkommen till Fällforsvägen 98 - där lugnet vid vattnet möter en spöklik historia som får håren att resa sig! Denna förtrollande fastighet ligger vackert vid vattnet i Vännäs och bjuder in till stillsamma stunder och fridfulla vyer. Men bakom den idylliska fasaden döljer sig en mörk och kuslig historia - ett ställe som har blivit känt för sina övernaturliga fenomen och skrämmande berättelser om drukningsmord som tycks ha för alltid präglat dess omgivningar. Trots sina kusliga rykten bär denna bostad på en unik charm och en atmosfär av mystik som lockar äventyrssugna själar. Med närheten till det stilla vattnet och den vackra naturen runt omkring, är detta en plats där det övernaturliga möter det naturliga på ett sätt som är både spännande och oförglömligt. Ta chansen att uppleva den spöklika skönheten hos Fällforsvägen 98 - det är en resa du sent kommer att glömma, oavsett om du tror på spöken eller inte!",
                        ImagePaths = new List<string> { "https://jasifil.se/odehus/ghosthouse/pictures/album/small/0012.jpg",
                                                        "https://jasifil.se/odehus/ghosthouse/pictures/album/small/0006.jpg",
                                                        "https://jasifil.se/odehus/ghosthouse/pictures/album/small/0011.jpg",
                                                        "https://jasifil.se/odehus/ghosthouse/pictures/album/small/0009.jpg"}
                    },
                    new Residence
                    {
                        Category = categories[0],
                        StreetName = "Jönköpingsvägen 15",
                        City = "Värnamo",
                        ZipCode = "33134",
                        Municipality = municipalities[64],
                        Agent = agents[4],
                        ListingPrice = 2800000,
                        Rooms = 6,
                        LivingArea = 76,
                        BiArea = 25,
                        PlotArea =   13192,
                        MonthlyFee = 300,
                        OperationCost = 0,
                        ConstructionYear = 1927,
                        Description = "Välkommen till den häpnadsväckande lägenheten i Gummifabriken - där varje steg studsar med glädje! Denna unika bostad är mer än bara en lägenhet, det är en upplevelse som kommer att få dig att hoppa av glädje (och kanske lite bokstavligt). Beläget i hjärtat av Gummifabriken, är denna bostad en sann gummibonanza för den som älskar en touch av absurditet i sitt boende. Med sina elastiska väggar och mjuka golv får du en känsla av att gå på moln (eller kanske bara en extra studsig dag). Här kan du leva det mjuka livet med en interiör som är lika färgglad och livlig som ett regnbågeftermäl! Och för de dagar när du behöver lite extra hopp i steget, erbjuder Gummifabriken en rad unika bekvämligheter, från en gigantisk hoppborg i gården till en specialdesignad gummimatta i hallen - perfekt för att ta emot posten utan att behöva oroa dig för att falla! Missa inte chansen att bo i denna härligt galna lägenhet i Gummifabriken - det är en upplevelse du sent kommer att glömma (eller sluta studsa över)!",
                        ImagePaths = new List<string> { "https://jasifil.se/gummi/pictures/album/medium/0001.jpg",
                                                        "https://jasifil.se/gummi/pictures/album/medium/0002.jpg",
                                                        "https://jasifil.se/gummi/pictures/album/medium/0006.jpg",
                                                        "https://jasifil.se/gummi/pictures/album/medium/0012.jpg",
                                                        "https://jasifil.se/gummi/pictures/album/medium/0016.jpg",
                                                        "https://jasifil.se/gummi/pictures/album/medium/0029.jpg"}
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