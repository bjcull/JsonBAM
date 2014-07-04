using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using JsonBAM.Data.Entities;
using JsonBAM.Migrations;

namespace JsonBAM.Data
{
    public class BamEntities : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        public BamEntities()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BamEntities, Configuration>());

            base.OnModelCreating(modelBuilder);
        }
    }
}