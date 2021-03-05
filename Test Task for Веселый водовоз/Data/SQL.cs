using System.Collections.Generic;
using System.Linq;
using TestTask.Data.Entities;

namespace TestTask.Data
{
    class SQL
    {
        public List<Employee> SelectEmployee()
        {
            //IQueryable employees;
            using (var context = new MyDbContext())
            {
                //var employees = from e in context.Employees
                //                select e;
                var employees = (from e in context.Employees
                                 join d in context.Departments on e.Id equals d.DepartmentDirectorId
                                 select e).ToList<Employee>();
                return employees;
            }

        }
    }
}
