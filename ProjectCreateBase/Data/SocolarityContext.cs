using Microsoft.EntityFrameworkCore;
using ProjectCreateBase.ConfigurationBase;
using ProjectCreateBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCreateBase.Data
{
    public class SocolarityContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "dbo";
        public SocolarityContext(DbContextOptions<SocolarityContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new TeachersConfiguration());
            //modelBuilder.Entity<Student>()
            
            
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
