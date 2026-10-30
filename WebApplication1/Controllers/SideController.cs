using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    // D4
    public class SideController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
