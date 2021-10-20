namespace CustomerOrderApi.Domain.Models
{
    public class BaseModel<TKey>
    {
        public TKey Id { get; set; }
    }
}