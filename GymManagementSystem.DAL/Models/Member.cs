using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Models
{
    public class Member : GymUsers
    {

        public string Photo { get; set; } = default!;

        // JoinDate is the CreatedAt property  in BaseEntity
    }
}
