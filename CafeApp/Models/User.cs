using System;
using System.Collections.Generic;

namespace CafeApp.Desktop;

public partial class User
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public int? RoleId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? EmploymentStatusId { get; set; }

    public virtual ICollection<EmployeeShift> EmployeeShifts { get; set; } = new List<EmployeeShift>();

    public virtual EmployeeStatus? EmploymentStatus { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Role? Role { get; set; }
}
