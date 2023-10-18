using Microsoft.AspNetCore.Mvc;

namespace Oput.ViewComponents.Contact
{
    public class SendMessage :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
