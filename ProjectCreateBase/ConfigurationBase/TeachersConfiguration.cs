using Microsoft.EntityFrameworkCore;
using ProjectCreateBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCreateBase.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectCreateBase.Data;

namespace ProjectCreateBase.ConfigurationBase
{
    public class TeachersConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Enseignant");
            builder.HasKey(e => e.Id);
            builder.HasMany<Student>(t => t.Students);


        }
    }
}
