using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Oput.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        public IActionResult Index()
        {
            var values = projectManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProject()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProject(Project project)
        {
            projectManager.TAdd(project);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProject(int id)
        {
            var values = projectManager.TGetByID(id);
            projectManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditProject(int id)
        {
            var values = projectManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditProject(Project project)
        {
            projectManager.TUpdate(project);
            return RedirectToAction("Index");
        }
    }
}
