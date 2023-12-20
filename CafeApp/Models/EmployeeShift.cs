using System;
using System.Collections.Generic;

namespace CafeApp.Desktop;

public partial class EmployeeShift
{
    public int EmployeeShiftId { get; set; }

    public int? UserId { get; set; }

    public int? ShiftId { get; set; }

    public virtual Shift? Shift { get; set; }

    public virtual User? User { get; set; }
}
