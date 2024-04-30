using System;
using System.Collections.Generic;

namespace Demo.Common.Models;

public partial class Employeedetail
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? EmployeeImageName { get; set; }

    public string? EmployeeDesignation { get; set; }

    public string? EmployeeEmail { get; set; }

    public string? EmployeePassword { get; set; }

    public string EmployeeGender { get; set; } = null!;

    public virtual ICollection<Leaveallocated> Leaveallocateds { get; set; } = new List<Leaveallocated>();

    public virtual ICollection<Leavedetail> Leavedetails { get; set; } = new List<Leavedetail>();
}
