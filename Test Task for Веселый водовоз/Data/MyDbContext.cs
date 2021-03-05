using System.Data.Entity;
using TestTask.Model.Entities;

namespace TestTask.Model
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
