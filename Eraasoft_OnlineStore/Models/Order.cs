using System;
using System.Collections.Generic;

namespace Eraasoft_OnlineStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        // Fixed CS8618 warning by making Customer nullable, or you can use 'required'
        public Customer? Customer { get; set; }

        public DateTime OrderDate { get; set; }

        // 1. The Foreign Key property using your enum type
        public OrderStatus Status { get; set; }

        // 2. The Navigation Property using the lookup class (Fixes CS0452)

        public List<OrderItem> Items { get; set; } = new();
    }
}