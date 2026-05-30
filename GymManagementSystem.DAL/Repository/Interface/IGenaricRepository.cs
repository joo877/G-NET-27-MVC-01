using GymManagement.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Repository.Interface
{
    public interface IGenaricRepository<TEntity> where TEntity : BaseEntity, new()
    {

        Task<IEnumerable<TEntity>> GetAllAysnc(bool traking=false,CancellationToken ct=default);

        Task<TEntity> GetEntityAysnc(int id , CancellationToken ct=default);

        Task<int> AddAsync(TEntity entity, CancellationToken ct=default);
        Task<int> UpdateAsync(TEntity entity , CancellationToken ct=default);
        Task<int> DeleteAsync(TEntity entity , CancellationToken ct=default);

    }
}
