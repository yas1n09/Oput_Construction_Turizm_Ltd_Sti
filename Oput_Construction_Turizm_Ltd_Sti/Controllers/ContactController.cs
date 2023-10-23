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
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        public IActionResult Index()
        {
            var values = contactManager.TGetList();
            return View(values);
        }
        //[HttpGet]
        //public IActionResult AddContact()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult AddContact(Contact contact)
        //{
        //    ContactValidator validations = new ContactValidator();
        //    ValidationResult results = validations.Validate(contact);
        //    if (results.IsValid)
        //    {
        //        contactManager.TAdd(contact);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        foreach (var item in results.Errors)
        //        {
        //            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        //        }
        //    }
        //    return View();
        //}

        public IActionResult DeleteContact(int id)
        {
            var values = contactManager.TGetByID(id);
            contactManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditContact(int id)
        {
            var values = contactManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditContact(Contact contact)
        {
            ContactValidator validations = new ContactValidator();
            ValidationResult results = validations.Validate(contact);
            if (results.IsValid)
            {
                contactManager.TUpdate(contact);
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
