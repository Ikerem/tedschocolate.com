using Bussines.Concrete;
using Dataaccses.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace tedschocolateUI.ViewComponents.HomePageList
{
    public class HomePageList:ViewComponent
    {
        EFHomePageManager _homePageManager= new EFHomePageManager(new EFHomePageDal());
        public IViewComponentResult Invoke()
        {
            var values = _homePageManager.tGetList();
            return View(values);
        }

    }
}
