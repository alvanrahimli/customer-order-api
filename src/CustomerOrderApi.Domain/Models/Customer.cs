using System.Collections.Generic;

namespace CustomerOrderApi.Domain.Models
{
    public class Customer : BaseModel<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string PostalCode { get; set; }
        public List<Address> Addresses { get; set; }

        public List<Order> Orders { get; set; }
    }
}