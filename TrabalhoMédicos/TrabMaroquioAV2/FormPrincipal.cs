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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            // Assim que o programa abre, ele Inicializa as listas de Doenças 
            // e de Especialidades para serem carregadas na lista, para vc 
            // testar seus DatagridView com eles.
            Dados.LoadingTudo();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dados.EscreverTudo();
                Close();
            }
        }

        private void cadastroDePacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPaciente form = new frmCadastroPaciente();
            form.ShowDialog();
        }

        private void cadastroDeEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEspec form = new frmCadastroEspec();
            form.ShowDialog();
        }

        private void tsbCadMed_Click(object sender, EventArgs e)
        {
            frmCadMedicos form = new frmCadMedicos();
            form.ShowDialog();
        }

        private void tsbCadPac_Click(object sender, EventArgs e)
        {
            frmCadastroPaciente form = new frmCadastroPaciente();
            form.ShowDialog();
        }

        private void tsbCadEspec_Click(object sender, EventArgs e)
        {
            frmCadastroEspec form = new frmCadastroEspec();
            form.ShowDialog();
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?", "Confirmação",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void tsbCadMed_MouseHover(object sender, EventArgs e)
        {
            tsbCadMed.Text = "Cadastrar Médico";
        }

        private void novaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsulta form = new FormConsulta();
            form.ShowDialog();
        }

        private void cadastroDeEstabelecimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstabelecimento form = new FormEstabelecimento();
            form.ShowDialog();
        }

        private void ListaDeMédicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListas form = new FormListas();
            form.ShowDialog();
        }

        private void mnsCadastroDeMedico_Click(object sender, EventArgs e)
        {
            frmCadMedicos form = new frmCadMedicos();
            form.ShowDialog();
        }

        private void cadastroDeMédicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListas frmListas = new FormListas();
            frmListas.ShowDialog();
        }

        private void cadastroDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListas frmListas = new FormListas();
            frmListas.ShowDialog();
        }

        private void cadastroDeEspecialidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListas frmListas = new FormListas();
            frmListas.ShowDialog();
        }

        private void cadastroDeEstabelecimentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListas frmListas = new FormListas();
            frmListas.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListas frmListas = new FormListas();
            frmListas.ShowDialog();
        }

        private void doençasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListas frmListas = new FormListas();
            frmListas.ShowDialog();
        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:20000/Default.aspx");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
