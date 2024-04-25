using LuanDonde.Data;
using LuanDonde.Models;
using LuanDonde.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace LuanDonde.Controllers
{
    public class ContactController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;   
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact obj)
        {
            if (ModelState.IsValid)
            {
                // _unitOfWork.Add(obj);
                // _unitOfWork.Save();
            }

            // TempData["success"] = "Contato Atualizado com sucesso!";
            return RedirectToAction("Index", "AssessmentForm", obj.Id);
        }
    }
}
