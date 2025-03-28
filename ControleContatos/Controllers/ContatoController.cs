﻿using ControleContatos.Models;
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
            try
            {
                bool apagado = _contatoRepository.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Contato apagado com sucesso!";
                }

                else
                {
                    TempData["MensagemErro"] = "Ops, não conseguimos apagar seu contato.";
                }
                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu contato, mais detalhes do erro:{erro.Message}";
                return RedirectToAction("Index");
            }
            
        }



        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepository.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(contato);
            }

            catch (System.Exception error)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu contato, tente novamente, detalhe do erro {error.Message}";
                return RedirectToAction("Index");
            }
            
        }


        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepository.Atualizar(contato);
                    TempData["MensagemSucesso"] = "Contato editado com sucesso";
                    return RedirectToAction("Index");

                }
                return View("Editar", contato);
            }
            catch (System.Exception error)
            {

                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu contato, tente novamente, detalhe do erro {error.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
