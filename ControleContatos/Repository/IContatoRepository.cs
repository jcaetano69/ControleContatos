using ControleContatos.Models;
using System.Collections.Generic;

namespace ControleContatos.Repository
{
    public interface IContatoRepository
    {
        ContatoModel ListarPorId(int id); //contrato da interface
        List<ContatoModel> BuscarTodos();

        ContatoModel Adicionar(ContatoModel contato); //contrato adicionar que recebe como parametro um objeto contato e vai retornar o mesmo
        ContatoModel Atualizar(ContatoModel contato);
    }
}
