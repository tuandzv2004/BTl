using System;
using System.Collections.Generic;

namespace BTL_Demo2.Data;

public partial class ChiTietHd
{
    public string MaCt { get; set; } = null!;

    public string MaHd { get; set; } = null!;

    public string MaHh { get; set; } = null!;

    public double DonGia { get; set; }

    public int SoLuong { get; set; }

    public double GiamGia { get; set; }

    public virtual HoaDon MaHdNavigation { get; set; } = null!;

    public virtual HangHoa MaHhNavigation { get; set; } = null!;
}
