using System;

namespace GerenciadorDeCadastros.Dominio.Entidade
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Documento { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
