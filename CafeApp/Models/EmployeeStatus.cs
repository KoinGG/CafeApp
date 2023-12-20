using System;
using System.Collections.Generic;

namespace CafeApp.Desktop;

public partial class EmployeeStatus
{
    public int EmployeeStatusId { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
