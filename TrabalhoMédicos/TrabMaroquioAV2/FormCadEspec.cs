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
    public partial class frmCadastroEspec : Form
    {
        public frmCadastroEspec()
        {
            InitializeComponent();
            Controles.EfeitoCampoComFoco(txtDescEspec);
            txtCodEspec.Text = (Dados.TodasEspecialidades.Count + 1).ToString();
        }

        private void btnGravarEspec_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidade espec = new Especialidade();
                espec.CodEsp = Convert.ToInt32(txtCodEspec.Text);
                espec.NomeEsp = txtNomenovaEspec.Text;
                espec.DescricaoEspec = txtDescEspec.Text;
                espec.MedVinculados = new List<Medico>();
                if (Dados.Pesquisar(espec.NomeEsp, Dados.TodasEspecialidades) != null)
                    throw new Exception("Já existe esssa especialidade!");
                else
                {
                    Dados.TodasEspecialidades.Add(espec);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro Inválido");
            } 

        }

        private void btnCancelarCadEspec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroEspec_Load(object sender, EventArgs e)
        {

        }


    }
}
