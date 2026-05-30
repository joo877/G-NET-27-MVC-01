using GymManagement.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DAL.Data.Configration
{
    public class PlanConfig : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
         builder.Property(p => p.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(p => p.Description)
                    .HasMaxLength(200);

            builder.Property(p => p.Price)
                   .HasPrecision(10,2);


            builder.Property(p => p.CreatedAt)
                   .HasDefaultValueSql("GETDATE()");

            builder.ToTable(Tp =>
              
              Tp.HasCheckConstraint("PlanDUrationCheck", "DurationDays between 1 and 365")

            );
        }
    }
}
