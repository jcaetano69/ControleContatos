namespace ControleContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; } //vai representar o código do contato, vai ser enumerado.
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
    }
}
