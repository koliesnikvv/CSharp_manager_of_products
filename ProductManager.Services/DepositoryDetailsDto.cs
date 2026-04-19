using ProductManager.Services;

namespace ProductManager.Services
{
    public class DepositoryDetailsDto
    {
        public int Id {
            get; set; 
        }
        public string Name {
            get; set;
        }
        public string Location {
            get; set;
        }
        public List<ProductListDto> Products {
            get; set; 
        } = new();
        public decimal TotalValue
        {
            get; set;
        }
    }
}
