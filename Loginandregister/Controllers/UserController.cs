using Microsoft.AspNetCore.Mvc;

namespace Loginandregister.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
