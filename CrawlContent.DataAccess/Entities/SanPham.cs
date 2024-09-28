using System;
using System.Collections.Generic;

namespace CrawlContent.DataAccess.Entities;

public partial class SanPham
{
    public string? TenSp { get; set; }

    public int IdSp { get; set; }

    public decimal Dongia { get; set; }

    public string? Xuatxu { get; set; }

    public DateTime Ngaysx { get; set; }

    public DateTime Ngayhh { get; set; }

    public virtual ICollection<GiaoDich> GiaoDiches { get; set; } = new List<GiaoDich>();

    public virtual ICollection<KhoHang> KhoHangs { get; set; } = new List<KhoHang>();
}
