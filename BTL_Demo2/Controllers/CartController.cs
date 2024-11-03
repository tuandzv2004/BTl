using BTL_Demo2.Data;
using BTL_Demo2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using BTL_Demo2.Helpers;

namespace BTL_Demo2.Controllers
{
	public class CartController : Controller
	{
		private readonly QuanLyCafeContext db;

		public CartController(QuanLyCafeContext context) {
			db= context;
		}
		const string CART_KEY = "MY CART";
		public List<CartItem> Cart => HttpContext.Session.Get<List<CartItem>>(CART_KEY) ?? new List<CartItem>();
		public IActionResult Index()
		{
			return View(Cart);
		}
		public IActionResult AddToCart(string  id, int quantity =1)
		{
			var gioHang = Cart;
			var item = gioHang.SingleOrDefault(p => p.MaHh == id);
			if (item == null)
			{
				var hangHoa = db.HangHoas.SingleOrDefault(p => p.MaHh == id);
				if (hangHoa==null)
				{
					TempData["Message"] = $"Không tìm thấy hàng hóa ";
					return Redirect("/404");
				}
				item = new CartItem
				{
					MaHh = hangHoa.MaHh,
					TenHH = hangHoa.TenHh,
					DonGia = hangHoa.DonGia ?? 0,
					Hinh = hangHoa.Anh ?? string.Empty,
					SoLuong = quantity
				};
				gioHang.Add(item);
			}
			else
			{
				item.SoLuong += quantity;
			}
			HttpContext.Session.Set(CART_KEY, gioHang);
			return RedirectToAction("Index");
		}
		public IActionResult RemoveCart(string id)
		{
			var gioHang = Cart;
			var item = gioHang.SingleOrDefault(p => p.MaHh == id);
			if (item != null)
			{
				gioHang.Remove(item);
				HttpContext.Session.Set(CART_KEY, gioHang);
			}
			return RedirectToAction("Index");
		}
	}
}
