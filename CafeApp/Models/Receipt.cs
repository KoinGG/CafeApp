using System;
using System.Collections.Generic;

namespace CafeApp.Desktop;

public partial class Receipt
{
    public int ReceiptId { get; set; }

    public int? OrderId { get; set; }

    public int? PaymentMethodId { get; set; }

    public decimal? PaymentAmount { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public virtual Order? Order { get; set; }

    public virtual PaymentMethod? PaymentMethod { get; set; }
}
