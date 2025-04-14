using ControleContatos.Models;
using ControleContatos.Repository;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ControleContatos.Controllers
{
    public class LoginController : Controller
    {


        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController (IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }



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

                  UsuarioModel usuario =  _usuarioRepository.BuscarPorLogin(loginModel.Login);

                    if(usuario != null)
                    {
                        if(usuario.SenhaValida(loginModel.Senha))
                        {
                            return RedirectToAction("Index", "Home");
                        }

                        TempData["MensagemErro"] = $"A senha do usuário é inválida. Por favor tente novamente.";
                    }
                    

                    TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s). Por favor tente novamente.";
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
