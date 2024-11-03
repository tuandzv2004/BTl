using System;
using System.Collections.Generic;

namespace BTL_Demo2.Data;

public partial class VChiTietHoaDon
{
    public string MaCt { get; set; } = null!;

    public string MaHd { get; set; } = null!;

    public string MaHh { get; set; } = null!;

    public double DonGia { get; set; }

    public int SoLuong { get; set; }

    public double GiamGia { get; set; }

    public string TenHh { get; set; } = null!;
}
