using DonutQueen_Web.Data.Repositories;
using DonutQueen_Web.Data.IRepositories;
using DonutQueen_Web.Data.Access;
using DonutQueen_Models;
using DonutQueen_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DonutQueen_Web.Controllers
{
    public class WinkelController : Controller
    {
        IWinkelRepo _winkelRepo = new WinkelRepo();
        WinkelViewModel _winkelVM = new WinkelViewModel();
        
        public IActionResult Index()
        {
            _winkelVM.Winkels = _winkelRepo.GetAll();
            
            return View(_winkelVM);
        }
        
        public IActionResult Search(WinkelViewModel WinkelVM)
        {
            _winkelVM.Winkels = _winkelRepo.GetByName(WinkelVM.SearchQuery);
            
            return View("Index",_winkelVM);
        }
    }
}
