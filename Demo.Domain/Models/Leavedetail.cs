using System;
using System.Collections.Generic;

namespace Demo.Common.Models;

public partial class Leavedetail
{
    public int LeaveId { get; set; }

    public int NoOfDays { get; set; }

    public DateOnly FromDate { get; set; }

    public DateOnly ToDate { get; set; }

    public string Reason { get; set; } = null!;

    public string? Status { get; set; }

    public int EmployeeDetailsEmployeeId { get; set; }

    public int LeaveTypesId { get; set; }

    public int AdminDetailsAdminId { get; set; }

    public virtual Admindetail AdminDetailsAdmin { get; set; } = null!;

    public virtual Employeedetail EmployeeDetailsEmployee { get; set; } = null!;

    public virtual Leavetype LeaveTypes { get; set; } = null!;
}
