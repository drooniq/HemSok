using Microsoft.EntityFrameworkCore;

/*
 Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
 */
namespace HemSok.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly HemSokDbContext dbContext;

        public Repository(HemSokDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddAsync(TEntity entity)
        {
            await dbContext.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            dbContext.Remove(entity);
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await dbContext.FindAsync<TEntity>(id);
        }
        public async Task<TEntity> GetAsync(string id)
        {
            return await dbContext.FindAsync<TEntity>(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await dbContext.Set<TEntity>().ToListAsync();
        }

        public IQueryable<TEntity> Queryable()
        {
            return dbContext.Set<TEntity>();
        }

        public void Update(TEntity entity)
        {
            dbContext.Update(entity);
        }

        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public void Entry(TEntity entity, EntityState state)
        {
            dbContext.Entry(entity).State = state;
        }
    }
}
