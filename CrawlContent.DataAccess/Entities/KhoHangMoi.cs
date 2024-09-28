using System;
using System.Collections.Generic;

namespace CrawlContent.DataAccess.Entities;

public partial class KhoHangMoi
{
    public int Idnhap { get; set; }

    public int Idsp { get; set; }

    public int Soluong { get; set; }

    public DateTime NgayNhap { get; set; }

    public decimal DonGia { get; set; }

    public virtual SanPhamMoi IdspNavigation { get; set; } = null!;
}
