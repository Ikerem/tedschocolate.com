using Bussines.Concrete;
using Dataaccses.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace tedschocolateUI.ViewComponents.AboutList
{
    public class AboutList:ViewComponent
    {
        EFAboutManager _EFAboutManager = new EFAboutManager(new EFAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = _EFAboutManager.tGetList();
            return View(values);
        }

    }
}
