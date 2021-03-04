namespace TestTask.Model.Entities
{
    public class Department
    {
        #region Public properties

        /// <summary>Название департамента</summary>
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        /// <summary>Руководитель подразделения</summary>
        public Employee DepartmentDirector 
        { 
            get=>_departmentDirector;
            set=>_departmentDirector = value;
        }
        #endregion

        #region Private properties

        string _name;
        Employee _departmentDirector;
        #endregion
    }
}
