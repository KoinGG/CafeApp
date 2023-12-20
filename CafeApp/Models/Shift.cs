using System;
using System.Collections.Generic;

namespace CafeApp.Desktop;

public partial class Shift
{
    public int ShiftId { get; set; }

    public DateOnly? ShiftDate { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public virtual ICollection<EmployeeShift> EmployeeShifts { get; set; } = new List<EmployeeShift>();
}
