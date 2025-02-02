using GerenciadorDeCadastros.Dominio.Entidade;
using GerenciadorDeCadastros.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gerenciador_de_cadastros.View
{
    public partial class FrmPrincipal : Form
    {
        private IControllerPessoa _controller;
        private BindingSource bindingSource;
        ToolTip toolTip = new ToolTip();

        #region Construtor
        public FrmPrincipal(IControllerPessoa controller)
        {
            InitializeComponent();
            _controller = controller;
            bindingSource = new BindingSource();
            dataGridViewPessoas.DataSource = bindingSource;
            AjustarTamanhoTela();
            ImplementaTooltipBotoes();
            CarregarDados();
            CarregaLabelRodape();
        }
        #endregion

        #region Eventos privados
        /// <summary>
        /// Cria o texto exibido no rodapé do sistema
        /// </summary>
        private void CarregaLabelRodape()
        {
            string dataHoraAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            string usuarioLogado = "Usuário: Admin";
            labelRodape.Text = dataHoraAtual + " | " + usuarioLogado;
        }

        /// <summary>
        /// Aplica tooltip aos botões
        /// </summary>
        private void ImplementaTooltipBotoes()
        {
            toolTip.SetToolTip(buttonAdicionar, "Adicionar uma nova pessoa");
            toolTip.SetToolTip(buttonAtualizar, "Atualizar lista de cadastros");
            toolTip.SetToolTip(buttonRelatorio, "Imprimir todos os registros");
            toolTip.SetToolTip(buttonSair, "Fechar o sistema");
        }

        /// <summary>
        /// Ajusta o tamanho do sistema conforme o tamanho da janela
        /// </summary>
        private void AjustarTamanhoTela()
        {
            this.WindowState = FormWindowState.Maximized;
            panelGrid.Width = this.ClientSize.Width - (2);
            panelGrid.Height = this.ClientSize.Height - panelSuperior.Height - (2);
        }

        /// <summary>
        /// Carrega listagem de registros no grid
        /// </summary>
        private void CarregarDados()
        {
            List<Pessoa> pessoas = _controller.ListarPessoas();
            bindingSource.DataSource = pessoas;

        }
        #endregion

        #region Eventos de formulário
        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dataGridViewPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = dataGridViewPessoas.Rows[e.RowIndex].Cells["Id"].Value;
                if (id != null)
                {
                    Pessoa pessoa = _controller.ObterPessoaPorId(Convert.ToInt32(id));
                    FrmCadastro frmCadastro = new FrmCadastro(pessoa);
                    frmCadastro.ShowDialog();
                    CarregarDados();
                }
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro(null);
            frmCadastro.ShowDialog();
            CarregarDados();
        }

        private void buttonRelatorio_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas = _controller.ListarPessoas();
            FrmRelatorioPessoas frmRelatorioPessoas = new FrmRelatorioPessoas(pessoas);
            frmRelatorioPessoas.ShowDialog();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja encerrar o sistema?", "Encerrar sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = maskedTextBoxPesquisar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(termoPesquisa))
            {
                CarregarDados();
            }
            else
            {
                List<Pessoa> pessoasFiltradas = _controller.ListarPessoas()
                    .Where(p => p.Descricao.ToLower().Contains(termoPesquisa))
                    .ToList();

                bindingSource.DataSource = pessoasFiltradas;
            }
        }
        #endregion
    }
}
