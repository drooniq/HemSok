using HemSok.Data;
using HemSok.Models;
using Microsoft.EntityFrameworkCore;

namespace HemSok.Helper
{
    public static class SeedCategories
    {
        public static List<Category> Seed(HemSokDbContext dbContext)
        {
            if (!dbContext.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category { Name = "Bostadsrättslägenhet" },
                    new Category { Name = "Bostadsrättsradhus" },
                    new Category { Name = "Villa" },
                    new Category { Name = "Fritidshus" },
                };

                dbContext.Categories.AddRange(categories);
                dbContext.SaveChanges();

                return categories;
            }
            return dbContext.Categories.ToList();
        }
    }
}
