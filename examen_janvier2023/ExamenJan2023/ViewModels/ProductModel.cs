using ExamenJan2023.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExamenJan2023.ViewModels
{
    internal class ProductModel : INotifyPropertyChanged
    {
        private readonly Product _product;
        public ProductModel(Product product) { _product = product; }
        public int ProductId { get { return _product.ProductId; } }
        public string ProductName {  get { return _product.ProductName; } }
        public int? SupplierId { get { return _product.SupplierId; } }
        public int? CategoryId { get { return _product.CategoryId; } }
        public string? QuantityPerUnit {  get { return _product.QuantityPerUnit; } }
        public decimal? UnitPrice { get { return _product.UnitPrice; } }
        public short? UnitsInStock {  get { return _product.UnitsInStock; } }
        public short? UnitsOnOrder { get {  return _product.UnitsOnOrder; } }
        public bool Discontinued
        {
            get => _product.Discontinued;
            set
            {
                if (_product.Discontinued != value)
                {
                    _product.Discontinued = value;
                    OnPropertyChanged(nameof(Discontinued));
                }
            }
        }
        public virtual Category? Category { get { return _product.Category; } }
        public virtual Supplier? Supplier { get { return _product.Supplier; } }
        public virtual ICollection<OrderDetail> OrderDetails { get { return _product.OrderDetails; } }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
