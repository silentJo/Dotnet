using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using WpfEmployee.Models;
using System.ComponentModel;

namespace WpfEmployee.ViewModels
{
    class EmployeesVM : INotifyPropertyChanged
    {
        private NorthwindContext context = new NorthwindContext();
        private ObservableCollection<EmployeeModel>? _employeesList;
        private ObservableCollection<string>? _listTitle;

        public ObservableCollection<EmployeeModel> EmployeesList
        {
            get {
                return _employeesList ??= LoadEmployees();
            }
        }

        private ObservableCollection<EmployeeModel> LoadEmployees()
        {
            ObservableCollection<EmployeeModel> localCollection = new ObservableCollection<EmployeeModel>();
            foreach (var item in context.Employees)
            {
                localCollection.Add(new EmployeeModel(item));
            }
            return localCollection;
        }

        public ObservableCollection<string> ListTitle { 
            get { return _listTitle ?? LoadTitles(); } 
        }
        
        private ObservableCollection<string> LoadTitles()
        {
            var distinctTitles = context.Employees.Select(e => e.TitleOfCourtesy).Distinct().ToList();
            ObservableCollection<string> titleCollection = new ObservableCollection<string>(distinctTitles);
            return titleCollection;
        }

        private EmployeeModel? _selectedEmployee;

        public EmployeeModel SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                if (_selectedEmployee != value)
                {
                    _selectedEmployee = value;
                    OnPropertyChanged(nameof(SelectedEmployee));
                }
            }
        }

        private DelegateCommand? _addCommand;

        public DelegateCommand AddCommand
        {
            get { return _addCommand ??= new DelegateCommand(NewEmployee); }
        }

        private void NewEmployee()
        {
            Employee? employeeGlobal = new Employee();
            employeeGlobal.BirthDate = DateTime.MinValue;
            employeeGlobal.HireDate = DateTime.MinValue;
            EmployeeModel? employeeModel = new EmployeeModel(employeeGlobal);
            EmployeesList.Add(employeeModel);
            SelectedEmployee = employeeModel;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private DelegateCommand? _saveCommand;

        public DelegateCommand SaveComand
        {
            get { return _saveCommand ??= new DelegateCommand(SaveEmployee);  }
        }

        private void SaveEmployee()
        {
            if (SelectedEmployee != null)
            {
                context.SaveChanges();
            }
        }

        public ICollection<Order> OrderList
        {
            get
            {
                return (ICollection<Order>)SelectedEmployee.Orders.Where(o => o.EmployeeId == _selectedEmployee.EmployeeId);
                
            }
        }
    }
}
