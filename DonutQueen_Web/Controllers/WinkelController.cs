using Microsoft.AspNetCore.Mvc;

namespace DonutQueen_Web.Controllers
{
    public class WinkelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
