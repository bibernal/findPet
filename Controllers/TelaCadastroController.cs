using Microsoft.AspNetCore.Mvc;
using findPet.Models;

namespace findPet.Controllers
{
    public class TelaCadastroController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Define a codificação de resposta para UTF-8
            Response.ContentType = "text/html; charset=utf-8";
            return View();
        }

    }
}