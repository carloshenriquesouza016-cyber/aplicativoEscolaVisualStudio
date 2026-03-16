using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cadastroProfessor
{
    public class Conexao
    {
        // 4 informações para a conexão
        // server, database, user, password
        string server = "localhost";
        string database = "cadastroProfessor";
        string user = "root";
        string password = "";
        public MySqlConnection conexao;

        public void abrirConexao()
        {

            // string de conexão
            string caminhoConexao = $"server={server};database={database};user={user};password={password}";
            conexao = new MySqlConnection(caminhoConexao);


            try
            {

                conexao.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a conexão: " + ex.Message);
            }
        }

        public void fecharConexao()
        {

            // string de conexão
            string caminhoConexao = $"server={server};database={database};user={user};password={password}";
            conexao = new MySqlConnection(caminhoConexao);

            try
            {

                conexao.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar a conexão: " + ex.Message);
            }
        }
    }
}

