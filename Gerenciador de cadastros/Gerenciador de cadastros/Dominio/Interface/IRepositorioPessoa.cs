using System;
using System.Collections.Generic;
using GerenciadorDeCadastros.Dominio.Entidade;

namespace Gerenciador_de_cadastros.Dominio.Interface
{
    public interface IRepositorioPessoa
    {
        /// <summary>
        /// Método que adiciona uma pessoa
        /// </summary>
        /// <param name="pessoa"></param>
        void AdicionarPessoa(Pessoa pessoa);

        /// <summary>
        /// Método que atualiza uma pessoa
        /// </summary>
        /// <param name="pessoa"></param>
        void AtualizarPessoa(Pessoa pessoa);

        /// <summary>
        /// Método que exclui uma pessoa pelo id
        /// </summary>
        /// <param name="id"></param>
        void ExcluirPessoa(int id);

        /// <summary>
        /// Método que obtém uma pessoa pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Pessoa ObterPessoaPorId(int id);

        /// <summary>
        /// Método que lista todas as pessoas
        /// </summary>
        /// <returns></returns>
        List<Pessoa> ListarPessoas();

        /// <summary>
        /// Verifica permissão pra acessar o sistema
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Senha"></param>
        bool VerificarLogin(String Usuario, String Senha);
    }
}