using ControleContatos.Data;
using ControleContatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleContatos.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato); //inserindo no banco       
            _bancoContext.SaveChanges(); //confirmação
            return contato; //retorno
            //gravar no banco de dados
        }

        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
            {
            return _bancoContext?.Contatos?.ToList();
        }

        public ContatoModel Atualizar(ContatoModel contato) //atualizando os dados no banco de dados com as informações da model
        {
            ContatoModel contatoDb = ListarPorId(contato.Id);

            if (contatoDb == null) throw new Exception("Houve um erro na atualização do contato");

            contatoDb.Nome = contato.Nome;
            contatoDb.Email = contato.Email;
            contatoDb.Celular = contato.Celular;

            _bancoContext.Contatos.Update(contatoDb);
            _bancoContext.SaveChanges();

            return contatoDb;
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDb = ListarPorId(id);

            if (contatoDb == null) throw new Exception("Houve um erro na deleção desse contato");

            _bancoContext.Contatos.Remove(contatoDb);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
