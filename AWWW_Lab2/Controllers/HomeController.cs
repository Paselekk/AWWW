using Microsoft.AspNetCore.Mvc;

namespace AWWW_Lab2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
