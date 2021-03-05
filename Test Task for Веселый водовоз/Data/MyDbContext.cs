using System.Data.Entity;
using TestTask.Data.Entities;

namespace TestTask.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConnectionString")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Department> Departments { get; set; }

    }
}
