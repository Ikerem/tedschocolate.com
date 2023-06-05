using Bussines.Concrete;
using Dataaccses.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace tedschocolateUI.Controllers
{
    public class AdminHomePage : Controller
    {
        EFHomePageManager _EFHomePageManager= new EFHomePageManager(new EFHomePageDal());
        public IActionResult Index()
        {
            var values = _EFHomePageManager.GetList();
            
            return View(values);
        }
        [HttpGet]
        public IActionResult EditHomePage(int id)
        {
            var values = _EFHomePageManager.tGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditHomePage(Homepage home)
        {
            _EFHomePageManager.tUpdate(home);


            return RedirectToAction("Index");
        }

    }
}
