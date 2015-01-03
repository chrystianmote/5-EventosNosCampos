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
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
            Controles.EfeitoCampoComFoco(cbbCadConsPaciente);
            Controles.EfeitoCampoMonetario(txtCadConsValor);
        }

        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            foreach (Paciente pa in Dados.TodosPacientes)
                cbbCadConsPaciente.Items.Add(pa.NomePac);
            foreach (Medico m in Dados.TodosMedicos)
                cbbCadConsMedico.Items.Add(m.NomeMed);
            foreach (Doenca d in Dados.TodasDoencas)
                cbbDoencasCID.Items.Add(d.Codigo + "-" + d.Nome);
            foreach (Unidade u in Dados.TodUnidadesSaude)
                cbbCadConsLocal.Items.Add(u.RazaoSoc);
        }

        private void btnGravarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta c = new Consulta();
                c.Medico = Dados.Pesquisar(cbbCadConsMedico.Text, Dados.TodosMedicos);
                c.Paciente = Dados.Pesquisar(cbbCadConsPaciente.Text, Dados.TodosPacientes);
                c.Medico.Consultas.Add(c);
                c.Paciente.Consultas.Add(c);
                string[] dç = cbbDoencasCID.Text.Split('-');
                c.Consultorio = Dados.Pesquisar(cbbCadConsLocal.Text, Dados.TodUnidadesSaude);
                c.Doenca = Dados.Pesquisar(dç[0], Dados.TodasDoencas);
                c.HoraConsulta = dtpDataConsulta.Value;
                c.ValorConsulta = Convert.ToDecimal(txtCadConsValor.Text);
                c.Descricao = txtDescricao.Text;
                Dados.TodasConsultas.Add(c);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro na inserção da consulta ");
            }
        }
    }
}
