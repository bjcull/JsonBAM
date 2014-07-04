namespace JsonBAM.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JsonBAM.Data.BamEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "JsonBAM.Data.BamEntities";
        }

        protected override void Seed(JsonBAM.Data.BamEntities context)
        {
        }
    }
}
