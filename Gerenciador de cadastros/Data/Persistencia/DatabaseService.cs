using System.Configuration;
using FirebirdSql.Data.FirebirdClient;

namespace GerenciadorDeCadastros.Data.Persistencia
{
    public class DatabaseService
    {
        public string ConnectionString { get; }

        /// <summary>
        /// Construtor
        /// </summary>
        public DatabaseService()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["FirebirdConnection"].ConnectionString;
        }

        /// <summary>
        /// Testa a conexão com o banco de dados
        /// </summary>
        /// <returns></returns>
        public bool TestarConexao()
        {
            try
            {
                using (var conexao = new FbConnection(ConnectionString))
                {
                    conexao.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
