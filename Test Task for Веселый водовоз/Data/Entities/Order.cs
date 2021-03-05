using System;

namespace TestTask.Model.Entities
{
    public class Order
    {
        #region Столбцы
        /// <summary>Номер заказа</summary>
        public int Id { get; set; }

        /// <summary>Контрагент</summary>
        public string Agent { get; set; }

        /// <summary>Дата заказа</summary>
        public DateTime OrderDate { get; set; }

        /// <summary>Идентификатор сотрудника</summary>
        public int EmployeeId { get; set; }
        #endregion


        #region Связи
        /// <summary>Сотрудник выполняющий заказ</summary>
        public virtual Employee Employee { get; set; }
        #endregion
    }
}
