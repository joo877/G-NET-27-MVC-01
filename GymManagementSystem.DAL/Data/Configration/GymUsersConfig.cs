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
    public class GymUsersConfig<T> : IEntityTypeConfiguration<T> where T : GymUsers
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(u => u.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);


            builder.Property(u => u.Email)
                   .HasColumnType("varchar")
                   .HasMaxLength(100);


            builder.Property(u => u.Phone)
                   .HasColumnType("varchar")
                   .HasMaxLength(11);


            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasIndex(u => u.Phone).IsUnique();

            builder.ToTable(tb => {

                tb.HasCheckConstraint("PhoneConstraint", "Phone Like '010%' or Phone Like '011%' or Phone Like '012%' or Phone Like '015%'");

                tb.HasCheckConstraint("EmailConstraint", "Email Like '_%@_%._%' ");


            });



            builder.OwnsOne(u => u.Address, address =>

            {
                address.Property(a => a.Street)
                       .HasColumnType("varchar")
                       .HasMaxLength(30)
                       .HasColumnName("Street");


                address.Property(a => a.City)
                       .HasColumnType("varchar")
                       .HasMaxLength(30)
                       .HasColumnName("City");



              }  );

        }
    }
}
