using cadastroProfessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace aplicativoEscolar.cs
{
    public partial class frmPrincipal : Form
    {
        Conexao conexao = new Conexao();
        string sql;
        MySqlCommand comando;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrar telaCadastro = new frmCadastrar();
            telaCadastro.ShowDialog();
        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.abrirConexao();
                sql = "SELECT * FROM professor WHERE usuario = @usuario AND senha = @senha";
                comando = new MySqlCommand(sql, conexao.conexao);
                // responsável por ler os dados retornados do banco de dados
                MySqlDataReader reader;
                // reponsável por preencher os dados retornados do banco de dados em um DataTable ou DataSet
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = comando;
                comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@senha", txtSenha.Text);
                reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Usuário ou senha incorretos. Tente Novamente.");
                    SessaoSistema.idUsuario = reader["cpf"].ToString();
                    SessaoSistema.nomeUsuario = reader["nome"].ToString();
                    reader.Close();
                    conexao.fecharConexao();
                    this.Hide();
                    frmPrincipal menuPrincipal = new frmPrincipal();
                    menuPrincipal.ShowDialog();
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos. Tente novamente.");
                    conexao.fecharConexao();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login. Erro: " + ex.Message);
                conexao.fecharConexao();
            }
        }
    }
}
