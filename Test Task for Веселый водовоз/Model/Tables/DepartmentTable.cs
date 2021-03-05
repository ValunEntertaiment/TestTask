namespace TestTask.Model.Tables
{
    class DepartmentTable
    {
        /// <summary>Название департамента</summary>
        public string Name { get; set; }
        /// <summary>Идентификатор руководителя подразделения</summary>
        public EmployeeTable DepartmentDirector { get; set; }
    }
}
