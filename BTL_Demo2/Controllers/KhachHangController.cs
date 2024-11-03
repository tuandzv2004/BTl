using BTL_Demo2.Data;
using BTL_Demo2.Helpers;
using BTL_Demo2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class KhachHangController : Controller
{
    private readonly QuanLyCafeContext _dbContext;

    public KhachHangController(QuanLyCafeContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult DangKy()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> DangKy(RegisterVM model)
    {
        if (ModelState.IsValid)
        {
            // Check if the customer already exists
            KhachHang? existingCustomer = await _dbContext.KhachHang
                .FirstOrDefaultAsync(k => k.DienThoai == model.DienThoai);

            if (existingCustomer != null)
            {
                TempData["Message"] = "Chào mừng bạn đã trở lại HiHi Coffee!";
                return RedirectToAction("Index", "Home");
            }

            // Create new customer
            var khachHang = new KhachHang
            {
                MaKH = MyUtil.GenerateCustomerKey(), // Ensure to use the correct property
                TenKH = model.TenKH,
                DienThoai = model.DienThoai,
                Email = model.Email
            };

            // Add new customer to the database
            _dbContext.KhachHang.Add(khachHang);
            await _dbContext.SaveChangesAsync();

            // Create a new ChiTietGioHang entry
            var chiTietGioHang = new ChiTietGioHang
            {
                MaKH = khachHang.MaKH, // Set the foreign key
                HH01 = 0, // Initialize quantities (you can adjust as needed)
                HH02 = 0,
                HH03 = 0,
                HH04 = 0,
                HH05 = 0,
                HH06 = 0,
                HH07 = 0,
                HH08 = 0,
                HH09 = 0,
                HH10 = 0,
                HH11 = 0,
                HH12 = 0,
                HH13 = 0,
                HH14 = 0,
                HH15 = 0,
                HH16 = 0,
                HH17 = 0,
                HH18 = 0,
                HH19 = 0,
                HH20 = 0,
                HH21 = 0,
                HH22 = 0,
                HH23 = 0,
                HH24 = 0,
                HH25 = 0,
                HH26 = 0,
                HH27 = 0,
                HH28 = 0,
                HH29 = 0,
                HH30 = 0,
                HH31 = 0,
                HH32 = 0,
                HH33 = 0,
                HH34 = 0,
                HH35 = 0,
                HH36 = 0,
                HH37 = 0,
                HH38 = 0,
                HH39 = 0,
                HH40 = 0,
                HH41 = 0,
                HH42 = 0,
                HH43 = 0,
                HH44 = 0,
                HH45 = 0,
                HH46 = 0,
                HH47 = 0,
                HH48 = 0,
                HH49 = 0,
                HH50 = 0,
                TongTien = 0, // Set initial total (calculate later as needed)
                PhuongThuc = model.PhuongThuc, // Set method from model
                DiaChi = model.PhuongThuc == "Delivery" ? model.DiaChi : null, // Set address based on method
                ThoiGian = DateTime.Now // Store the current time
            };

            // Add to ChiTietGioHang and save changes
            _dbContext.ChiTietGioHangs.Add(chiTietGioHang);
            await _dbContext.SaveChangesAsync();

            TempData["Message"] = "Chào mừng bạn đến với HiHi Coffee!";
            return RedirectToAction("Index", "Home");
        }

        return View(model);
    }
}
