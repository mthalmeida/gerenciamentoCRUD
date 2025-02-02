using System.Collections.Generic;
using Gerenciador_de_cadastros.Dominio.Entidade;

namespace GerenciadorDeCadastros.Servico.Interface
{
    public interface IControllerLog
    {
        /// <summary>
        /// Método que adiciona log de uma rotina
        /// </summary>
        /// <param name="log"></param>
        void GeraLog(Log log);

        /// <summary>
        /// Método que lista todos os logs
        /// </summary>
        /// <param name="log"></param>
        List<Log> ListaLogs();
    }
}
