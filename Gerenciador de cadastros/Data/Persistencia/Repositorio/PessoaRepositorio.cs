using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using GerenciadorDeCadastros.Data.Persistencia;
using GerenciadorDeCadastros.Dominio.Entidade;
using Gerenciador_de_cadastros.Dominio.Interface;

namespace GerenciadorDeCadastros.Data.Repositorio
{
    public class PessoaRepositorio : IRepositorioPessoa
    {
        private readonly DatabaseService _databaseService;

        public PessoaRepositorio(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        /// <summary>
        /// Adiciona um novo registro
        /// </summary>
        /// <param name="pessoa"></param>
        public void AdicionarPessoa(Pessoa pessoa)
        {
            using (var connection = new FbConnection(_databaseService.ConnectionString))
            {
                connection.Open();
                using (var cmd = new FbCommand("INSERT INTO PESSOA ( " +
                                                      " PE_DS, " +
                                                      " PE_DOCUMENTO, " +
                                                      " PE_LOGIN, PE_SENHA, " +
                                                      " PE_DT_NASCIMENTO, " +
                                                      " PE_TELEFONE, PE_EMAIL, " +
                                                      " PE_ENDERECO" +
                                               ") VALUES (" +
                                                      "@paramDescricao, " +
                                                      "@paramDocumento, " +
                                                      "@paramLogin, " +
                                                      "@paramSenha, " +
                                                      "@paramDataNascimento, " +
                                                      "@paramTelefone, " +
                                                      "@paramEmail, " +
                                                      "@paramEndereco" +
                                               ")", connection))
                {
                    cmd.Parameters.AddWithValue("@paramDescricao", pessoa.Descricao);
                    cmd.Parameters.AddWithValue("@paramDocumento", pessoa.Documento);
                    cmd.Parameters.AddWithValue("@paramLogin", pessoa.Login);
                    cmd.Parameters.AddWithValue("@paramSenha", pessoa.Senha);
                    cmd.Parameters.AddWithValue("@paramDataNascimento", (object)pessoa.DataNascimento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@paramTelefone", (object)pessoa.Telefone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@paramEmail", (object)pessoa.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@paramEndereco", (object)pessoa.Endereco ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Lista todas as pessoas cadastradas
        /// </summary>
        /// <returns></returns>
        public List<Pessoa> ListarPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            using (var connection = new FbConnection(_databaseService.ConnectionString))
            {
                connection.Open();
                using (var cmd = new FbCommand("SELECT * FROM PESSOA", connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pessoas.Add(new Pessoa
                        {
                            Id = reader.GetInt32(0),
                            Descricao = reader.GetString(1),
                            Documento = reader.GetString(2),
                            Login = reader.GetString(3),
                            Senha = reader.GetString(4),
                            DataNascimento = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
                            Telefone = reader.IsDBNull(6) ? null : reader.GetString(6),
                            Email = reader.IsDBNull(7) ? null : reader.GetString(7),
                            Endereco = reader.IsDBNull(8) ? null : reader.GetString(8)
                        });
                    }
                }
            }
            return pessoas;
        }

        /// <summary>
        /// Obtem uma pessoa pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Pessoa ObterPessoaPorId(int id)
        {
            Pessoa pessoa = null;
            using (var connection = new FbConnection(_databaseService.ConnectionString))
            {
                connection.Open();
                using (var cmd = new FbCommand("SELECT * FROM PESSOA WHERE PE_CD = @id", connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pessoa = new Pessoa
                            {
                                Id = reader.GetInt32(0),
                                Descricao = reader.GetString(1),
                                Documento = reader.GetString(2),
                                Login = reader.GetString(3),
                                Senha = reader.GetString(4),
                                DataNascimento = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
                                Telefone = reader.IsDBNull(6) ? null : reader.GetString(6),
                                Email = reader.IsDBNull(7) ? null : reader.GetString(7),
                                Endereco = reader.IsDBNull(8) ? null : reader.GetString(8)
                            };
                        }
                    }
                }
            }
            return pessoa;
        }

        /// <summary>
        /// Atualiza uma pessoa no banco de dados
        /// </summary>
        /// <param name="pessoa"></param>
        public void AtualizarPessoa(Pessoa pessoa)
        {
            using (var connection = new FbConnection(_databaseService.ConnectionString))
            {
                connection.Open();
                using (var cmd = new FbCommand("UPDATE PESSOA SET " +
                                               "     PE_DS = @paramDescricao, " +
                                               "     PE_DOCUMENTO = @paramDocumento, " +
                                               "     PE_LOGIN = @paramLogin, " +
                                               "     PE_SENHA = @paramSenha, " +
                                               "     PE_DT_NASCIMENTO = @paramDataNascimento, " +
                                               "     PE_TELEFONE = @paramTelefone, " +
                                               "     PE_EMAIL = @paramEmail, " +
                                               "     PE_ENDERECO = @paramEndereco " +
                                               " WHERE PE_CD = @paramId", connection))
                {
                    cmd.Parameters.AddWithValue("@paramDescricao", pessoa.Descricao);
                    cmd.Parameters.AddWithValue("@paramDocumento", pessoa.Documento);
                    cmd.Parameters.AddWithValue("@paramLogin", pessoa.Login);
                    cmd.Parameters.AddWithValue("@paramSenha", pessoa.Senha);
                    cmd.Parameters.AddWithValue("@paramDataNascimento", (object)pessoa.DataNascimento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@paramTelefone", (object)pessoa.Telefone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@paramEmail", (object)pessoa.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@paramEndereco", (object)pessoa.Endereco ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@paramId", pessoa.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Exclui uma pessoa do banco de dados
        /// </summary>
        /// <param name="id"></param>
        public void ExcluirPessoa(int id)
        {
            using (var connection = new FbConnection(_databaseService.ConnectionString))
            {
                connection.Open();
                using (var cmd = new FbCommand("DELETE FROM PESSOA WHERE PE_CD = @paramId", connection))
                {
                    cmd.Parameters.AddWithValue("@paramId", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
