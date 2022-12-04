using Microsoft.AspNetCore.Mvc;

namespace FRS.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
