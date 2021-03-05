using System;

namespace TestTask.Model.Tables
{
    class EmployeeTable
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
        public DepartmentTable DepartmentName { get; set; }
        #endregion
    }

    enum Gender
    {
        man,
        wooman
    }
}
