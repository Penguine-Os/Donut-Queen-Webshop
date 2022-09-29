using DonutQueen_DAL.IRepositories;
using DonutQueen_DAL.Repositories;
using DonutQueen_Models;
using DonutQueen_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DonutQueen_Web.Controllers
{
    public class AdminController : Controller
    {
        IUnitOfWork _unitOfWork;
        DonutViewModel _donutViewModel = new DonutViewModel();

        public AdminController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _donutViewModel.Donuts = _unitOfWork.DonutRepo.GetAll();

        }

        public IActionResult Donuts()
        {
            return View(_donutViewModel);
        }
        public IActionResult DonutDetail(int id)
        {
            _unitOfWork.DonutRepo.GetById(id);
            return View(_unitOfWork.DonutRepo.GetById(id));
        }
        [HttpGet]
        public IActionResult CreateDonut()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateDonut(DonutViewModel donutViewModel)
        {
            
            decimal prijs;
            if (!string.IsNullOrWhiteSpace(donutViewModel.Prijs))

                if (decimal.TryParse(donutViewModel.Prijs, out prijs))

                    donutViewModel.Donut.Prijs = prijs;



            int id = _unitOfWork.DonutRepo.AddObjToDb(donutViewModel.Donut);



            return RedirectToAction("Donus");
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
