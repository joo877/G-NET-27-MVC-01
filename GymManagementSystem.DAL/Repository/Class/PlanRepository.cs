using GymManagement.DAL.Repository.Interface;
using GymManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Repository.Class
{
    public class PlanRepository : IPlanRepository
    {
        private readonly GymDbContext _planDb;

        public PlanRepository(GymDbContext gymDb)
        {
          _planDb = gymDb; 
        }   

        public async Task<IEnumerable<Plan>> GetAllPlansAsync(bool Traking = false, CancellationToken ct = default)
        {
            //if (Traking)
            //{
            //    return await _planDb.Plans.ToListAsync(ct);
            //}
            //else
            //{
            //    return await _planDb.Plans.AsNoTracking().ToListAsync(ct);
            //}

            IQueryable<Plan> query = Traking ? _planDb.Plans : _planDb.Plans.AsNoTracking();
            return await query.ToListAsync();
        }

        public async Task<Plan> GetPlanByIdAsync(int id, CancellationToken ct = default)
        {
            return await _planDb.Plans.FindAsync(id,ct);
        }

        public async Task<int> AddPlanAsync(Plan plan, CancellationToken ct = default)
        {
           _planDb.Plans.Add(plan);
            return await _planDb.SaveChangesAsync(ct);
        }
        public async Task<int> UpdatePlanAsync(Plan plan, CancellationToken ct = default)
        {
            _planDb.Plans.Update(plan);
            return await _planDb.SaveChangesAsync(ct);
        }

        public async Task<int> DeletePlanAsync(Plan plan, CancellationToken ct = default)
        {
            _planDb.Plans.Remove(plan);
            return await _planDb.SaveChangesAsync(ct);
        }

    }
}
