using System.Collections.Generic;
using System.Linq;
using TestTask.Model.Entities;

namespace TestTask.Model
{
    class SQL
    {
        public IQueryable<Employee> SelectEmployee()
        {
            //IQueryable employees;
            using (var context = new MyDbContext())
            {
                //var employees = from e in context.Employees
                //                select e;
                var employees = from e in context.Employees
                                join d in context.Departments on e.Id equals d.DepartmentDirectorId
                                select e;
                return employees;
            }

        }
    }
}
