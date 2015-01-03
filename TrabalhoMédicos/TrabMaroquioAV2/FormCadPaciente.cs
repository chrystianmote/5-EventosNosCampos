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
    public partial class frmCadastroPaciente : Form
    {
        public frmCadastroPaciente()
        {
            InitializeComponent();
            Controles.EfeitoCampoComFoco(txtBairroPac);
            Controles.EfeitoCampoComFoco(txtCidadePac);
            Controles.EfeitoCampoComFoco(txtEmailPac);
            Controles.EfeitoCampoComFoco(txtEndPac);
            Controles.EfeitoCampoComFoco(txtNomePac);
            Controles.EfeitoCampoComFoco(mtbCEPpac);
            Controles.EfeitoCampoComFoco(mtbTel1pac);
            Controles.EfeitoCampoComFoco(mtbTel2pac);
        }

        private void btnCancelarCadPac_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void frmCadastroPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnGravarPac_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente pac = new Paciente();
                pac.CPF =Convert.ToInt64(mtbCPFpac.Text);
                pac.Endereco = txtEndPac.Text+" "+mtbCEPpac.Text+" "+
                    txtBairroPac.Text+" "+txtCidadePac.Text+" "+cbbUFpac.Text;
                pac.NomePac = txtNomePac.Text;
                pac.Telefone = mtbTel1pac.Text + " // " + mtbTel2pac.Text;
                pac.Email = txtEmailPac.Text;
                Dados.TodosPacientes.Add(pac);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro Inválido");
            } 
            
        }
    }
}
