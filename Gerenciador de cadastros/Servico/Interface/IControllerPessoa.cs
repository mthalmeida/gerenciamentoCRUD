using System.Collections.Generic;
using GerenciadorDeCadastros.Dominio.Entidade;

namespace GerenciadorDeCadastros.Servico.Interface
{
    public interface IControllerPessoa
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
        Pessoa ObterPessoaPorId(int id);

        /// <summary>
        /// Método que lista todas as pessoas
        /// </summary>
        /// <returns></returns>
        List<Pessoa> ListarPessoas();
    }
}