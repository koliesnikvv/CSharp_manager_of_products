using ProductManager.Services;

namespace ProductManagerUI.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        private readonly IDepositoryServices _service;
        private ProductListDto _product;

        public ProductListDto Product
        {
            get => _product;
            set { _product = value; OnPropertyChanged(); }
        }

        public ProductViewModel(IDepositoryServices service, int productId)
        {
            _service = service;
            LoadProduct(productId);
        }

        private void LoadProduct(int id)
        {
            Product = _service.GetProductById(id);
        }
    }
}