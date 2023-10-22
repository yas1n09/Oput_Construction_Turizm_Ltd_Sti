using Microsoft.AspNetCore.Mvc;

namespace Oput.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
