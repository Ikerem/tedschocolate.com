using Bussines.Concrete;
using Dataaccses.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace tedschocolateUI.Controllers
{
    public class OrderSuccsess : Controller
    {
        EFSendMessageManager messageManager = new EFSendMessageManager(new EFSendMessageDal());
        public IActionResult Index()
        {
           
              
            return View();
        }
    }
}
