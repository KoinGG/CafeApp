using System;
using System.Collections.Generic;

namespace CafeApp.Desktop;

public partial class Dish
{
    public int DishId { get; set; }

    public string DishName { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
