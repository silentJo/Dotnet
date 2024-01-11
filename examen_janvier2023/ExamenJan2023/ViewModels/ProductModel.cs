using ExamenJan2023.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExamenJan2023.ViewModels
{
    internal class ProductModel : INotifyPropertyChanged
    {
        private readonly Product _product;
        public ProductModel(Product product) { _product = product; }
        public int ProductId { get { return _product.ProductId; } set { _product.ProductId = value; } }
        public string ProductName {  get { return _product.ProductName; } set { _product.ProductName = value; } }
        public string Category { get { return _product.Category.CategoryName; } set { _product.Category.CategoryName = value; } }
        public string  Supplier { get { return _product.Supplier.ContactName; } set { _product.Supplier.ContactName = value; } }

        public Product Product => _product;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
