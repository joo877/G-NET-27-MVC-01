using GymManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Repository.Interface
{
    public interface IPlanRepository
    {

       Task<IEnumerable<Plan>> GetAllPlansAsync( bool Traking=false ,CancellationToken ct = default);

        Task<Plan?> GetPlanByIdAsync(int id, CancellationToken ct = default);

        Task<int> AddPlanAsync(Plan plan , CancellationToken ct = default);
        Task<int> UpdatePlanAsync(Plan plan , CancellationToken ct = default);
        Task<int> DeletePlanAsync(Plan plan , CancellationToken ct = default);

    }
}
