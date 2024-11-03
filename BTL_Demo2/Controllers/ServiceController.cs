using Microsoft.AspNetCore.Mvc;

namespace BTL_Demo2.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
