using Microsoft.AspNetCore.Mvc;

namespace BTL_Demo2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
