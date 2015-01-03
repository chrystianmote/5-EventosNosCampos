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
    public partial class frmCadMedicos : Form
    {
   
        public frmCadMedicos()
        {
            InitializeComponent();
            foreach (Especialidade esp in Dados.TodasEspecialidades)
            {
                cbbEspecMed.Items.Add(esp.NomeEsp);
            }
            Controles.EfeitoCampoComFoco(txtNomeMed);
            Controles.EfeitoCampoComFoco(cbbEspecMed);
            Controles.EfeitoCampoNumerico(txtCRM);
                        
        }

        private void btnCancelarCadMed_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        //manipulador do clique do botão "Gravar"
        private void btnGravarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico();
                medico.CRM = Convert.ToInt32(txtCRM.Text);
                medico.NomeMed = txtNomeMed.Text;
                medico.Espec = Dados.Pesquisar(cbbEspecMed.Text, Dados.TodasEspecialidades);
                medico.Espec.MedVinculados.Add(medico);
                Dados.TodosMedicos.Add(medico);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro Inválido");
            }         

        }

        private void btnCancelarCadMed_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadMedicos_Load(object sender, EventArgs e)
        {

        }

        
    }
}
