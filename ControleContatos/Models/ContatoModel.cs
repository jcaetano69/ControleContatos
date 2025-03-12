﻿using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; } //vai representar o código do contato, vai ser enumerado.


        //adicionando as validações ao contato model
        [Required(ErrorMessage ="Digite o nome do contato")]
        public string Nome { get; set; }
        [Required (ErrorMessage ="Digite o e-mail do contato")]
        [EmailAddress(ErrorMessage = "O email informado não é válido")]
        public string Email { get; set; }
        [Required (ErrorMessage ="Digite o celular do contato")]
        [Phone(ErrorMessage ="O celular informado não é válido")]
        public string Celular { get; set; }
    }
}
