using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TimeSheetApplication.Models
{
    public class TimeSheetDBContext:DbContext
    {
        public TimeSheetDBContext(DbContextOptions<TimeSheetDBContext> options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
