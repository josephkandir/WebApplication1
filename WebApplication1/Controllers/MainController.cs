using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    // D0
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            // D1
            return View();
        }
    }
}
