using cadastroProfessor;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicativoEscola

{
    public class Aluno
    {
        public string nomeAluno { get; set; }
        public string dataNascimentoAluno { get; set; }
        public string nomeResponsalvel { get; set; }
        public string dataNascimentoResponsalvel { get; set; }
        public string turmas { get; set; }
        public int _idAluno { get; private set; }
        public string _telefoneResponsavel { get; private set; }
        public string _cpfResponsavel { get; private set; }

        public Aluno(string nomeAlunofrm, string dataNascimentoAlunofrm, string nomeResponsavelfrm, string dataNascimentoResponsalvelfrm, string _telefoneResponsavelfrm, string _cpfResponsavelfrm)
        {

            nomeAluno = nomeAlunofrm;
            dataNascimentoAluno = dataNascimentoAlunofrm;
            nomeResponsalvel = nomeResponsavelfrm;
            dataNascimentoResponsalvel = dataNascimentoResponsalvelfrm;
            _telefoneResponsavel = _telefoneResponsavelfrm;
            _cpfResponsavel = _cpfResponsavelfrm;
        }
        public void CadastrarAluno()
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "INSERT INTO aluno (nomeAluno, dataNascimentoAluno, nomeResponsavel, dataNascimentoResponsavel, telefoneResponsavel, cpfResponsavel ) VALUES (@nomeAluno, @dataNascimentoAluno, @nomeResponsavel, @dataNascimentoResponsavel, @telefoneResponsavel, @cpfResponsavel)";
                conexao.abrirConexao();
                MySqlCommand comando = new MySqlCommand(sql, conexao.conexao);
                comando = new MySqlCommand(sql, conexao.conexao);
                comando.Parameters.AddWithValue("@nomeAluno", nomeAluno);
                comando.Parameters.AddWithValue("@dataNascimentoAluno", dataNascimentoAluno);
                comando.Parameters.AddWithValue("@nomeResponsavel", nomeResponsalvel);
                comando.Parameters.AddWithValue("@dataNascimentResponsavel", dataNascimentoResponsalvel);
                comando.Parameters.AddWithValue("@telefoneResponsavel", _telefoneResponsavel);
                comando.Parameters.AddWithValue("@cpfResponsavel", _cpfResponsavel);
                //comando.Parameters.AddWithValue("@turmas", turmas);
                comando.ExecuteNonQuery();
                MessageBox.Show("Aluno Cadastrado com Sucesso!");
                conexao.fecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar Aluno. Erro: " + ex.Message);
            }
        }
    }
}




