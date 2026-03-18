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
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // precisa chamar a tela de cadastrar alunos 
            frmCadastroAlunos cadastroAlunos = new frmCadastroAlunos();
            cadastroAlunos.TopLevel = false;
            cadastroAlunos.FormBorderStyle = FormBorderStyle.None;
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(cadastroAlunos);
            cadastroAlunos.Show();
        }
    }
}
