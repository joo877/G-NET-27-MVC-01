using GymManagement.DAL.Data.Models;
using GymManagement.DAL.Repository.Class;
using GymManagement.DAL.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagement.Controllers
{
    public class PlanController : Controller
    {
        //private readonly GymDbContext _planDb;

        private readonly IGenaricRepository<Plan> _planRepository;

        public PlanController(IGenaricRepository<Plan> planRepository)
        {
            _planRepository = planRepository;

        }

        // index (Url: Get / BaseUrl / Plan / Index)

        public async Task<IActionResult> Index( CancellationToken ct)
        {
            //var plans = await _planDb.Plans.ToListAsync();

            var plans = await _planRepository.GetAllAysnc(traking: false, ct:ct);
            return View(plans);
        }



        // Details (Url: Get / BaseUrl / plan / Details/ id)


        public async Task<IActionResult> Details(int id , CancellationToken ct)
        {
            var plan = await _planRepository.GetEntityAysnc(id,ct);

            if (plan is  null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(plan);
        }


    }
}
