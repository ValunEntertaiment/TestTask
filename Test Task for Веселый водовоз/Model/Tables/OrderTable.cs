using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model.Tables
{
    class OrderTable
    {
        #region Столбцы
        /// <summary>Номер заказа</summary>
        public int Id { get; set; }

        /// <summary>Контрагент</summary>
        public string Agent { get; set; }

        /// <summary>Дата заказа</summary>
        public DateTime OrderDate { get; set; }

        /// <summary>Идентификатор сотрудника</summary>
        public EmployeeTable Author { get; set; }
        #endregion
    }
}
