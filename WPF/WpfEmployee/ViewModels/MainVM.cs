

namespace WpfEmployee.ViewModels
{
    internal class MainVM
    {
        public EmployeesVM EmployeesVM { get; }
        public OrdersVM OrdersVM { get; }

        public MainVM(EmployeesVM employeesViewModel, OrdersVM ordersViewModel)
        {
            EmployeesVM = employeesViewModel;
            OrdersVM = ordersViewModel;
        }
    }
}
