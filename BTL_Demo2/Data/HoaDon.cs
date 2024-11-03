using System;
using System.Collections.Generic;

namespace BTL_Demo2.Data;

public partial class HoaDon
{
    public string MaHd { get; set; } = null!;

    public string MaKh { get; set; } = null!;

    public DateTime NgayDat { get; set; }

    public DateTime? NgayCan { get; set; }

    public DateTime? NgayGiao { get; set; }

    public double PhiVanChuyen { get; set; }

    public string MaTrangThai { get; set; } = null!;

    public virtual ICollection<ChiTietHd> ChiTietHds { get; set; } = new List<ChiTietHd>();

    public virtual KhachHang MaKhNavigation { get; set; } = null!;

    public virtual ICollection<PhanCong> PhanCongs { get; set; } = new List<PhanCong>();
}
