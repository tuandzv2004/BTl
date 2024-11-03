using BTL_Demo2.Data;
using BTL_Demo2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BTL_Demo2.ViewComPonents
{
    public class MenuLoaiViewComponent : ViewComponent
    {
        private readonly QuanLyCafeContext db;

        public MenuLoaiViewComponent(QuanLyCafeContext context)=> db = context;
        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(lo => new MenuLoaiVM
            {
               MaLoai= lo.MaLoai,
               TenLoai= lo.TenLoai,
               SoLuong= lo.SoLuong
            });
            return View(data);
        }
    }
}
