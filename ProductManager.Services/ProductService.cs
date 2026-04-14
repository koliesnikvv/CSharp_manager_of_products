using ProductManager.Data;
using ProductManager.Services;
using System.Threading.Tasks;


namespace ProductManager.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        public ProductDetailsDto GetProductDetails(int id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            if (product == null)
                return null;

            return new ProductDetailsDto
            {
                Id = product.Id,
                Name = product.Name,
                Category = product.Category.ToString(),
                PricePerItem = product.PricePerItem,
                Quantity = product.Quantity,
                Description = product.Description
            };
        }
    }
}