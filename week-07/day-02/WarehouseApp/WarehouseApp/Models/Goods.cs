using System;
using System.Collections.Generic;

namespace WarehouseApp.Models
{
    public partial class Goods
    {
        public Goods()
        {
            BasketItem = new HashSet<BasketItem>();
            OrderItem = new HashSet<OrderItem>();
        }

        public long GoodId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }

        public ICollection<BasketItem> BasketItem { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
