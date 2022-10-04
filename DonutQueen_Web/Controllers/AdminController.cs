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
        public IActionResult CreateDonut(Donut donut)
        {

            if (!ModelState.IsValid)
                return View();

            _unitOfWork.DonutRepo.AddObjToDb(donut);
            try
            {

                _unitOfWork.Save();
                return RedirectToAction("Donuts");
            }
            catch (Exception)
            {

                return View();
            }




            return RedirectToAction("Donuts");
        }


        public IActionResult UpdateDonut(int id)
        {

            if (id == 0)
                return View();


            var donut = _unitOfWork.DonutRepo.GetById(id);
            if (donut is null)
                return RedirectToAction("donuts");



            return View(donut);
        }

        [HttpPost]
        public IActionResult UpdateDonut(Donut donut)
        {

            if (!ModelState.IsValid)
                return View();

            _unitOfWork.DonutRepo.UpdateObj(donut);
            _unitOfWork.Save();

            return RedirectToAction("Donuts");
        }

        public IActionResult DeleteDonut(int id)
        {

            if (id == 0)
                return View();


            var donut = _unitOfWork.DonutRepo.GetById(id);
            if (donut is null)
                return RedirectToAction("donuts");



            return View(donut);
        }
        [HttpPost, ActionName("DeleteDonut")]
        public IActionResult DeleteDonut(Donut donut)
        {

            if (donut != null)
            {
                _unitOfWork.DonutRepo.DeleteObj(donut);
                _unitOfWork.Save();
                
            }
            return RedirectToAction("donuts");

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
