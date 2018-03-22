using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempProject.Data.Entities;

namespace TempProject.Data.MSSQL
{
    public class CareproDbContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<WorkAbilities> WorkAbilities { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FALDARK-PC\\SQLEXPRESS;Database=Carepro;Trusted_Connection=True;");
        }
    }
}
