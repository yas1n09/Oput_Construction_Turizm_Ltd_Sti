using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Oput_Construction_Turizm_Ltd_Sti.ViewComponents.Project
{
    public class ProjectList : ViewComponent
    {
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        public IViewComponentResult Invoke()
        {
            var values = projectManager.TGetList();
            return View(values);
        }
    }
}
