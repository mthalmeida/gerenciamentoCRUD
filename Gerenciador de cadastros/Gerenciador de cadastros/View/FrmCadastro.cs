﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Gerenciador_de_cadastros.Dominio.Entidade;
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
        private IControllerLog _controllerLog;

        #region Construtor
        public FrmCadastro(Pessoa pessoa)
        {
            InitializeComponent();
            _pessoa = pessoa;
            _controllerLog = new ControllerLog(new LogRepositorio(new DatabaseService()));
            toolTip.SetToolTip(buttonExcluir, "Excluir cadastro");
            toolTip.SetToolTip(buttonDuplicar, "Duplicar cadastro");
        }

        public FrmCadastro(IControllerPessoa controller, Pessoa pessoa)
        {
            InitializeComponent();
            _controller = controller;
            _pessoa = pessoa;
            toolTip.SetToolTip(buttonExcluir, "Excluir cadastro");
            toolTip.SetToolTip(buttonDuplicar, "Duplicar cadastro");

        }
        #endregion

        #region Eventos privados
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
                buttonDuplicar.Visible = true;
            }
            maskedTextBoxDescricao.Text = _pessoa.Descricao;
            maskedTextBoxDocumento.Text = _pessoa.Documento;
            maskedTextBoxLogin.Text = CryptoService.Descriptografar(_pessoa.Login);
            maskedTextBoxSenha.Text = CryptoService.Descriptografar(_pessoa.Senha);
            dateTimePickerDataNascimento.Text = Convert.ToString(_pessoa.DataNascimento);
            maskedTextBoxTelefone.Text = _pessoa.Telefone;
            maskedTextBoxEmail.Text = _pessoa.Email;
            maskedTextBoxEndereco.Text = _pessoa.Endereco;
        }

        /// <summary>
        /// Método que limita a quantidade de caracteres em um MaskedTextBox
        /// </summary>
        /// <param name="maskedTextBox"></param>
        /// <param name="limite"></param>
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
        #endregion

        #region Eventos do formulário
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            _pessoa.Descricao = maskedTextBoxDescricao.Text;
            _pessoa.Documento = RemoverCaracteresNaoAlfanumericos(maskedTextBoxDocumento.Text);
            _pessoa.Login = CryptoService.Criptografar(RemoverCaracteresNaoAlfanumericos(maskedTextBoxLogin.Text));
            _pessoa.Senha = CryptoService.Criptografar(RemoverCaracteresNaoAlfanumericos(maskedTextBoxSenha.Text));
            _pessoa.DataNascimento = Convert.ToDateTime(dateTimePickerDataNascimento.Text);
            _pessoa.Telefone = RemoverCaracteresNaoAlfanumericos(maskedTextBoxTelefone.Text);
            _pessoa.Email = maskedTextBoxEmail.Text;
            _pessoa.Endereco = maskedTextBoxEndereco.Text;
            try
            {
                if (_pessoa.Id != 0)
                {
                    _controller.AtualizarPessoa(_pessoa);
                    _controllerLog.GeraLog(new Log { Usuario = UsuarioLogado.Usuario, Rotina = "Cadastro", Descricao = "Usuário atualizado" });
                }
                else
                {
                    _controllerLog.GeraLog(new Log { Usuario = UsuarioLogado.Usuario, Rotina = "Cadastro", Descricao = "Novo usuário adicionado" });
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

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            if (_controller == null)
            {
                var databaseService = new DatabaseService();
                _controller = new ControllerPessoa(new PessoaRepositorio(databaseService));
                if (_pessoa == null)
                {
                    _pessoa = new Pessoa();
                }
                else
                {
                    CarregarDados();
                }
            }
            else
            {
                if (_pessoa == null)
                {
                    _pessoa = new Pessoa();
                }
                else
                {
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
                try
                {
                    _controller.ExcluirPessoa(_pessoa.Id);
                    _controllerLog.GeraLog(new Log { Usuario = UsuarioLogado.Usuario, Rotina = "Cadastro", Descricao = "Usuario deletado" });
                    this.Close();
                }
                catch (Exception)
                {
                    throw;
                }
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

        private void buttonVisualizarOcularSenha_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxSenha.UseSystemPasswordChar)
            {
                maskedTextBoxSenha.UseSystemPasswordChar = false;
            }
            else
            {
                maskedTextBoxSenha.UseSystemPasswordChar = true;
            }
        }
        private void buttonDuplicar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa novaPessoa = new Pessoa
                {
                    Descricao = _pessoa.Descricao,
                    Documento = _pessoa.Documento,
                    Login = _pessoa.Login,
                    Senha = _pessoa.Senha,
                    DataNascimento = _pessoa.DataNascimento,
                    Telefone = _pessoa.Telefone,
                    Email = _pessoa.Email,
                    Endereco = _pessoa.Endereco
                };

                _controller.AdicionarPessoa(novaPessoa);
                _controllerLog.GeraLog(new Log {Usuario = UsuarioLogado.Usuario, Rotina = "Cadastro", Descricao = "Usuário duplicado"});
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível duplicar o usuário: " + ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
