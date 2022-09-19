using Microsoft.AspNetCore.Mvc;

namespace DonutQueen_Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Donuts()
        {
            return View();
        }
        public IActionResult Gebruikers()
        {
            return View();
        }
        public IActionResult Orders()
        {
            return View();
        }
        public IActionResult Winkels()
        {
            return View();
        }

    }
}
