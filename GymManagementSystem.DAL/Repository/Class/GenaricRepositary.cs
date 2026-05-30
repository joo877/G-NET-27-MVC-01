using GymManagement.DAL.Data.DbContexts;
using GymManagement.DAL.Data.Models;
using GymManagement.DAL.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Repository.Class
{
    public class GenaricRepositary<TEntity> : IGenaricRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly GymDbContext _dbContext;
        private readonly DbSet<TEntity> _set;
        public GenaricRepositary(GymDbContext gymDb  )
        {
            _dbContext = gymDb;
            _set =gymDb.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAysnc(bool traking = false, CancellationToken ct =default)
        {
          IQueryable<TEntity> query= traking? _set : _set.AsNoTracking();
            return await query.ToListAsync();
        }

        public async Task<TEntity> GetEntityAysnc(int id, CancellationToken ct =default)
        {
            return await _set.FindAsync(id ,ct);
        }
        public async Task<int> AddAsync(TEntity entity, CancellationToken ct= default)
        {
           _set.Add(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(TEntity entity, CancellationToken ct=default)
        {
           _set.Update(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(TEntity entity, CancellationToken ct =default)
        {
           _set.Remove(entity);
            return await _dbContext.SaveChangesAsync();
        }

    }
}
