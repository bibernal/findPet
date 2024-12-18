using Microsoft.AspNetCore.Mvc;
using findPet.Models;

namespace findPet.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public IActionResult Login(TelaLoginModel model)
        {
            if (ModelState.IsValid)
            {
                // L�gica para verificar credenciais do usu�rio
                bool usuarioValido = ValidarUsuario(model.Email, model.Senha);

                if (usuarioValido)
                {
                    // Redireciona para a p�gina inicial
                    return RedirectToAction("Dashboard");
                }

                // Exibe uma mensagem de erro se as credenciais estiverem erradas
                ModelState.AddModelError(string.Empty, "Email ou senha inv�lidos.");
            }

            return View(model);
        }

        public IActionResult Dashboard()
        {
            // P�gina inicial ap�s login bem-sucedido
            return View();
        }

        private bool ValidarUsuario(string email, string senha)
        {
            // Aqui voc� implementa a l�gica de valida��o (banco de dados ou servi�o externo)
            // Exemplo: Retornar verdadeiro para simula��o de sucesso
            return email == "teste@exemplo.com" && senha == "senha123";
        }
    }
}
