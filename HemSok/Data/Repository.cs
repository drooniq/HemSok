using HemSok.Models;
using Microsoft.EntityFrameworkCore;

/*
 Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
 */
namespace HemSok.Data
{
    public class Repository<Tentity> : IRepository<Tentity> where Tentity : class
    {
        private readonly HemSokDbContext dbContext;

        public Repository(HemSokDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddAsync(Tentity entity)
        {
            await dbContext.AddAsync(entity);
        }

        public void Delete(Tentity entity)
        {
            dbContext.Remove(entity);
        }

        public async Task<Tentity> GetAsync(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await dbContext.FindAsync<Tentity>(id);
#pragma warning restore CS8603 // Possible null reference return.
        }
        public async Task<Tentity> GetAsync(string id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await dbContext.FindAsync<Tentity>(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<IEnumerable<Tentity>> GetAllAsync()
        {
            return await dbContext.Set<Tentity>().ToListAsync();
        }

        public IQueryable<Tentity> Queryable()
        {
            return dbContext.Set<Tentity>();
        }

        public void Update(Tentity entity)
        {
            dbContext.Update(entity);
        }

        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public void Entry(Tentity entity, EntityState state)
        {
            dbContext.Entry(entity).State = state;
        }
    }
}
