using Microsoft.AspNetCore.Mvc;

namespace Image_Resizing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
