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
    public partial class FormListagem : Form
    {
        public static List<Pessoa> Lista = new List<Pessoa>();

        public FormListagem()
        {
            InitializeComponent();
            Lista.Add(new Pessoa()
            {
                Codigo = 1,
                Nome = "Alberto",
                Data = Convert.ToDateTime("1/1/1960"),
                Ativo = false
            });
            Lista.Add(new Pessoa()
            {
                Codigo = 2,
                Nome = "Natália",
                Data = Convert.ToDateTime("7/9/1970"),
                Ativo = true
            });
            Lista.Add(new Pessoa()
            {
                Codigo = 3,
                Nome = "Iasmine",
                Data = Convert.ToDateTime("25/12/1950"),
                Ativo = true
            });
            Lista.Add(new Pessoa()
            {
                Codigo = 4,
                Nome = "Filipe",
                Data = Convert.ToDateTime("30/05/1990"),
                Ativo = false
            });
            Lista.Add(new Pessoa()
            {
                Codigo = 5,
                Nome = "Ibson",
                Data = Convert.ToDateTime("12/10/1975"),
                Ativo = true
            });
            Lista.Add(new Pessoa()
            {
                Codigo = 7,
                Nome = "Leonardo Moura",
                Data = Convert.ToDateTime("21/4/1981"),
                Ativo = false
            });
            Lista.Add(new Pessoa()
            {
                Codigo = 1,
                Nome = "Alberto",
                Data = Convert.ToDateTime("1/1/1960"),
                Ativo = false
            });
            Lista.Add(new Pessoa()
            {
                Codigo = 2,
                Nome = "Natália",
                Data = Convert.ToDateTime("7/9/1970"),
                Ativo = true
            });
            Lista.Add(new Pessoa()
            {
                Codigo = 3,
                Nome = "Iasmine",
                Data = Convert.ToDateTime("25/12/1950"),
                Ativo = true
            });
            Lista.Add(new Pessoa()
            {
                Codigo = 4,
                Nome = "Filipe",
                Data = Convert.ToDateTime("30/05/1990"),
                Ativo = false
            });
            Lista.Add(new Pessoa()
            {
                Codigo = 5,
                Nome = "Ibson",
                Data = Convert.ToDateTime("12/10/1975"),
                Ativo = true
            });
            Lista.Add(new Pessoa()
            {
                Codigo = 7,
                Nome = "Leonardo Moura",
                Data = Convert.ToDateTime("21/4/1981"),
                Ativo = false
            });
            //atribui a lista ao grid
            dgvDados.DataSource = new BindingSource(Lista, null);
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
            MessageBox.Show("Você clicou no código " + codigo.ToString(), "Informação", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            FormListagem.Lista.SingleOrDefault(x => x.Codigo == codigo);
        }
    }

    public class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public bool Ativo { get; set; }
    }
}
