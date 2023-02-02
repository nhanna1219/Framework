using System;
using System.Collections.Generic;

namespace Car_Maintenance.Models;

public partial class Khachhang
{
    public string Makh { get; set; } = null!;

    public string? Hotenkh { get; set; }

    public string? Diachi { get; set; }

    public string? Dienthoai { get; set; }

    public virtual ICollection<Xe> Xes { get; } = new List<Xe>();
}
