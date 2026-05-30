using GymManagement.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Data.Configration
{
    public class TrainerConfig : GymUsersConfig<Trainer>, IEntityTypeConfiguration<Trainer>
    {

        public void Configure(EntityTypeBuilder<Trainer> builder)
        {

            builder.Property(t => t.CreatedAt)
                   .HasColumnName("HireDate")
                   .HasDefaultValueSql("GETDATE()");


            base.Configure(builder);
        }
    }
}
