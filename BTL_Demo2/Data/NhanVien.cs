using System;
using System.Collections.Generic;

namespace BTL_Demo2.Data;

public partial class NhanVien
{
    public string MaNv { get; set; } = null!;

    public string TenNv { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public bool GioiTinh { get; set; }

    public DateTime NgaySinh { get; set; }

    public virtual ICollection<PhanCong> PhanCongs { get; set; } = new List<PhanCong>();
}
