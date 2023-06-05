using Bussines.Concrete;
using Dataaccses.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace tedschocolateUI.ViewComponents.OurChocolatesList
{
    public class OurChocolatesList:ViewComponent
    {
        EFOurChocolatesManager _EFOurChocolatesManager = new EFOurChocolatesManager(new EFOurChocolatesDal());

        public IViewComponentResult Invoke()
        {
            
            var values = _EFOurChocolatesManager.tGetList();
            return View(values);
        }
    }
}
