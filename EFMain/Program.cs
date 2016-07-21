using System;
using System.Data.Entity;
using EFMain.Migrations;

namespace EFMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, Configuration>());

            using (var context = new SchoolContext())
            {
                var student = new Student { StudentName = "Rain", DOB = DateTime.Today};

                context.Students.Add(student);

                context.SaveChanges();
            }
        }
    }
}
