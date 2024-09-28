using System;
using System.Collections.Generic;

namespace CrawlContent.DataAccess.Entities;

public partial class GiaoDichMoi
{
    public int Idgd { get; set; }

    public int Idkh { get; set; }

    public int Idsp { get; set; }

    public DateTime Ngayban { get; set; }

    public int Giamgia { get; set; }

    public decimal Giacuoi { get; set; }

    public int SoLuongBan { get; set; }

    public decimal TongGiamGia { get; set; }

    public virtual KhachHangMoi IdkhNavigation { get; set; } = null!;

    public virtual SanPhamMoi IdspNavigation { get; set; } = null!;
}
