using System;
using System.Collections.Generic;

namespace Demo.Common.Models;

public partial class Admindetail
{
    public int AdminId { get; set; }

    public string AdminName { get; set; } = null!;

    public string? AdminImageName { get; set; }

    public string? AdminEmail { get; set; }

    public string? AdminPassword { get; set; }

    public virtual ICollection<Leavedetail> Leavedetails { get; set; } = new List<Leavedetail>();

    public virtual ICollection<Rolebasedadmin> Rolebasedadmins { get; set; } = new List<Rolebasedadmin>();
}
