using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    // D4
    public class SideController : Controller
    {
        /// <summary>
        /// D5
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            // D6
            return View();
        }
    }
}
