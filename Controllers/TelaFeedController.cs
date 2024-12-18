using Microsoft.AspNetCore.Mvc;
using findPet.Models;

namespace findPet.Controllers
{
    public class TelaFeedController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(telaFeedModel telaFeedModel)
        {
            if (ModelState.IsValid)
            {
                // Simula salvar o pet no banco de dados
                TempData["SuccessMessage"] = "Pet cadastrado com sucesso!";
                return RedirectToAction("Create");

            }
            //teste luiz bora bill e fi do bill
            return View(telaFeedModel);
        }
    }
}

