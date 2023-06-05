using Bussines.Concrete;
using Dataaccses.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace tedschocolateUI.Controllers
{
    public class AdminOurChocolatesList : Controller
    {
        EFOurChocolatesManager _EFOurChocolatesManager=new EFOurChocolatesManager(new EFOurChocolatesDal());
        public IActionResult Index()
        {
            var values = _EFOurChocolatesManager.GetList();
            return View(values);
        }
        public IActionResult DeleteOurChocolate(int id)
        {
            var values = _EFOurChocolatesManager.tGetByID(id);
            _EFOurChocolatesManager.tDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditOurChocolate(int id)
        {
            var values = _EFOurChocolatesManager.tGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditOurChocolate(OurChocolates ourChocolates)
        {
            _EFOurChocolatesManager.tUpdate(ourChocolates);


            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddOurChocolate()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddOurChocolate(OurChocolates p)
        {
            //OurChocolates o = new OurChocolates();
            //if (p.Image != null)
            //{
            //    var extantions = Path.GetExtension(p.Image.FileName);
            //    var  newimage=Guid.NewGuid()+extantions;
            //    var location =Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/chocolux-master/images/", newimage );
            //    var stream= new FileStream(location,FileMode.Create);
            //    p.Image.CopyTo(stream);
            //    o.Image = newimage;
            //}
            //o.title = p.title;
            //o.Description = p.Description;
            //o.Price=p.Price;
          _EFOurChocolatesManager.Insert(p);
           
            return RedirectToAction("Index");
        }
    }
}
