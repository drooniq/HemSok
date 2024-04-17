using HemSok.Data;
using HemSok.Helper;
using HemSok.Mappings;
using HemSok.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

/*
 Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
 */
namespace HemSok
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<HemSokDbContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            builder.Services.AddAutoMapper(typeof(MappingProfile));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            // Seed Data
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<HemSokDbContext>();
                dbContext.Database.Migrate();

                var countySeedData = SeedCounty.Seed(dbContext);
                var municipalitySeedData = SeedMunicipalities.Seed(dbContext, countySeedData);
                var categorySeedData = SeedCategories.Seed(dbContext);
                var agencySeedData = SeedAgencies.Seed(dbContext);
                var agentSeedData = SeedAgent.Seed(dbContext, agencySeedData);
                var ResidenceSeedData = SeedResidences.Seed(dbContext, agentSeedData, municipalitySeedData, categorySeedData);
            }

            //// Seed Roles
            //using (var scope = app.Services.CreateScope())
            //{
            //    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            //    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //    var roles = new[] { SD.SuperAdmin, SD.Admin, SD.Customer };

            //    foreach (var role in roles)
            //    {
            //        if (!await roleManager.RoleExistsAsync(role))
            //        {
            //            await roleManager.CreateAsync(new IdentityRole(role));
            //        }
            //    }

            //    // Seed users only if they don't exist
            //    await SeedUsers.CreateUsers(userManager, roleManager, 25);
            //}

            app.Run();
        }
    }
}
