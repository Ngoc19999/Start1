using System;
using System.Collections.Generic;

namespace CrawlContent.DataAccess.Entities;

public partial class SanPhamMoi
{
    public string TenSp { get; set; } = null!;

    public int IdSp { get; set; }

    public decimal Dongia { get; set; }

    public string Xuatxu { get; set; } = null!;

    public DateTime Ngaysx { get; set; }

    public DateTime Ngayhh { get; set; }

    public virtual ICollection<GiaoDichMoi> GiaoDichMois { get; set; } = new List<GiaoDichMoi>();

    public virtual ICollection<KhoHangMoi> KhoHangMois { get; set; } = new List<KhoHangMoi>();
}
