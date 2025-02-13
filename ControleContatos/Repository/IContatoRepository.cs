using ControleContatos.Models;

namespace ControleContatos.Repository
{
    public interface IContatoRepository
    {
        ContatoModel Adicionar(ContatoModel contato); //contrato adicionar que recebe como parametro um objeto contato e vai retornar o mesmo
    }
}
