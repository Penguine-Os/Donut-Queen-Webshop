using DonutQueen_DAL.IRepositories;
using DonutQueen_DAL.Repositories;
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
