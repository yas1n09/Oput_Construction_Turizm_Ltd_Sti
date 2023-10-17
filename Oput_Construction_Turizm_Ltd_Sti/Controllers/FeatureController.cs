using Microsoft.AspNetCore.Mvc;

namespace Oput.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
