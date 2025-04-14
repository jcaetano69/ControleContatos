using ControleContatos.Models;
using System.Collections.Generic;

namespace ControleContatos.Repository
{

    public interface IUsuarioRepository
    {
        UsuarioModel BuscarPorLogin(string login);
        UsuarioModel ListarPorId(int id); //contrato da interface
        List<UsuarioModel> BuscarTodos();

        UsuarioModel Adicionar(UsuarioModel usuario); //contrato adicionar que recebe como parametro um objeto contato e vai retornar o mesmo
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);
    }
}
