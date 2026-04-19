using System.Collections.Generic;
using System.Linq;

namespace ProductManager.Services
{
    public class DepositoryDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Список товарів, які належать цьому складу
        public List<ProductListDto> Products { get; set; } = new List<ProductListDto>();

        // Загальна вартість усіх товарів на складі (замість DepositaryCalculations)
        public decimal TotalStockValue => Products.Sum(p => p.TotalPrice);

        // Кількість позицій на складі
        public int TotalItemsCount => Products.Count;
    }
}