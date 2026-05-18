using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagement.Controllers
{
    public class PlanController : Controller
    {
        private readonly GymDbContext _planDb;

        public PlanController()
        {
            _planDb = new GymDbContext();
        }

        // index (Url: Get / BaseUrl / Plan / Index)

        public async Task<IActionResult> Index()
        {
            var plans = await _planDb.Plans.ToListAsync();
            return View(plans);
        }



        // Details (Url: Get / BaseUrl / plan / Details/ id)


        public async Task<IActionResult> Details(int id)
        {
            var plan = await _planDb.Plans.FindAsync(id);

            if (plan is  null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(plan);
        }


    }
}
