using System;
using System.Collections.Generic;
using System.ComponentModel;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    class EmployeeModel : INotifyPropertyChanged
    {
        private readonly Employee _employee;

        public EmployeeModel(Employee employee)
        {
            _employee = employee;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public int EmployeeId { get { return _employee.EmployeeId; } }

        public string FirstName {  
            get {  return _employee.FirstName ?? string.Empty; }
            set
            {
                if (_employee.FirstName != value)
                {
                    _employee.FirstName = value;
                    OnPropertyChanged("FullName");
                }
            }
        }

        public string LastName {  
            get { return _employee.LastName ?? string.Empty; }
            set
            {
                if (_employee.LastName != value)
                {
                    _employee.LastName = value;
                    OnPropertyChanged("FullName");
                }
            }
        }

        public string FullName { get { return _employee.LastName + ' ' + _employee.FirstName; } }
       
        public DateTime DisplayBirthDate { get { return (DateTime)_employee.BirthDate; } }

        public DateTime BirthDate
        {
            get { return (DateTime)_employee.BirthDate; }
            set
            {
                if (_employee.BirthDate != value)
                {
                    _employee.BirthDate = value == DateTime.MinValue ? (DateTime?)null : value;
                    OnPropertyChanged("DisplayBirthDate");
                }
            }
        }

        public DateTime HireDate
        {
            get { return (DateTime)_employee.HireDate; }
            set
            {
                if (_employee.HireDate != value)
                {
                    _employee.HireDate = value == DateTime.MinValue ? (DateTime?)null : value;
                    OnPropertyChanged("HireDate");
                }
            }
        }

        private string _titleOfCourtesy;
        public string TitleOfCourtesy
        {
            get { return _titleOfCourtesy; }
            set
            {
                if (_titleOfCourtesy != value)
                {
                    _titleOfCourtesy = value;
                    OnPropertyChanged("TitleOfCourtesy");
                }
            }
        }

        public ICollection<Order> Orders
        {
            get { return _employee.Orders; }
        }
    }
}
