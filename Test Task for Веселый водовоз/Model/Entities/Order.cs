using System;

namespace TestTask.Model.Entities
{
    class Order
    {
        #region Public properties
        /// <summary>Номер заказа</summary>
        public int Id 
        {
            get => _id;
            set => _id = value;
        }

        /// <summary>Контрагент</summary>
        public string Agent
        {
            get => _agent;
            set => _agent = value;
        }

        /// <summary>Дата заказа</summary>
        public DateTime OrderDate
        {
            get => _orderDate;
            set => _orderDate = value;
        }

        /// <summary>Сотрудник</summary>
        public Employee Employee
        {
            get => _employee;
            set => _employee = value;
        }
        #endregion

        #region Private properties
        int _id;
        string _agent;
        DateTime _orderDate;
        Employee _employee;
        #endregion
    }
}
