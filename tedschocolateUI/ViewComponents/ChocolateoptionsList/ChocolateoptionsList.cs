using Bussines.Concrete;
using Dataaccses.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace tedschocolateUI.ViewComponents.ChocolateoptionsList
{
    public class ChocolateoptionsList:ViewComponent
    {
        EFChocolateoptionsListManager listManager = new EFChocolateoptionsListManager (new EFChocolateoptionsListDal());
        public IViewComponentResult Invoke()
        {
            var values = listManager.tGetList();
            return View(values);
        }
    }
}
