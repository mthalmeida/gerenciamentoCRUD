using System;
using System.Windows.Forms;
using Gerenciador_de_cadastros.Dominio.Entidade;
using GerenciadorDeCadastros.Data.Persistencia;
using GerenciadorDeCadastros.Data.Repositorio;
using GerenciadorDeCadastros.Dominio.Entidade;
using GerenciadorDeCadastros.Servico;
using GerenciadorDeCadastros.Servico.Interface;

namespace Gerenciador_de_cadastros.View
{
    public partial class FrmLogin : Form
    {
        DatabaseService db = new DatabaseService();
        private IControllerPessoa _controller;
        private IControllerLog _controllerLog;

        #region Construtor
        public FrmLogin(IControllerPessoa controller)
        {
            InitializeComponent();
            _controller = controller;
            _controllerLog = new ControllerLog(new LogRepositorio(new DatabaseService()));

        }
        #endregion

        #region Eventos do formulário
        /// <summary>
        /// Verifica permissão pra acessar o sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                String Usuario = maskedTextBoxUsuario.Text;
                String Senha = maskedTextBoxSenha.Text;
                _controller.VerificarLogin(Usuario, Senha);

                UsuarioLogado.Usuario = Usuario;
                _controllerLog.GeraLog(new Log { Usuario = Usuario, Rotina = "Login", Descricao = "Usuário logado com sucesso"});

                this.Hide();
                FrmPrincipal frmPrincipal = new FrmPrincipal(_controller);
                frmPrincipal.Show();
            }
            catch (ArgumentException ex)
            {
                string mensagemErro = "Não foi possível realizar a operação:\n\n" + ex.Message;
                MessageBox.Show(mensagemErro, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
