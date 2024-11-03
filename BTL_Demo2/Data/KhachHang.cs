using System;
using System.Collections.Generic;

namespace BTL_Demo2.Data;

public partial class KhachHang
{


    public string MaKH { get; set; } // Customer ID (ensure this matches the usage)
    public string TenKH { get; set; }
    public string DienThoai { get; set; }
    public string Email { get; set; }

    public string GioiTinh { get; set; } 



    public virtual ICollection<GopY> Gopies { get; set; } = new List<GopY>();

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    public ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }

}
