using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ExamenJan2023.Models;
using WpfApplication1.ViewModels;

namespace ExamenJan2023.ViewModels
{
    internal class ProductsVM : INotifyPropertyChanged
    {
        private NorthwindContext context = new NorthwindContext();
        private ObservableCollection<ProductModel>? _productsList;
        private ProductModel? _selectedProduct;
        public event EventHandler ProductRemoved;

        public ObservableCollection<ProductModel>? ProductsList
        {
            get => _productsList ??= LoadProducts();
            set
            {
                if (_productsList != value)
                {
                    _productsList = value;
                    OnPropertyChanged();
                }
            }
        }

        public ProductModel? SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                if (_selectedProduct != value)
                {
                    _selectedProduct = value;
                    OnPropertyChanged();
                }
            }
        }

        private DelegateCommand? _removeCommand;
        public DelegateCommand RemoveCommand 
        {
            get { return _removeCommand ??= new DelegateCommand(RemoveProduct); }
        }

        private void RemoveProduct()
        {
            if (_selectedProduct != null)
            {
                _selectedProduct.Discontinued = true;
                ProductsList?.Remove(_selectedProduct);

                // Utiliser une nouvelle instance d'ObservableCollection pour déclencher la notification de changement.
                ProductsList = new ObservableCollection<ProductModel>(ProductsList);

                OnPropertyChanged("SelectedProduct");

                // Déclencher l'événement ProductRemoved
                ProductRemoved?.Invoke(this, EventArgs.Empty);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private ObservableCollection<ProductModel> LoadProducts()
        {
            ObservableCollection<ProductModel> localCollection = new ObservableCollection<ProductModel>();
            foreach (var item in context.Products.Where(p => !p.Discontinued))
                localCollection.Add(new ProductModel(item));
            return localCollection;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
