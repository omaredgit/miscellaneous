using Microsoft.EntityFrameworkCore;
using miscellaneous.Models;

namespace miscellaneous.Data
{
    public class OfficeDB: DbContext
    {
        public OfficeDB(DbContextOptions<OfficeDB> options): base(options)
        {

        }
            public DbSet<Employee> Employees => Set<Employee>();
    }
}

