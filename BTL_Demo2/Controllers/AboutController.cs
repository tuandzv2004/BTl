using Microsoft.AspNetCore.Mvc;

namespace BTL_Demo2.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
