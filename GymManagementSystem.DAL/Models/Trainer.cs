using GymManagement.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Models
{
    public class Trainer: GymUsers
    {
        public Specialty Specialties { get; set; }
        //HireDate is the CreationDate in the Base Class

    }
}
