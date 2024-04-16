/*
 Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
 */
namespace HemSok.Data
{
    public interface IRepository<Tentity>  
    {
        public Task AddAsync(Tentity entity);

        public void Delete(Tentity entity);

        public void Update(Tentity entity);

        public Task<Tentity> GetAsync(int id);

        public Task<IEnumerable<Tentity>> GetAllAsync();

        public IQueryable<Tentity> Queryable();

        public Task SaveChangesAsync();
    }
}
