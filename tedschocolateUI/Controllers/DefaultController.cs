using Bussines.Concrete;
using Bussines.ValidationFlutter;
using Dataaccses.Concrete;
using Dataaccses.EntityFreamwork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace tedschocolateUI.Controllers
{
    [Authorize]
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult NavBarpartial()
        {
            return PartialView();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult Send()
        {
           

            
            return View();
        }
        [HttpPost]
        public IActionResult Send(SendMessage sendMessage)
        {
            EFSendMessageManager eFSendMessageMannger = new EFSendMessageManager(new EFSendMessageDal());
            Convert.ToDateTime(DateTime.Now.ToShortDateString());
            SendValidator validations = new SendValidator();
            ValidationResult result=validations.Validate(sendMessage);
  
            if (result.IsValid)
            {
                eFSendMessageMannger.tInsert(sendMessage);
            return RedirectToAction("Index", "OrderSuccsess");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                   
                }
            }
            return View();



        }
    }
}
