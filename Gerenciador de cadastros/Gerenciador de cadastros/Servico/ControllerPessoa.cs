using Gerenciador_de_cadastros.Dominio.Interface;
using GerenciadorDeCadastros.Dominio.Entidade;
using GerenciadorDeCadastros.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GerenciadorDeCadastros.Servico
{
    public class ControllerPessoa : IControllerPessoa
    {
        private readonly IRepositorioPessoa _repositorio;

        public ControllerPessoa(IRepositorioPessoa repositorio)
        {
            _repositorio = repositorio;
        }

        /// <summary>
        /// Método que valida um email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private static bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            email = email.Trim();

            string regexEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, regexEmail);
        }

        /// <summary>
        /// Método que valida uma pessoa ao cadastrar ou atualizar
        /// </summary>
        /// <param name="pessoa"></param>
        /// <returns></returns>
        private List<string> ValidarPessoa(Pessoa pessoa)
        {
            var erros = new List<string>();

            if (string.IsNullOrEmpty(pessoa.Descricao))
            {
                erros.Add("O nome é obrigatório.");
            }

            if (string.IsNullOrEmpty(pessoa.Documento))
            {
                erros.Add("O documento é obrigatório.");
            }

            if (string.IsNullOrEmpty(pessoa.Login))
            {
                erros.Add("O login é obrigatório.");
            }

            if (string.IsNullOrEmpty(pessoa.Senha))
            {
                erros.Add("A senha é obrigatória.");
            }

            if (pessoa.DataNascimento == null)
            {
                erros.Add("A data de nascimento é obrigatória.");
            }

            if (!string.IsNullOrEmpty(pessoa.Email))
            {
                if (!ValidarEmail(pessoa.Email))
                {
                    erros.Add("O email é inválido.");
                }
            }
            
            return erros;
        }

        /// <summary>
        /// Método que adiciona uma pessoa
        /// </summary>
        /// <param name="pessoa"></param>
        /// <exception cref="ArgumentException"></exception>
        public void AdicionarPessoa(Pessoa pessoa)
        {
            var erros = ValidarPessoa(pessoa);
            if (erros.Any())
            {
                throw new ArgumentException(string.Join(Environment.NewLine, erros));
            }

            _repositorio.AdicionarPessoa(pessoa);
        }

        /// <summary>
        /// Método que atualiza uma pessoa
        /// </summary>
        /// <param name="pessoa"></param>
        /// <exception cref="ArgumentException"></exception>
        public void AtualizarPessoa(Pessoa pessoa)
        {
            var erros = ValidarPessoa(pessoa);
            if (erros.Any())
            {
                throw new ArgumentException(string.Join(Environment.NewLine, erros));
            }
            _repositorio.AtualizarPessoa(pessoa);
        }

        /// <summary>
        /// Método que exclui uma pessoa pelo id
        /// </summary>
        /// <param name="id"></param>
        public void ExcluirPessoa(int id)
        {
            _repositorio.ExcluirPessoa(id);
        }

        /// <summary>
        /// Método que obtém uma pessoa pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Pessoa ObterPessoaPorId(int id)
        {
            return _repositorio.ObterPessoaPorId(id);
        }

        /// <summary>
        /// Método que lista todas as pessoas cadastradas
        /// </summary>
        /// <returns></returns>
        public List<Pessoa> ListarPessoas()
        {
            return _repositorio.ListarPessoas();
        }

        /// <summary>
        /// Verifica permissão pra acessar o sistema
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public List<string> VerificarLoginValido(string usuario, string senha)
        {
            var erros = new List<string>();

            if (string.IsNullOrEmpty(usuario))
            {
                erros.Add("O usuário é obrigatório.");
            }

            if (string.IsNullOrEmpty(senha))
            {
                erros.Add("A senha é obrigatória.");

            }

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(senha))
            {
                bool pessoa = _repositorio.VerificarLogin(usuario, senha);
                if (!pessoa)
                {
                    erros.Add("Usuário ou senha inválidos.");
                }
            }         

            return erros;
        }

        /// <summary>
        /// Método que verifica se o login é válido
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Senha"></param>
        /// <exception cref="ArgumentException"></exception>
        public bool VerificarLogin(String Usuario, String Senha)
        {
            var erros = VerificarLoginValido(Usuario, Senha);
            if (erros.Any())
            {
                throw new ArgumentException(string.Join(Environment.NewLine, erros));
            }
            return true;
        }
    }
}