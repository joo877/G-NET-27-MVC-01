using GymManagement.DAL.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Data.Models
{
    public class Trainer: GymUsers
    {
        public Specialty Specialties { get; set; }
        //HireDate is the CreationDate in the Base Class
        public ICollection<Session> Sessions { get; set; } = default!;
    }
}
