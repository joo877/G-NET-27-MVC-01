using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Data.Models
{
    public class HealthRecord: BaseEntity
    {

        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public string BloodType { get; set; } = default!;
        public string? Note { get; set; }

        //LastUpdated is the UpdatedAt property in BaseEntity

        public Member Member { get; set; } = default!;

    }
}
