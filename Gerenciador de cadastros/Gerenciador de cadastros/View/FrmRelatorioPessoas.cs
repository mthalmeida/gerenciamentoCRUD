using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GerenciadorDeCadastros.Dominio.Entidade;

namespace Gerenciador_de_cadastros.View
{
    public partial class FrmRelatorioPessoas : Form
    {
        private List<Pessoa> _pessoas;

        #region Construtor
        public FrmRelatorioPessoas(List<Pessoa> pessoas)
        {
            InitializeComponent();
            _pessoas = pessoas;
        }
        #endregion

        #region Eventos do relatório
        private void FrmRelatorioPessoas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetePessoas", _pessoas));
            this.reportViewer1.RefreshReport();
        }
        #endregion
    }
}
