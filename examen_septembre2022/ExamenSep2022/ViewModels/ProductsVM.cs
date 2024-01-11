using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ExamenSep2022.Models;
using ExamenSep2022.ViewModels;

internal class ProductsVM : INotifyPropertyChanged
{
    private NorthwindContext context = new NorthwindContext();
    private ObservableCollection<ProductModel>? _productsList;
    private ProductModel? _selectedProduct;

    public ProductsVM()
    {
        UpdateCommand = new DelegateCommand(UpdateProduct);
    }

    public ObservableCollection<ProductModel>? ProductsList
    {
        get => _productsList ??= LoadProducts();
    }

    private ObservableCollection<ProductModel> LoadProducts()
    {
        ObservableCollection<ProductModel> localCollection = new ObservableCollection<ProductModel>();
        foreach (var item in context.Products.Where(p => !p.Discontinued))
            localCollection.Add(new ProductModel(item));
        return localCollection;
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

    public DelegateCommand UpdateCommand { get; }

    private void UpdateProduct()
    {
        if (SelectedProduct != null)
        {
            // Mettez à jour en base de données ici, en utilisant les propriétés de SelectedProduct
            // Par exemple :
            // context.Products.First(p => p.ProductId == SelectedProduct.ProductId).ProductName = SelectedProduct.ProductName;
            // context.Products.First(p => p.ProductId == SelectedProduct.ProductId).QuantityPerUnit = SelectedProduct.Product.QuantityPerUnit;
            // context.SaveChanges();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
