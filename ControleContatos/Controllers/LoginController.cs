using ControleContatos.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ControleContatos.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar (LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index", "Home");
                }
                return View("Index");
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamente, mais detalhes do erro:{erro.Message}";
                return RedirectToAction("Index");
            }
        }

    }
}
