using System;
using System.Collections.Generic;

namespace CafeApp.Desktop;

public partial class OrderItem
{
    public int OrderItemId { get; set; }

    public int? OrderId { get; set; }

    public int? DishId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public virtual Dish? Dish { get; set; }

    public virtual Order? Order { get; set; }
}
