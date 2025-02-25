using ControleContatos.Data;
using ControleContatos.Models;
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

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
    }
}
