using System.Collections.Generic;
using System.Linq;
using TestTask.Data.Entities;

namespace TestTask.Data
{
    class SQL
    {
        public List<Employee> SelectEmployee()
        {
            using (var context = new MyDbContext())
            {
                var employees = (from e in context.Employees
                                 select e).ToList<Employee>();
                return employees;
            }
        }

        public bool UpdateEmployee(List<Employee> employees)
        {
            using(var context = new MyDbContext())
            {
                if (!Equals(context.Employees, employees))
                {
                    //я не придумал ничего лучше)) уж извиняйте)
                    context.Employees = null;
                    context.Employees.AddRange(employees);
                    return true;
                }
                return false;
            }
        }

        public List<Department> SelectDepartment()
        {
            using (var context = new MyDbContext())
            {
                var departments = (from e in context.Departments
                                 select e).ToList<Department>();
                return departments;
            }
        }

        public bool UpdateDepartment(List<Department> departments)
        {
            using (var context = new MyDbContext())
            {
                if (!Equals(context.Departments, departments))
                {
                    //я не придумал ничего лучше)) уж извиняйте)
                    context.Departments = null;
                    context.Departments.AddRange(departments);
                    return true;
                }
                return false;
            }
        }


        public List<Order> SelectOrder()
        {
            using (var context = new MyDbContext())
            {
                var orders = (from e in context.Orders
                                 select e).ToList<Order>();
                return orders;
            }
        }

        public bool UpdateOrder(List<Order> orders)
        {
            using (var context = new MyDbContext())
            {
                if (!Equals(context.Orders, orders))
                {
                    //я не придумал ничего лучше)) уж извиняйте)
                    context.Orders = null;
                    context.Orders.AddRange(orders);
                    return true;
                }
                return false;
            }
        }
    }
}
