using System;
using System.Collections.Generic;

namespace WarehouseApp.Models
{
    public partial class OrderHistory
    {
        public OrderHistory()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public long OrderId { get; set; }
        public DateTime OrderedAt { get; set; }
        public string CustomerName { get; set; }

        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
