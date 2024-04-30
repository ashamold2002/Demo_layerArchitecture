using System;
using System.Collections.Generic;

namespace Demo.Common.Models;

public partial class Rolebasedadmin
{
    public int Id { get; set; }

    public string DesignationName { get; set; } = null!;

    public int DetailsAdminId { get; set; }

    public virtual Admindetail DetailsAdmin { get; set; } = null!;
}
