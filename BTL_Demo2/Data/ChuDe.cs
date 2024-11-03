using System;
using System.Collections.Generic;

namespace BTL_Demo2.Data;

public partial class ChuDe
{
    public string MaCd { get; set; } = null!;

    public string TenCd { get; set; } = null!;

    public string? MoTa { get; set; }

    public virtual ICollection<GopY> Gopies { get; set; } = new List<GopY>();
}
