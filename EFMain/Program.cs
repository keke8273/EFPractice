using System;
using System.Data.Entity;
using EFMain.Migrations;
using SecondDB;

namespace EFMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, Configuration>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SecondContext, EFMain.Migrations.SecondContext.Configuration>());

            using (var context = new SchoolContext())
            {
                context.Database.Initialize(true);
            }

            using (var context = new SecondContext())
            {
                context.Database.Initialize(true);
            }
        }
    }
}
