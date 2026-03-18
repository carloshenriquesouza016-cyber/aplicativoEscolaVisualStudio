using aplicativoEscola;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicativoEscolar.cs
{
    public partial class frmBuscarAlunos : Form
    {
        string nomeAluno;
        int idAluno;
        string dataNascimentoAluno;
        string nomeResponsavel;
        string dataNascimentoResponsavel;
        string telefoneResponsavel;
        string cpfResponsavel;
        public frmBuscarAlunos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntPesquisar_Click(object sender, EventArgs e)
        {
           
        }

        private void gridBusca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeAluno = gridBusca.CurrentRow.Cells[0].Value.ToString();
            idAluno = int.Parse(gridBusca.CurrentRow.Cells [7].Value.ToString());
            dataNascimentoAluno = gridBusca.CurrentRow.Cells [1].Value.ToString();
            nomeResponsavel = gridBusca.CurrentRow.Cells[2].Value.ToString();
            dataNascimentoResponsavel = gridBusca.CurrentRow.Cells[3].Value.ToString();
            telefoneResponsavel = gridBusca.CurrentRow.Cells[4].Value.ToString();
            cpfResponsavel = gridBusca.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aluno alunoSelecionado = new Aluno(nomeAluno, dataNascimentoAluno, nomeResponsavel, dataNascimentoResponsavel, telefoneResponsavel);
            alunoSelecionado._idAluno = idAluno;
            frmAlterarAlunos editarAluno = new frmAlterarAlunos(alunoSelecionado).
            editarAluno.ShowDialog();
            editarAluno.Focus();
            editarAluno.Dispose();
            ListarAlunos();
        }

        private void bntExcluirAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoSelecionado = new Aluno(nomeAluno, dataNascimentoAluno, nomeResponsavel, dataNascimentoResponsavel, telefoneResponsavel, cpfResponsavel);

        }