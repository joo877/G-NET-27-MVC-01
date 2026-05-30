using GymManagement.BLL.Services.Interfaces;
using GymManagement.DAL.Data.Models;
using GymManagement.DAL.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.PL.Controllers
{
    public class MemberController : Controller
    {
     
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService) 
        {
          _memberService = memberService;
        }

        // Get : Member/Index
        //Index : get all members


        public async Task<IActionResult> Index(CancellationToken ct=default)
        {
            var members = await _memberService.GetAllMembersAsync(ct:ct);
            return View(members);
        }


        // Get : Member/Details/{id}
        //Details : get member by id

        #region Create
        // Get : Member/Create
        // Create : show empty form to create new member





        // post : Member/Create
        // Create : Save submitted form

        #endregion


        #region Edit
        // Get : Member/Edit/{id}
        // Edits : Show form pre-filled





        // post : Member/Edits/{id}
        // Edits : Save edits

        #endregion

        #region Delete
        // Get : Member/Delete/{id}
        // Delete : Show confirmation page





        // Post : Member/Delete/{id}
        // Delete : Delete after confirmation


        #endregion
    }
}
