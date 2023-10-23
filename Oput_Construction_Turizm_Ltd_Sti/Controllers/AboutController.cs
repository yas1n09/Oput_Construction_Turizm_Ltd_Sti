using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Oput.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var values = aboutManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var values = aboutManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            AboutValidator validations = new AboutValidator();
            ValidationResult results = validations.Validate(about);

            if(results.IsValid)
            {
                aboutManager.TUpdate(about);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(about);

            
        }
    }
}
