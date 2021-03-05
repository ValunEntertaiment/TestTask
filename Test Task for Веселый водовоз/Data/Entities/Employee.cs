using System;
using System.Collections.Generic;

namespace TestTask.Data.Entities
{
    public class Employee 
    {
        #region Столбцы
        /// <summary>идентификатор сотрудника</summary>
        public int Id { get; set; }
        /// <summary>Фамилия</summary>
        public string LastName { get; set; }
        /// <summary>Отчество</summary>
        public string MiddleName { get; set; }
        /// <summary>Имя</summary>
        public string FirstName { get; set; }
        /// <summary>День рождения</summary>
        public DateTime Birthday { get; set; }
        /// <summary>Пол</summary>
        public Gender Gender { get; set; }
        /// <summary>Номер подразделения</summary>
        public int DepartmentId { get; set; }
        #endregion

        #region Связи
        /// <summary>Департамент к которому относится сотрудник</summary>
        public virtual Department Department { get; set; }
        /// <summary>Заказы сотрудника</summary>
        public virtual ICollection<Order> Orders { get; set; }
        #endregion
    }

    public enum Gender { man, wooman }
}
