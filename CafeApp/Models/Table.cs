using System;
using System.Collections.Generic;

namespace CafeApp.Desktop;

public partial class Table
{
    public int TableId { get; set; }

    public int? TableNumber { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
