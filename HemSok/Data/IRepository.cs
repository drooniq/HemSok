namespace HemSok.Data
{
    public interface IRepository<Tentity>  
    {
        public Task AddAsync(Tentity entity);

        public Task DeleteAsync(Tentity entity);

        public void Update(Tentity entity);

        public Task<Tentity> Get(int id);

        public Task<IEnumerable<Tentity>> GetAll();

        public IQueryable<Tentity> Queryable();

        public Task SaveChangesAsync();
    }
}
