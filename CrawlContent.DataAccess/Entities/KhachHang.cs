using System;
using System.Collections.Generic;

namespace CrawlContent.DataAccess.Entities;

public partial class KhachHang
{
    public string? Tenkh { get; set; }

    public int Idkh { get; set; }

    public string? Diachikh { get; set; }

    public string? Sdtkh { get; set; }

    public DateTime? Snhatkh { get; set; }

    public virtual ICollection<GiaoDich> GiaoDiches { get; set; } = new List<GiaoDich>();
}
