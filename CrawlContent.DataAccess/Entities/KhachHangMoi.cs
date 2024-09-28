using System;
using System.Collections.Generic;

namespace CrawlContent.DataAccess.Entities;

public partial class KhachHangMoi
{
    public string Tenkh { get; set; } = null!;

    public int Idkh { get; set; }

    public string? Diachikh { get; set; }

    public string? Sdtkh { get; set; }

    public DateTime? Snhatkh { get; set; }

    public virtual ICollection<GiaoDichMoi> GiaoDichMois { get; set; } = new List<GiaoDichMoi>();
}
