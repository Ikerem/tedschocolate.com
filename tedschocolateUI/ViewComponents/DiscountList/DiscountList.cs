using Bussines.Concrete;
using Dataaccses.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace tedschocolateUI.ViewComponents.DiscountList
{
    public class DiscountList:ViewComponent
    {
        EFDiscountManager _EFDiscountManager = new EFDiscountManager(new EFDiscountDal());
        public IViewComponentResult Invoke()
        {
            var values = _EFDiscountManager.tGetList();
            return View(values);
        }
    }
}
