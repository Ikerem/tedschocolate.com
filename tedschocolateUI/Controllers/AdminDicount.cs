using Bussines.Concrete;
using Dataaccses.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace tedschocolateUI.Controllers
{
    public class AdminDicount : Controller
    {
        EFDiscountManager _discountManager= new EFDiscountManager(new EFDiscountDal());
        public IActionResult Index()
        {
            var VALUES = _discountManager.GetList();
          
            return View(VALUES);
        }
        [HttpGet]
        public IActionResult EditDiscount(int id)
        {
            var values = _discountManager.tGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditDiscount(Discount discount)
        {
            _discountManager.tUpdate(discount);


            return RedirectToAction("Index");
        }
    }
}
