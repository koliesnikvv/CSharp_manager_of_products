namespace StorageClasses
{
   
    public class ProductsStorage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepositaryId { get; set; }
        public decimal PricePerItem { get; set; } 
        public int Quantity { get; set; }       
        public string Description { get; set; }
        public ProductsCategory Category { get; set; }

        public ProductsStorage() { }
        public ProductsStorage(int id, string name) { Id = id; Name = name; }
    }
}