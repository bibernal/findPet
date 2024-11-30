using Microsoft.AspNetCore.Mvc;
using findPet.Models;

namespace findPet.Controllers
{
    public class TelaCadastro2Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(telaCadastroModel telaCadastroModel)
        {
            return RedirectToAction("Index", "TelaCadastro");
            
        }
        public IActionResult telaCadastro()
        {
            return View();
        }
    }
}

