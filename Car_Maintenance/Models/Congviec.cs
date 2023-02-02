using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Car_Maintenance.Models;

public partial class Congviec
{
    [DisplayName("Mã công việc")]
    public string Macv { get; set; } = null!;
    [DisplayName("Tên công việc")]
    public string? Tencv { get; set; }
    [DisplayName("Đơn giá")]
    public int Dongia { get; set; }

    public virtual ICollection<CT_BD> CT_BDs { get; } = new List<CT_BD>();
}
