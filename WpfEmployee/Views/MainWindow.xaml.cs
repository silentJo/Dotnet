using System.Windows;
using WpfEmployee.ViewModels;

namespace WpfEmployee
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = new EmployeesVM();
            this.DataContext = new MainVM(new EmployeesVM(), new OrdersVM());
        }
    }

}
