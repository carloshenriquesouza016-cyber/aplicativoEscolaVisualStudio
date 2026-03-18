using AplicativoEscola;
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
    public partial class frmCadastrar : Form
    {
        public string nome;
        public string dataNascimento;
        public string telefone;
        public string cidade;
        public string estado;
        public string usuario;
        public string cpf;
        public string senha;

        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            dataNascimento = txtdataNascimento.Text;
            telefone = txtTelefone.Text;
            cidade = txtCidade.Text;
            estado = txtEstado.Text;
            cpf = txtCpf.Text;
            usuario = txtUsuario1.Text;
            senha = txtSenha1.Text;
            Professor professorObjeto = new Professor(nome, dataNascimento, estado, cidade, cpf, telefone, usuario, senha);
            professorObjeto.CadastrarProfessor();
            this.Close();

        }
    }
}
