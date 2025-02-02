using System.Collections.Generic;
using System.Windows.Forms;
using Gerenciador_de_cadastros.Dominio.Entidade;
using GerenciadorDeCadastros.Data.Persistencia;
using GerenciadorDeCadastros.Data.Repositorio;
using GerenciadorDeCadastros.Dominio.Entidade;
using GerenciadorDeCadastros.Servico;
using GerenciadorDeCadastros.Servico.Interface;

namespace Gerenciador_de_cadastros.View
{
    public partial class FrmLogs : Form
    {
        private BindingSource bindingSource;
        private IControllerLog _controller;

        #region Construtor
        public FrmLogs()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            dataGridViewLogs.DataSource = bindingSource;
            _controller = new ControllerLog(new LogRepositorio(new DatabaseService()));
            CarregarDados();
        }
        #endregion

        #region Eventos privados
        /// <summary>
        /// Carrega listagem de registros no grid
        /// </summary>
        private void CarregarDados()
        {
            List<Log> logs = _controller.ListaLogs();
            foreach (Log log in logs)
            {
                if (!string.IsNullOrEmpty(log.Usuario))
                {
                    log.Usuario = CryptoService.Descriptografar(log.Usuario);
                }
            }
            bindingSource.DataSource = logs;
        }
        #endregion
    }
}
