using System.Data.Entity;

namespace EFMain
{
    public class SchoolContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
    }
}
