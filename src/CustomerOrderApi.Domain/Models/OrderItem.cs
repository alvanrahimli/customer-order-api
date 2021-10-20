namespace CustomerOrderApi.Domain.Models
{
    public class OrderItem : BaseModel<int>
    {
        public decimal Count { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}