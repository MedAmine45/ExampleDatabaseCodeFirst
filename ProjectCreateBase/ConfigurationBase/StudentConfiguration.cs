using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCreateBase.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectCreateBase.Data;

namespace ProjectCreateBase.ConfigurationBase
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Etudiant");
            builder.HasKey(s => s.Id);
            //builder.OwnsOne(s => s.Teacher);
                
            //builder
            //   .Property(s => s.Datebirthday)
            //   .IsRequired()
            //   .HasColumnType("Date")
            //   .HasDefaultValueSql("GetDate()");
        }


    }
}
