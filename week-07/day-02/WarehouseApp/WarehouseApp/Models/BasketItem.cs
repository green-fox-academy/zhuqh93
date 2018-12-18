using System;
using System.Collections.Generic;

namespace WarehouseApp.Models
{
    public partial class BasketItem
    {
        public long BasketItemId { get; set; }
        public long? GoodId { get; set; }
        public int Quantity { get; set; }
        public long? BasketId { get; set; }

        public Baskets Basket { get; set; }
        public Goods Good { get; set; }
    }
}
