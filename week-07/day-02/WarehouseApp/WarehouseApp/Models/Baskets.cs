using System;
using System.Collections.Generic;

namespace WarehouseApp.Models
{
    public partial class Baskets
    {
        public Baskets()
        {
            BasketItem = new HashSet<BasketItem>();
        }

        public long BasketId { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<BasketItem> BasketItem { get; set; }
    }
}
