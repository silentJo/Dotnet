using System;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    internal class OrderModel
    {
        private readonly Order _order;

        public OrderModel(Order order) { 
            _order = order; 
        }

        public int OrderID { get { return _order.OrderId; } }
        public DateTime OrderDate { get { return (DateTime)_order.OrderDate; } }

        public int EmployeeId { get { return _order.EmployeeId ?? 0; } }

        public decimal OrderTotal
        {
            get
            {
                decimal total = 0;
                var OrderDetail = _order.OrderDetails;
                foreach (var item in OrderDetail)
                {
                    var sum = item.Quantity * item.UnitPrice;
                    total += sum;
                }
                return total;
            }
        }

    }
}
