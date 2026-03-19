using ProductManager.Services;

namespace ProductManager
{
    public interface IProductService
    {
        ProductDetailsDto GetProductDetails(int id);
    }
}