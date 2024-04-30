using System;
using System.Collections.Generic;

namespace Demo.Common.Models;

public partial class Leaveallocated
{
    public int Id { get; set; }

    public int Cl { get; set; }

    public int Lop { get; set; }

    public int Ml { get; set; }

    public int Pl { get; set; }

    public int SickLeave { get; set; }

    public int Permission { get; set; }

    public int OnDuty { get; set; }

    public int EmployeeDetailsEmployeeId { get; set; }

    public virtual Employeedetail EmployeeDetailsEmployee { get; set; } = null!;
}
