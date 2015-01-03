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
    public partial class FormListas : Form
    {
        public FormListas()
        {
            InitializeComponent();

            foreach (Medico m in Dados.TodosMedicos)
            {
                string[] dados = new string[4];
                dados[0] = m.CRM.ToString();
                dados[1] = m.NomeMed;
                dados[2] = m.Espec.NomeEsp;
                dados[3] = m.Renda.ToString();
                dgvListaMedico.Rows.Add(dados);
            }
            foreach (Paciente p in Dados.TodosPacientes)
            {
                string[] dados = new string[3];
                dados[0] = p.CPF.ToString();
                dados[1] = p.NomePac;
                dados[2] = p.Telefone;
                dgvListaPaciente.Rows.Add(dados);
            }
            foreach (Unidade u in Dados.TodUnidadesSaude)
            {
                string[] dados = new string[3];
                dados[0] = u.CNPJ;
                dados[1] = u.RazaoSoc;
                dados[2] = u.Telefone;
                dgvListaEstab.Rows.Add(dados);        
            }
            foreach (Consulta c in Dados.TodasConsultas)
            {
                string[] dados = new string[3];
                dados[0] = c.Medico.NomeMed;
                dados[1] = c.Paciente.NomePac;
                dados[2] = c.HoraConsulta.ToShortDateString();
                dgvListaConsulta.Rows.Add(dados);
            }
            foreach (Especialidade e in Dados.TodasEspecialidades)
            {
                string[] dados = new string[2];
                dados[0] = e.CodEsp.ToString();
                dados[1] = e.NomeEsp;
                dgvListarEspecialidades.Rows.Add(dados);
                if (e.MedVinculados.Count!=0)
                {
                    for (int i = 0; i < e.MedVinculados.Count; i++)
                        colNMed.Items.Add(e.MedVinculados[i].NomeMed);
                }  
            }
            foreach (Doenca d in Dados.TodasDoencas)
            {
                string[] dados = new string[3];
                dados[0] = d.Codigo;
                dados[1] = d.Nome;
                dgvListaDoencas.Rows.Add(dados);
            }
        }
    }
}
