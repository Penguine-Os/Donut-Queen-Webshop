using Microsoft.AspNetCore.Mvc;

namespace DonutQueen_Web.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
