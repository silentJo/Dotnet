using ExamenJan2023.Models;
using ExamenJan2023.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

internal class ProductsVM : INotifyPropertyChanged
{
    private NorthwindContext context = new NorthwindContext();
    private ObservableCollection<ProductModel>? _productsList;
    private ProductModel? _selectedProduct;
    private ObservableCollection<object>? _productsByCountry;

    public ObservableCollection<ProductModel>? ProductsList
    {
        get => _productsList ??= LoadProducts();
    }

    public ObservableCollection<object>? ProductsByCountry
    {
        get => _productsByCountry ??= LoadProductsByCountry();
        set
        {
            if (_productsByCountry != value)
            {
                _productsByCountry = value;
                OnPropertyChanged(nameof(ProductsByCountry));
            }
        }
    }

    private DelegateCommand? _removeCommand;
    public DelegateCommand RemoveCommand
    {
        get { return _removeCommand ??= new DelegateCommand(RemoveProduct); }
    }

    public ProductModel? SelectedProduct
    {
        get => _selectedProduct;
        set
        {
            if (_selectedProduct != value)
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }
    }

    private void RemoveProduct()
    {
        if (_selectedProduct != null && ProductsList != null)
        {
            _selectedProduct.Product.Discontinued = true;
            ProductsList?.Remove(_selectedProduct);
            context.SaveChanges();
            OnPropertyChanged(nameof(ProductsList));
            ProductsByCountry = LoadProductsByCountry();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private ObservableCollection<ProductModel> LoadProducts()
    {
        ObservableCollection<ProductModel> localCollection = new ObservableCollection<ProductModel>();
        foreach (var item in context.Products.Where(p => !p.Discontinued))
            localCollection.Add(new ProductModel(item));
        return localCollection;
    }

    private ObservableCollection<object> LoadProductsByCountry()
    {
        ObservableCollection<object> result = new ObservableCollection<object>();
        var productsByCountry = context.Products
            .Where(p => !p.Discontinued && p.OrderDetails.Any())
            .GroupBy(p => p.Supplier.Country)
            .Select(g => new { Country = g.Key, ProductCount = g.Count() })
            .OrderByDescending(x => x.ProductCount);
        foreach (var item in productsByCountry)
            result.Add(new { Country = item.Country, ProductCount = item.ProductCount });
        return result;
    }
}
