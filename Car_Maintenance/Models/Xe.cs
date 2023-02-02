using System;
using System.Collections.Generic;

namespace Car_Maintenance.Models;

public partial class Xe
{
    public string Soxe { get; set; } = null!;

    public string? Hangxe { get; set; }

    public string? Namsx { get; set; }

    public string? Makh { get; set; }

    public virtual ICollection<Baoduong> Baoduongs { get; } = new List<Baoduong>();

    public virtual Khachhang? MakhNavigation { get; set; }
}
