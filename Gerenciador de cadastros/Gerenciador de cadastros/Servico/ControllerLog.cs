using System.Collections.Generic;
using Gerenciador_de_cadastros.Dominio.Entidade;
using Gerenciador_de_cadastros.Dominio.Interface;
using GerenciadorDeCadastros.Servico.Interface;

namespace GerenciadorDeCadastros.Servico
{
    public class ControllerLog : IControllerLog
    {
        private readonly IRepositorioLog _repositorio;

        public ControllerLog(IRepositorioLog repositorio)
        {
            _repositorio = repositorio;
        }

        /// <summary>
        /// Método que adiciona log de uma rotina
        /// </summary>
        /// <param name="log"></param>
        public void GeraLog(Log log)
        {
            _repositorio.GeraLog(log);
        }

        /// <summary>
        /// Método que lista todos os logs
        /// </summary>
        /// <param name="log"></param>
        public List<Log> ListaLogs()
        {
            return _repositorio.ListaLogs();
        }
    }
}