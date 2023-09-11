using GTR_Assignment.EF;
using GTR_Assignment.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GTR_Assignment.Repos
{
    public class BaseRepo<T> : IRepo<T> where T : class
    {
        protected readonly GtrContext _context;
        internal DbSet<T> _dbSet;

        public BaseRepo(GtrContext context)
        {
            _context = context;
            this._dbSet = context.Set<T>();
        }


        public virtual async Task<bool> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<IEnumerable<T>> All()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public virtual async Task<bool> Delete(T entity)
        {
            _dbSet.Remove(entity);
            return true;
        }

        public virtual async Task<T?> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual Task<bool> Update(T entity)
        {
            _dbSet.Update(entity);
            return Task.FromResult(true);
        }
    }
}
