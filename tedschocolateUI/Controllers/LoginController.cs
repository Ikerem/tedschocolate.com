using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using tedschocolateUI.ViewComponents.UserLoginRegisterViewModel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace tedschocolateUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<CeoUser> _signInManager;

        public LoginController(SignInManager<CeoUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginRegisterViewModel p)
        {

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "AdminHomePage");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kualncı adı veya şifre");
                }
            }
            return View();
        }
     
    }
}
