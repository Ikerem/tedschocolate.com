using Bussines.Concrete;
using Dataaccses.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace tedschocolateUI.Controllers
{
    public class AdminAbout : Controller
    {
        EFAboutManager _EFAboutManager = new EFAboutManager(new EFAboutDal());
        public IActionResult Index()
        {
            var values = _EFAboutManager.GetList();

            return View(values);
        }
        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var values = _EFAboutManager.tGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            _EFAboutManager.tUpdate(about);


            return RedirectToAction("Index");
        }
    }
}
