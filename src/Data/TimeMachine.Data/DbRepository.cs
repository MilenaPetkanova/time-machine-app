namespace TimeMachine.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using TimeMachine.Web.Models;
    using TimeMachine.Data.Contracts;

    public class DbRepository<TEntity> : IRepository<TEntity>, IDisposable
        where TEntity : class
    {
        private readonly TimeMachineContext _context;
        private DbSet<TEntity> dbSet;

        public DbRepository(TimeMachineContext context)
        {
            this._context = context;
            this.dbSet = this._context.Set<TEntity>();
        }

        public Task AddAsync(TEntity entity)
        {
            return this.dbSet.AddAsync(entity);
        }

        public IQueryable<TEntity> All()
        {
            return this.dbSet;
        }

        public IQueryable<TEntity> GetLast(int count)
        {
            return this.dbSet.TakeLast(count);
        }

        public void Delete(TEntity entity)
        {
            this.dbSet.Remove(entity);
        }

        public Task<int> SaveChangesAsync()
        {
            return this._context.SaveChangesAsync();
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
