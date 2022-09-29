using DonutQueen_DAL.IRepositories;
using DonutQueen_DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DonutQueen_Web.Controllers
{
    public class ShopController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public ShopController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View(_unitOfWork.DonutRepo.GetAll());
        }
       public IActionResult Detail(int id)
        {
            if (id <=0)
                return View();

            return View(_unitOfWork.DonutRepo.GetById(id));
        }
     




    }
}
