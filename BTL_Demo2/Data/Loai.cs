using System;
using System.Collections.Generic;

namespace BTL_Demo2.Data
{
    public class Loai
    {
        

        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public int SoLuong { get; set; }


        // Thuộc tính điều hướng tới HangHoa
        //  public ICollection<HangHoa> HangHoas { get; set; }
    }
}
