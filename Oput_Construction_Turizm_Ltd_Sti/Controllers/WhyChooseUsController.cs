using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Oput.Controllers
{
    public class WhyChooseUsController : Controller
    {
        WhyChooseUsManager whyChooseUsManager = new WhyChooseUsManager(new EfWhyChooseUsDal());
        public IActionResult Index()
        {
            var values = whyChooseUsManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddWhyChooseUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWhyChooseUs(WhyChooseUs whyChooseUs)
        {
            WhyChooseUsValidator validations = new WhyChooseUsValidator();
            ValidationResult results = validations.Validate(whyChooseUs);
            if (results.IsValid)
            {
                whyChooseUsManager.TAdd(whyChooseUs);
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

        public IActionResult DeleteWhyChooseUs(int id)
        {
            var values = whyChooseUsManager.TGetByID(id);
            whyChooseUsManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditWhyChooseUs(int id)
        {
            var values = whyChooseUsManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditWhyChooseUs(WhyChooseUs whyChooseUs)
        {
            WhyChooseUsValidator validations = new WhyChooseUsValidator();
            ValidationResult results = validations.Validate(whyChooseUs);
            if (results.IsValid)
            {
                whyChooseUsManager.TUpdate(whyChooseUs);
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
