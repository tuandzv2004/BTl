using System;
using System.Collections.Generic;

namespace BTL_Demo2.Data;

public partial class PhanCong
{
    public string MaPc { get; set; } = null!;

    public string MaNv { get; set; } = null!;

    public DateTime NgayPhan { get; set; }

    public string MaHd { get; set; } = null!;

    public virtual HoaDon MaHdNavigation { get; set; } = null!;

    public virtual NhanVien MaNvNavigation { get; set; } = null!;
}
