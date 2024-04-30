using System;
using System.Collections.Generic;

namespace Demo.Common.Models;

public partial class Leavetype
{
    public int Id { get; set; }

    public string LeaveType1 { get; set; } = null!;

    public virtual ICollection<Leavedetail> Leavedetails { get; set; } = new List<Leavedetail>();
}
