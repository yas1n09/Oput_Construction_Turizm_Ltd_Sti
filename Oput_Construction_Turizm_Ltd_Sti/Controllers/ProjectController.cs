using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Oput.Controllers
{
    [Authorize(Roles = "Admin")]

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

            ProjectValidator validations = new ProjectValidator();
            ValidationResult results = validations.Validate(project);
            if (results.IsValid)
            {
                projectManager.TAdd(project);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
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
            ProjectValidator validations = new ProjectValidator();
            ValidationResult results = validations.Validate(project);
            if (results.IsValid)
            {
                projectManager.TUpdate(project);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
