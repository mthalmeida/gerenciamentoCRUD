using System;
using System.Windows.Forms;
using GerenciadorDeCadastros.Data.Persistencia;
using Gerenciador_de_cadastros.View;
using GerenciadorDeCadastros.Data.Repositorio;
using GerenciadorDeCadastros.Servico.Interface;
using GerenciadorDeCadastros.Servico;
using Gerenciador_de_cadastros.Dominio.Interface;

namespace Gerenciador_de_cadastros
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var databaseService = new DatabaseService();

            if (databaseService.TestarConexao())
            {
                IRepositorioPessoa repositorio = new PessoaRepositorio(databaseService);
                IControllerPessoa controller = new ControllerPessoa(repositorio);
                Application.Run(new FrmPrincipal(controller));
            }
            else
            {
                MessageBox.Show("❌ Falha na conexão com o banco de dados!\nVerifique a configuração.",
                                "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
