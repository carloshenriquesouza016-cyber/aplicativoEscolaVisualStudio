namespace aplicativoEscolar.cs
{
    partial class frmBuscarAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridBusca = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bntPesquisar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditarAlunos = new System.Windows.Forms.Button();
            this.bntExcluirAluno = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBusca
            // 
            this.gridBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBusca.Location = new System.Drawing.Point(12, 81);
            this.gridBusca.Name = "gridBusca";
            this.gridBusca.Size = new System.Drawing.Size(604, 265);
            this.gridBusca.TabIndex = 0;
            this.gridBusca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBusca_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 1;
            // 
            // bntPesquisar
            // 
            this.bntPesquisar.Location = new System.Drawing.Point(383, 55);
            this.bntPesquisar.Name = "bntPesquisar";
            this.bntPesquisar.Size = new System.Drawing.Size(69, 23);
            this.bntPesquisar.TabIndex = 2;
            this.bntPesquisar.Text = "Pesquisar";
            this.bntPesquisar.UseVisualStyleBackColor = true;
            this.bntPesquisar.Click += new System.EventHandler(this.bntPesquisar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(12, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Buscar:";
            // 
            // btnEditarAlunos
            // 
            this.btnEditarAlunos.Location = new System.Drawing.Point(484, 55);
            this.btnEditarAlunos.Name = "btnEditarAlunos";
            this.btnEditarAlunos.Size = new System.Drawing.Size(61, 23);
            this.btnEditarAlunos.TabIndex = 19;
            this.btnEditarAlunos.Text = "Editar";
            this.btnEditarAlunos.UseVisualStyleBackColor = true;
            this.btnEditarAlunos.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntExcluirAluno
            // 
            this.bntExcluirAluno.Location = new System.Drawing.Point(551, 55);
            this.bntExcluirAluno.Name = "bntExcluirAluno";
            this.bntExcluirAluno.Size = new System.Drawing.Size(61, 23);
            this.bntExcluirAluno.TabIndex = 20;
            this.bntExcluirAluno.Text = "Excluir";
            this.bntExcluirAluno.UseVisualStyleBackColor = true;
            this.bntExcluirAluno.Click += new System.EventHandler(this.bntExcluirAluno_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(274, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "Tipo  de Busca";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmBuscarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::aplicativoEscolar.cs.Properties.Resources.cadastro;
            this.ClientSize = new System.Drawing.Size(628, 358);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bntExcluirAluno);
            this.Controls.Add(this.btnEditarAlunos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bntPesquisar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridBusca);
            this.Name = "frmBuscarAlunos";
            this.Text = "Buscar Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.gridBusca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBusca;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bntPesquisar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditarAlunos;
        private System.Windows.Forms.Button bntExcluirAluno;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}