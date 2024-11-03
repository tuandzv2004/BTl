using System;
using System.Collections.Generic;

namespace BTL_Demo2.Data;

public partial class GopY
{
    public string MaGy { get; set; } = null!;

    public string MaCd { get; set; } = null!;

    public string NoiDung { get; set; } = null!;

    public DateOnly NgayGy { get; set; }

    public string? MaKh { get; set; }

    public bool CanTraLoi { get; set; }

    public string? NoiDungTl { get; set; }

    public DateOnly? NgayTl { get; set; }

    public virtual ChuDe MaCdNavigation { get; set; } = null!;

    public virtual KhachHang? MaKhNavigation { get; set; }
}
