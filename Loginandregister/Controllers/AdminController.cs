using Microsoft.AspNetCore.Mvc;

namespace Loginandregister.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
