using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondContext
{
    public class SecondContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
    }
}
