using Microsoft.AspNetCore.Mvc;
using findPet.Models;

namespace findPet.Controllers
{
    public class TelaCadastroController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(telaCadastroModel TelaCadastro2)
        {
            return RedirectToAction("Index", "TelaCadastro2");
            
        }
        public IActionResult TelaCadastro2()
        {
            return View();
        }
    }
}

