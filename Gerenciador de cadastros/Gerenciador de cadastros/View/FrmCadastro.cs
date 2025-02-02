using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GerenciadorDeCadastros.Data.Persistencia;
using GerenciadorDeCadastros.Data.Repositorio;
using GerenciadorDeCadastros.Dominio.Entidade;
using GerenciadorDeCadastros.Servico;
using GerenciadorDeCadastros.Servico.Interface;

namespace Gerenciador_de_cadastros.View
{
    public partial class FrmCadastro : Form
    {
        private Pessoa _pessoa;
        ToolTip toolTip = new ToolTip();
        private IControllerPessoa _controller;

        public FrmCadastro(Pessoa pessoa)
        {
            InitializeComponent();
            _pessoa = pessoa;
            toolTip.SetToolTip(buttonExcluir, "Excluir cadastro");
        }

        public FrmCadastro(IControllerPessoa controller, Pessoa pessoa)
        {
            InitializeComponent();
            _controller = controller;
            _pessoa = pessoa;
            toolTip.SetToolTip(buttonExcluir, "Excluir cadastro");
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            if (_controller == null) {
                var databaseService = new DatabaseService();
                _controller = new ControllerPessoa(new PessoaRepositorio(databaseService));
                if (_pessoa == null)
                {
                    _pessoa = new Pessoa();
                } else {
                    CarregarDados();
                }
            } else {
                if (_pessoa == null) {
                    _pessoa = new Pessoa();
                } else {
                    CarregarDados();
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o usuário do sistema?", "Apagar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _controller.ExcluirPessoa(_pessoa.Id);
                this.Close();
            }
        }

        /// <summary>
        /// Método que remove caracteres não alfanuméricos de um texto
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        private string RemoverCaracteresNaoAlfanumericos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return texto;
            }

            string padrao = @"[^a-zA-Z0-9]";
            return Regex.Replace(texto, padrao, "");
        }

        /// <summary>
        /// Carrega os dados do objeto pessoa nos campos do formulário
        /// </summary>
        private void CarregarDados()
        {
            if (_pessoa != null)
            {
                labelId.Text = "ID: " + Convert.ToString(_pessoa.Id);
                labelId.Visible = true;
                buttonExcluir.Visible = true;
            }
            maskedTextBoxDescricao.Text = _pessoa.Descricao;
            maskedTextBoxDocumento.Text = _pessoa.Documento;
            maskedTextBoxLogin.Text = _pessoa.Login;
            maskedTextBoxSenha.Text = _pessoa.Senha;
            dateTimePickerDataNascimento.Text = Convert.ToString(_pessoa.DataNascimento);
            maskedTextBoxTelefone.Text = _pessoa.Telefone;
            maskedTextBoxEmail.Text = _pessoa.Email;
            maskedTextBoxEndereco.Text = _pessoa.Endereco;
        }

        private void LimitarCaracteres(MaskedTextBox maskedTextBox, int limite)
        {
            maskedTextBox.KeyPress += (sender, e) =>
            {
                if (maskedTextBox.Text.Length >= limite && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            };
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            _pessoa.Descricao = RemoverCaracteresNaoAlfanumericos(maskedTextBoxDescricao.Text);
            _pessoa.Documento = RemoverCaracteresNaoAlfanumericos(maskedTextBoxDocumento.Text);
            _pessoa.Login = RemoverCaracteresNaoAlfanumericos(maskedTextBoxLogin.Text);
            _pessoa.Senha = RemoverCaracteresNaoAlfanumericos(maskedTextBoxSenha.Text);
            _pessoa.DataNascimento = Convert.ToDateTime(dateTimePickerDataNascimento.Text);
            _pessoa.Telefone = RemoverCaracteresNaoAlfanumericos(maskedTextBoxTelefone.Text);
            _pessoa.Email = maskedTextBoxEmail.Text;
            _pessoa.Endereco = RemoverCaracteresNaoAlfanumericos(maskedTextBoxEndereco.Text);
            try
            {
                if (_pessoa.Id != 0)
                {
                    _controller.AtualizarPessoa(_pessoa);
                }
                else
                {
                    _controller.AdicionarPessoa(_pessoa);
                }

                this.Close();
            }
            catch (ArgumentException ex)
            {
                string mensagemErro = "Não foi possível realizar a operação:\n\n" + ex.Message;
                MessageBox.Show(mensagemErro, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a operação: " + ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskedTextBoxDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitarCaracteres(maskedTextBoxDescricao, 100);
        }

        private void maskedTextBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitarCaracteres(maskedTextBoxLogin, 50);

        }

        private void maskedTextBoxSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitarCaracteres(maskedTextBoxSenha, 255);
        }

        private void maskedTextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitarCaracteres(maskedTextBoxSenha, 100);
        }

        private void maskedTextBoxEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitarCaracteres(maskedTextBoxEndereco, 200);
        }
    }
}
