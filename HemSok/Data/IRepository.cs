/*
 Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
 */
using HemSok.Models;
using Microsoft.EntityFrameworkCore;

namespace HemSok.Data
{
    public interface IRepository<Tentity>  
    {
        public Task AddAsync(Tentity entity);

        public void Delete(Tentity entity);

        public void Update(Tentity entity);

        public Task<Tentity> GetAsync(int id);
        public Task<Tentity> GetAsync(Guid id);

        public Task<IEnumerable<Tentity>> GetAllAsync();

        public IQueryable<Tentity> Queryable();

        //public void Entry(Tentity entity, EntityState state);
        public void SavedResidance(Residence residence);

        public Task SaveChangesAsync();
    }
}
