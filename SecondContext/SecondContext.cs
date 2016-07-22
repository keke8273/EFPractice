using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDB
{
    public class SecondContext : DbContext
    {
        public SecondContext() : base("ProperDataBaseName")
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
