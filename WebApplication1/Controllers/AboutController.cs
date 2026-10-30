using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// About controller
    /// </summary>
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
