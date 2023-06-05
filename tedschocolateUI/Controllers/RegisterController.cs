using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;
using tedschocolateUI.ViewComponents.UserRegisterViewModel;

namespace tedschocolateUI.Controllers
{
    public class RegisterController : Controller
    {
      private  readonly  UserManager<CeoUser> _userManager;

        public RegisterController(UserManager<CeoUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }
        [HttpPost]
        public async Task< IActionResult >Index(UserRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                CeoUser w = new CeoUser()
                {


                    Name = model.Name,
                    Surname = model.Surname,
                    UserName = model.UserName,
                    Email = model.Mail

                };

                if (model.Password == model.ConfirmPasword)
                {

                    var result = await _userManager.CreateAsync(w, model.Password);


                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);

                        }
                    }
                }
            }



            return View();
        }
    }
}
