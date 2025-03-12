using ControleContatos.Models;
using ControleContatos.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ControleContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly ContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = (ContatoRepository)contatoRepository;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepository.BuscarTodos();
            return View(contatos);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
          ContatoModel contato =  _contatoRepository.ListarPorId(id);
            return View(contato);
        }

        public IActionResult DeleteConfirm(int id)
        {
            ContatoModel contato = _contatoRepository.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Apagar(int id)
        {
            _contatoRepository.Apagar(id);
            return RedirectToAction("Index");
            
        }



        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepository.Adicionar(contato);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            _contatoRepository.Atualizar(contato);
            return RedirectToAction("Index");
        }
    }
}
