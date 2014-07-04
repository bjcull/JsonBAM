using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using JsonBAM.Data.Entities;

namespace JsonBAM.Data
{
    public class BamEntities : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        public BamEntities()
        {
        }
    }
}