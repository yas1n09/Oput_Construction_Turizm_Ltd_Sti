using Microsoft.AspNetCore.Mvc;

namespace Oput_Construction_Turizm_Ltd_Sti.ViewComponents.Contact
{
    public class SendMessage :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
