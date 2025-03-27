using ControleContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleContatos.Data
{
    public class BancoContext : DbContext  //contexto do entity framework do banco de dados
    {
        public BancoContext(DbContextOptions <BancoContext> options) : base(options)//injetar como parametro de entrada o dbcontext e tipar ele como banco context, db options como parametro de entrada.
        {
            
        }

        public DbSet<ContatoModel> Contatos { get; set; }//informar a classe que representa a tabela do banco de dados
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
