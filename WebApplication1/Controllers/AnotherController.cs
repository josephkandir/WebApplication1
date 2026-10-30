using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    // D7
    public class AnotherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
