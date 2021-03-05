using System.Collections.Generic;

namespace TestTask.Model.Entities
{
    public class Department
    {
        /// <summary>Идентификатор департамена</summary>
        public int Id { get; set; }

        /// <summary>Название департамента</summary>
        public string Name { get; set; }
        /// <summary>Идентификатор руководителя подразделения</summary>
        public int DepartmentDirectorId { get; set; }

        /// <summary>Список сотрудников входящий в департамент</summary>
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
