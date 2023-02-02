using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Car_Maintenance.Models;

public partial class Baoduong
{
    public string Mabd { get; set; } = null!;

    [DisplayName("Ngày giờ nhận")]
    public string? Ngaygionhan { get; set; }
    [DisplayName("Ngày giờ trả")]
    public string? Ngaygiotra { get; set; }
    [DisplayName("Số km")]
    public string? Sokm { get; set; }
    [DisplayName("Nội dung")]
    public string? Noidung { get; set; }
    [DisplayName("Số xe")]
    public string? Soxe { get; set; }

    public virtual Xe? SoxeNavigation { get; set; }

    public virtual ICollection<CT_BD> CT_BDs { get; } = new List<CT_BD>();

}
