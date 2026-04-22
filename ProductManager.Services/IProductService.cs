using System.Threading.Tasks;

namespace ProductManager.Services
{
    public interface IProductService
    {
        Task<ProductDetailsDto> GetProductDetailsAsync(int id);
    }
}