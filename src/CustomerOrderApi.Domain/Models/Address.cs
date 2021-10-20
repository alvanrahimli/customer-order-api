using CustomerOrderApi.Domain.Models.Enums;

namespace CustomerOrderApi.Domain.Models
{
    public class Address : BaseModel<int>
    {
        public AddressType Type { get; set; }
        public string Title { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}