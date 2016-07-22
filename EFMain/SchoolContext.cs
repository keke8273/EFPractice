using System.Data.Entity;

namespace EFMain
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("ProperDataBaseName")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
