using System;
using System.Collections.Generic;

namespace CafeApp.Desktop;

public partial class Order
{
    public int OrderId { get; set; }

    public int? TableId { get; set; }

    public int? UserId { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? OrderStatusId { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual OrderStatus? OrderStatus { get; set; }

    public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();

    public virtual Table? Table { get; set; }

    public virtual User? User { get; set; }
}
