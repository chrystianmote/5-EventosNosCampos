using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControleDeFrotas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            FormCadastroVeiculo form = new FormCadastroVeiculo();
            form.ShowDialog();
        }

        private void btnCadastrarAbastecimento_Click(object sender, EventArgs e)
        {
            FormCadastroAbastecimento form = new FormCadastroAbastecimento();
            form.ShowDialog();
        }

        private void btnListarVeiculo_Click(object sender, EventArgs e)
        {
            FormListaVeiculos form = new FormListaVeiculos();
            form.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }        
        }
    }
}
