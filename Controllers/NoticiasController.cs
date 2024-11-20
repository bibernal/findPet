using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using findPet.Models;

namespace findPet.Controllers;

public class NoticiasController : Controller{
    public IActionResult Index()
    {
        return View(RepositorioNoticias.Noticias);
    }

    [HttpPost]
    public IActionResult Adicionar(Noticia noticia)
    {
        RepositorioNoticias.AdicionarNoticia(noticia);

        return RedirectToAction("Index");
    }
}