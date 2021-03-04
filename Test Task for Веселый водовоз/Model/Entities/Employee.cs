using System;
namespace TestTask.Model.Entities
{
    public class Employee 
    {
        #region Public properties
        /// <summary>Фамилия</summary>
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        /// <summary>Отчество</summary>
        public string MiddleName
        {
            get => _middleName;
            set => _middleName = value;
        }
        /// <summary>Имя</summary>
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        /// <summary>День рождения</summary>
        public DateTime Birthday
        {
            get => _birthday;
            set => _birthday = value;
        }
        /// <summary>Пол</summary>
        public Gender Gender
        {
            get => _gender;
            set => _gender = value;
        }
        /// <summary>Подразделение</summary>
        public Department Department { get; set; }
        #endregion

        #region Private properties
        string _lastName;
        string _middleName;
        string _firstName;
        DateTime _birthday;
        Gender _gender;
        #endregion
    }

    public enum Gender { man, wooman }
}
