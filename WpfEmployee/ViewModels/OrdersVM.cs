using System.Collections.ObjectModel;
using System.Linq;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    internal class OrdersVM
    {
        private NorthwindContext context = new NorthwindContext();
        private ObservableCollection<OrderModel>? _ordersList;
        private int _employeeId;

        public OrdersVM()
        {

        }

        public OrdersVM(int employeeId)
        {
            this._employeeId = employeeId;
        }

        public ObservableCollection<OrderModel> OrdersList
        {
            get
            {
                return _ordersList = _ordersList ?? LoadOrders();   
            }
        }
        private ObservableCollection<OrderModel> LoadOrders()
        {
            ObservableCollection<OrderModel> localCollection = new ObservableCollection<OrderModel>();
            foreach (var order in context.Orders.Where(o => o.EmployeeId == _employeeId))
            {
                localCollection.Add(new OrderModel(order));
            }
            return localCollection;
        }
    }
}
