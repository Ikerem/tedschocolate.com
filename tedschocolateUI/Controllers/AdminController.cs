using Microsoft.AspNetCore.Mvc;

namespace tedschocolateUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Header()
        {
            return View();
        }
        public IActionResult NavBar()
        {
            return View();
        }
        public IActionResult SideBar()
        {
            return View();
        }
    }
}
