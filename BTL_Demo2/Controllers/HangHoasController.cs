using BTL_Demo2.Data;
using BTL_Demo2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BTL_Demo2.Controllers
{
    public class HangHoasController : Controller
    {
        private readonly QuanLyCafeContext db;

        public HangHoasController(QuanLyCafeContext context)
        {
            db = context;
        }
        public IActionResult Index(string loai)
        {
            var hangHoas = db.HangHoas.AsQueryable();
            if (!string.IsNullOrEmpty(loai))
            {
                hangHoas = hangHoas.Where(p => p.MaLoai == loai);
            }

            // Select relevant properties to return to the view
            var result = hangHoas.Select(p => new HangHoaVM
            {
                MaHh = p.MaHh,
                TenHh = p.TenHh,     // Add more properties as needed
                DonGia = (double)p.DonGia,
                MoTaNgan = p.MoTa,
                MaLoai = p.MaLoai,// Example property
                Anh =p.Anh
            });

            return View(result);
        }
    }
}
