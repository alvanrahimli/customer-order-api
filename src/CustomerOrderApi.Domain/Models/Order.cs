using System;
using System.Collections.Generic;

namespace CustomerOrderApi.Domain.Models
{
    public class Order : BaseModel<int>
    {
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderItem> Items { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}