using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Contexts.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<Contexts.ApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Contexts.ApiContext";
        }

        protected override void Seed(Contexts.ApiContext context)
        {
           
        }
    }
}
