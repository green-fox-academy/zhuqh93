using System;
using System.Collections.Generic;

namespace WarehouseApp.Models
{
    public partial class OrderItem
    {
        public long OrderItemId { get; set; }
        public long? GoodId { get; set; }
        public int Quantity { get; set; }
        public long? OrderId { get; set; }

        public Goods Good { get; set; }
        public OrderHistory Order { get; set; }
    }
}
