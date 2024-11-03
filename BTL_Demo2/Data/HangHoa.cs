using System;
using System.Collections.Generic;

namespace BTL_Demo2.Data;

public partial class HangHoa
{
    public string MaHh { get; set; } = null!;

    public string TenHh { get; set; } = null!;

    public string MaLoai { get; set; } = null!;

    public double? DonGia { get; set; }

    public DateTime NgaySx { get; set; }

    public double GiamGia { get; set; }

    public int SoLanXem { get; set; }

    public string? MoTa { get; set; }
    public string Anh { get; set; } = null!;


    public virtual ICollection<ChiTietHd> ChiTietHds { get; set; } = new List<ChiTietHd>();
    public ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }
}
