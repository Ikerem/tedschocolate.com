using Microsoft.AspNetCore.Mvc;

namespace tedschocolateUI.Controllers
{
    public class DashboardAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
