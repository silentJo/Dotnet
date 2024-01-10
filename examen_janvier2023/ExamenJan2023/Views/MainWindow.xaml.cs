using System.Windows;
using ExamenJan2023.ViewModels;

namespace ExamenJan2023
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ProductsVM();
        }
    }
}