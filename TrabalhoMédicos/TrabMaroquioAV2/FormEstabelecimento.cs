using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrabMaroquioAV2
{
    public partial class FormEstabelecimento : Form
    {
        public FormEstabelecimento()
        {
            InitializeComponent();
            Controles.EfeitoCampoComFoco(txtEstabEmail);
            Controles.EfeitoCampoComFoco(txtEstabBairro);
            Controles.EfeitoCampoComFoco(txtEstabCidade);
            Controles.EfeitoCampoComFoco(txtEstabCNPJ);
            Controles.EfeitoCampoComFoco(txtEstabEnd);
            Controles.EfeitoCampoComFoco(txtEstabIE);
            Controles.EfeitoCampoComFoco(txtRazaoSoc);
            Controles.EfeitoCampoComFoco(cbbEstabUF);
        }

        private void btnCancelarEstab_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEstabelecimento_Load(object sender, EventArgs e)
        {

        }

        private void btnGravarEstab_Click(object sender, EventArgs e)
        {

            try
            {
                Unidade un = new Unidade();
                un.CNPJ = txtEstabCNPJ.Text;
                un.RazaoSoc = txtRazaoSoc.Text;
                un.InscricaoEst = txtEstabIE.Text;
                un.EnderecoTotal = txtEstabEnd.Text + " " + mtbCEP.Text + " " +
                    txtEstabBairro.Text + " " + txtEstabCidade.Text + " " +
                    cbbEstabUF.Text;
                un.Telefone = mskEstabTel.Text + " // " + mskEstabFax.Text;
                un.Email = txtEstabEmail.Text;
                Dados.TodUnidadesSaude.Add(un);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro Inválido");
            } 
        }
    }
}
