using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Input;
using TestTask.Commands;
using TestTask.Data.Entities;
using TestTask.Model;
using TestTask.Model.Tables;

namespace TestTask.ViewModel
{
    class MainWindowVM : ViewModel
    {
        #region Properties

        #region Список сотрудников
        private ObservableCollection<Employee> _Employees = new SQL().SelectEmployee();
        /// <summary>Список сотрудников</summary>
        public ObservableCollection<Employee> Employees
        {
            get => _Employees;
        }
        #endregion

        #region Список подразделений
        private List<DepartmentTable> _Departments;

        /// <summary>Список департаментов</summary>
        public List<DepartmentTable> Departments
        {
            get => _Departments;
            set => Set(ref _Departments, value);
        }
        #endregion

        #region Список заказов
        private List<OrderTable> _OrdersTable;

        public List<OrderTable> Orders
        {
            get => _OrdersTable;
            set => Set(ref _OrdersTable, value);
        }
        #endregion

        #region VisabilityDataGridEmployee
        public Visibility VisibilityDataGridEmployee
        {
            get => _visibilityEmployee;
            set => Set(ref _visibilityEmployee, value);
        }
        private Visibility _visibilityEmployee = Visibility.Visible;
        #endregion

        #region VisabilityDataGridOrder
        public Visibility VisibilityDataGridOrder
        {
            get => _visibilityOrder;
            set => Set(ref _visibilityOrder, value);
        }
        private Visibility _visibilityOrder = Visibility.Collapsed;
        #endregion

        #region VisabilityDataGridDepartment
        public Visibility VisibilityDataGridDepartment
        {
            get => _visibilityDepartment;
            set => Set(ref _visibilityDepartment, value);
        }
        private Visibility _visibilityDepartment = Visibility.Collapsed;
        #endregion

        #endregion

        #region Commands

        #region VisibilityDataGridEmployees
        public ICommand VisibilityDataGridEmployeesCommand { get; }

        private bool Employee = true;
        
        private bool CanVisibilityDataGridEmployeesExecute(object p) => !Employee;

        private void OnVisibilityDataGridEmployeesExecuted(object p)
        {
            if(Order || Department)
            {
                VisibilityDataGridDepartment = Visibility.Collapsed;
                Department = false;

                VisibilityDataGridOrder = Visibility.Collapsed;
                Order = false;

                VisibilityDataGridEmployee = Visibility.Visible;
                Employee = true;
            }
        }
        #endregion

        #region VisibilityDataGridDepartment
        public ICommand VisibilityDataGridDepartmentCommand { get; }

        private bool Department = false;

        private bool CanVisibilityDataGridDepartmentExecute(object p) => !Department;

        private void OnVisibilityDataGridDepartmentExecuted(object p)
        {
            if (Order || Employee)
            {
                VisibilityDataGridEmployee = Visibility.Collapsed;
                Employee = false;

                VisibilityDataGridOrder = Visibility.Collapsed;
                Order = false;

                VisibilityDataGridDepartment = Visibility.Visible;
                Department = true;
            }
        }
        #endregion

        #region VisibilityDataGridOrder
        public ICommand VisibilityDataGridOrderCommand { get; }

        private bool Order = false;

        private bool CanVisibilityDataGridOrderExecute(object p) => !Order;

        private void OnVisibilityDataGridOrderExecuted(object p)
        {
            if (Department || Employee)
            {
                VisibilityDataGridEmployee = Visibility.Collapsed;
                Employee = false;

                VisibilityDataGridDepartment = Visibility.Collapsed;
                Department = false;

                VisibilityDataGridOrder = Visibility.Visible;
                Order = true;
            }
        }
        #endregion

        #region SaveEmployee
        public ICommand SaveEmployeeCommand { get; }

        private bool CanSaveEmployeeExecute(object p) => true;

        private void OnSaveEmployeeExecuted(object p)
        {
            new SQL().UpdateEmployee(_Employees);
        }
        #endregion

        #endregion

        public MainWindowVM()
        {
            #region Commands
            VisibilityDataGridEmployeesCommand = new LambdaCommand(OnVisibilityDataGridEmployeesExecuted, CanVisibilityDataGridEmployeesExecute);
            VisibilityDataGridDepartmentCommand = new LambdaCommand(OnVisibilityDataGridDepartmentExecuted, CanVisibilityDataGridDepartmentExecute);
            VisibilityDataGridOrderCommand = new LambdaCommand(OnVisibilityDataGridOrderExecuted, CanVisibilityDataGridOrderExecute);
            SaveEmployeeCommand = new LambdaCommand(OnSaveEmployeeExecuted, CanSaveEmployeeExecute);
            #endregion
        }
    }
}
