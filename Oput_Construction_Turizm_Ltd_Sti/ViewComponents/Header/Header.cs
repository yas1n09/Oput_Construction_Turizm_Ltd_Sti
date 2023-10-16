using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Oput_Construction_Turizm_Ltd_Sti.ViewComponents.Header
{
    public class Header : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
