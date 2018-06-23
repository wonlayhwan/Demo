using Demo.Database.Schema;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Database.MSSQL
{
    /// <summary>
    /// for dependency inject
    /// </summary>
    public class DIMSSQLDbContext : DbContext
    {
        public DIMSSQLDbContext(DbContextOptions<DIMSSQLDbContext> options)
          : base(options)
        { }

        public DbSet<BasicLiving> BasicLivings { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Communist> Communists { get; set; }

        public DbSet<GovernmentStaff> GovernmentStaffs { get; set; } 

        public DbSet<Profile> Profiles { get; set; }
    }
}
