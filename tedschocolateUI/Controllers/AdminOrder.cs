using Bussines.Concrete;
using Dataaccses.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace tedschocolateUI.Controllers
{
    public class AdminOrder : Controller
    {
        EFSendMessageManager _messageManager = new EFSendMessageManager(new EFSendMessageDal());
        public IActionResult Index()
        {
            var VALUES = _messageManager.tGetList();
            return View(VALUES);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var values = _messageManager.tGetByID(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult Details(SendMessage send)
        {
            _messageManager.tUpdate(send);
            return  RedirectToAction("Index");
        }
        public IActionResult DeleteSend(int id)
        {
            var values = _messageManager.tGetByID(id);
            _messageManager.tDelete(values);
            return RedirectToAction("Index");
        }
    }
}
