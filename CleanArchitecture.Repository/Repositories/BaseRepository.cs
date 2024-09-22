using CleanArchitecture.Entity.Base;
using CleanArchitecture.Entity.Context;
using CleanArchitecture.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Repository.Repositories
{
    public class BaseRepository<TEntity>(AppDbContext appDbContext) : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly AppDbContext _appDbContext = appDbContext;
        protected readonly DbSet<TEntity> _dbSet = appDbContext.Set<TEntity>();

        public async Task<int> AddAsync(TEntity entity)
        {
            await this._dbSet.AddAsync(entity);
            return await this._appDbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var entity = await this.GetByIdAsync(id);
            if (entity != null)
            {
                this._dbSet.Remove(entity);
                return await this._appDbContext.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await this._dbSet.ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await this._dbSet.FindAsync(id);
        }

        public async Task<int> UpdateAsync(TEntity entity)
        {
            this._dbSet.Attach(entity);
            this._appDbContext.Entry(entity).State = EntityState.Modified;
            return await this._appDbContext.SaveChangesAsync();
        }
    }
}
