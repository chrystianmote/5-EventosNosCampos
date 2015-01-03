using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsStart
{
    public partial class FormCadastro : Form
    {
        private Pessoa PessoaObj { get; set; }

        public FormCadastro(Pessoa pessoa)
        {
            InitializeComponent();
            PessoaObj = pessoa;

            if (pessoa.Codigo != 0)
            {
                txtCodigo.Text = PessoaObj.Codigo.ToString();
                txtNome.Text = PessoaObj.Nome;
                dtpData.Value = PessoaObj.Data;
                cbxAtivo.Checked = PessoaObj.Ativo;
            }
        }
    }
}
