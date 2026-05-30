using GymManagement.BLL.Services.Interfaces;
using GymManagement.BLL.ViewModels;
using GymManagement.DAL.Data.Models;
using GymManagement.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.BLL.Services.Class
{
    public class MemberService : IMemberService


    {
        private readonly IGenaricRepository<Member> _memberRepository;

        public MemberService(IGenaricRepository<Member> memberRepository)
        {
            _memberRepository = memberRepository;
        }   

       

        public async Task<IEnumerable<MemberViewModel>> GetAllMembersAsync(CancellationToken ct)
        {
            var members= await _memberRepository.GetAllAysnc(ct:ct);

            if (!members.Any()) return [];

            return members.Select(m => new MemberViewModel
            {
                Email = m.Email,
                Gender = m.Gender.ToString(),
                Name = m.Name,
                Phone = m.Phone,
                Photo = m.Photo,
                Id = m.Id



            });

          
        }
    }
}
