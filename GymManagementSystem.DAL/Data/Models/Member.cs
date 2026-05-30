using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Data.Models
{
    public class Member : GymUsers
    {

        public string Photo { get; set; } = default!;

        // JoinDate is the CreatedAt property  in BaseEntity

        public  HealthRecord  HealthRecord{ get; set; }= default!;

        public int HealthRecordId { get; set; }


        public ICollection<MemberShip> MemberShips { get; set; } = default!;

        public ICollection<Booking> Booking { get; set; } = default!;

    }
}
