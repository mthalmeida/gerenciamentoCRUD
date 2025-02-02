using System;
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
    public partial class FrmRelatorioPessoas : Form
    {
        private List<Pessoa> _pessoas;
        private IControllerLog _controllerLog;

        #region Construtor
        public FrmRelatorioPessoas(List<Pessoa> pessoas)
        {
            InitializeComponent();
            _pessoas = pessoas;
            _controllerLog = new ControllerLog(new LogRepositorio(new DatabaseService()));

        }
        #endregion

        #region Eventos do relatório
        private void FrmRelatorioPessoas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetePessoas", _pessoas));
            this.reportViewer1.RefreshReport();
            _controllerLog.GeraLog(new Log { Usuario = UsuarioLogado.Usuario, Rotina = "Relatório", Descricao = "Relatório gerado para visualização" });
        }
        #endregion
    }
}
