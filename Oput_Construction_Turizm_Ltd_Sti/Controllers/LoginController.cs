using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Oput.Models;

namespace Oput.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result=await _signInManager.PasswordSignInAsync(p.Email,p.Password,false,true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Feature");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı Kullanıcı Adı veya Parola");
                }
            }
            return View();
        }
    }
}
