using FirebirdSql.Data.FirebirdClient;
using GerenciadorDeCadastros.Data.Persistencia;
using Gerenciador_de_cadastros.Dominio.Interface;
using Gerenciador_de_cadastros.Dominio.Entidade;
using System;
using GerenciadorDeCadastros.Dominio.Entidade;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;

namespace GerenciadorDeCadastros.Data.Repositorio
{
    public class LogRepositorio : IRepositorioLog
    {
        private readonly DatabaseService _databaseService;

        public LogRepositorio(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        /// <summary>
        /// Método que adiciona log de uma rotina
        /// </summary>
        /// <param name="log"></param>
        public void GeraLog(Log log)
        {
            using (var connection = new FbConnection(_databaseService.ConnectionString))
            {
                connection.Open();
                using (var cmd = new FbCommand("INSERT INTO LOGS ( " +
                                                " LOG_USUARIO, LOG_DATA_HORA, LOG_ROTINA, LOG_DESCRICAO" +
                                                ") VALUES (" +
                                                "@paramUsuario, @paramDataHora, @paramRotina, @paramDescricao" +
                                                ")", connection))
                {
                    cmd.Parameters.AddWithValue("@paramUsuario", log.Usuario);
                    cmd.Parameters.AddWithValue("@paramDataHora", DateTime.Now);
                    cmd.Parameters.AddWithValue("@paramRotina", log.Rotina);
                    cmd.Parameters.AddWithValue("@paramDescricao", (object)log.Descricao ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Método que lista todos os logs
        /// </summary>
        /// <param name="log"></param>
        public List<Log> ListaLogs()
        {
            List<Log> logs = new List<Log>();
            using (var connection = new FbConnection(_databaseService.ConnectionString))
            {
                connection.Open();
                using (var cmd = new FbCommand("SELECT * FROM LOGS", connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        logs.Add(new Log
                        {
                            Id = reader.GetInt32(0),
                            Usuario = reader.GetString(1),
                            dataHoraAtual = reader.GetDateTime(2),
                            Rotina = reader.GetString(3),
                            Descricao = reader.GetString(4),
                        });
                    }

                }
            }
            return logs;
        }
    }
}
