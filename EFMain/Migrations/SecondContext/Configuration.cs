namespace EFMain.Migrations.SecondContext
{
    using SecondDB;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SecondDB.SecondContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\SecondContext";
        }

        protected override void Seed(SecondDB.SecondContext context)
        {
            context.Teachers.AddOrUpdate(s => s.FullName,
                new Teacher { FullName = "God", DOB = new DateTime(1982, 07, 03) });
        }
    }
}
