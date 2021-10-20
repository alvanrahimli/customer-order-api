namespace CustomerOrderApi.Domain.Models
{
    public class Product : BaseModel<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}