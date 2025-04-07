using ControleContatos.Data;
using ControleContatos.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ControleContatos.Repository
{
    
        public class UsuarioRepository : IUsuarioRepository
        {
            private readonly BancoContext _bancoContext;
            public UsuarioRepository(BancoContext bancoContext)
            {
                _bancoContext = bancoContext;
            }
            public UsuarioModel Adicionar(UsuarioModel usuario)
            {
                usuario.DataCadastro = DateTime.Now; //dizendo que a data de criação do usuário é junto com a criação do mesmo "now"
                _bancoContext.Usuarios.Add(usuario); //inserindo no banco       
                _bancoContext.SaveChanges(); //confirmação
                return usuario; //retorno
                                //gravar no banco de dados
            }

            public UsuarioModel ListarPorId(int id)
            {
                return _bancoContext.Usuarios.FirstOrDefault(x => x.Id == id);
            }

            public List<UsuarioModel> BuscarTodos()
            {
            return _bancoContext.Usuarios.ToList();
            }

            public UsuarioModel Atualizar(UsuarioModel usuario) //atualizando os dados no banco de dados com as informações da model
            {
                UsuarioModel usuarioDb = ListarPorId(usuario.Id);

                if (usuarioDb == null) throw new Exception("Houve um erro na atualização do usuário!");

                usuarioDb.Nome = usuario.Nome;
                usuarioDb.Login = usuario.Login;
                usuarioDb.Email = usuario.Email;
                usuarioDb.Perfil = usuario.Perfil;
                usuarioDb.DataAlteracao = DateTime.Now;


            _bancoContext.Usuarios.Update(usuarioDb);
                _bancoContext.SaveChanges();

                return usuarioDb;
            }

            public bool Apagar(int id)
            {
                UsuarioModel usuarioDb = ListarPorId(id);

                if (usuarioDb == null) throw new Exception("Houve um erro na deleção desse contato");

                _bancoContext.Usuarios.Remove(usuarioDb);
                _bancoContext.SaveChanges();

                return true;
            }
        }
    }

