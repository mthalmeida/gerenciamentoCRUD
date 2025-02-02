using System;

namespace Gerenciador_de_cadastros.Dominio.Entidade
{
    public class Log
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public DateTime dataHoraAtual { get; set; }
        public string Rotina { get; set; }
        public string Descricao { get; set; }
    }
}
