using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROG6212POE.Models
{

    // Entity Framework creation of entities within database and path to database on C drive on computer
    public class EntityContext : DbContext
    {
        public DbSet<HomeLogin> User { get; set; }
        public DbSet<ModuleModel> ModuleInfo { get; set; } 
        public DbSet<SelfStudyModel> SelfStudy { get; set; }
        public DbSet<WeeklySchedule> Schedule { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\Test\POE.db");
    }
}
