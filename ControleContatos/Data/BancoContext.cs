using Microsoft.EntityFrameworkCore;

namespace ControleContatos.Data
{
    public class BancoContext : DbContext  //contexto do entity framework do banco de dados
    {
        public BancoContext(DbContextOptions <BancoContext> options) : base(options)//injetar como parametro de entrada o dbcontext e tipar ele como banco context, db options como parametro de entrada.
        {
            
        }


    }
}
