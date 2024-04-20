/*
 Author: Marcus Karlsson, Fredrik Blixt, Emil Waara
 */
using HemSok.Models;
using Microsoft.EntityFrameworkCore;

namespace HemSok.Data
{
    public interface IRepository<TEntity>  
    {
        public Task AddAsync(TEntity entity);

        public void Delete(TEntity entity);

        public void Update(TEntity entity);

        public Task<TEntity> GetAsync(int id);

        public Task<TEntity> GetAsync(string id);

        public Task<IEnumerable<TEntity>> GetAllAsync();

        public IQueryable<TEntity> Queryable();

        public void Entry(TEntity entity, EntityState state);

        public Task SaveChangesAsync();
    }
}
