using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Contact controller
    /// </summary>
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
