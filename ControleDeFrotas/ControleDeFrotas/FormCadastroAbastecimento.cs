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
    public partial class FormCadastroAbastecimento : Form
    {
        public FormCadastroAbastecimento()
        {
            InitializeComponent();
            //efeito de recebimento de foco
            UtilControls.EfeitoCampoComFoco(cbxPlaca);
            UtilControls.EfeitoCampoComFoco(dtpDataAbastecimento);
            UtilControls.EfeitoCampoComFoco(cbxCombustivel);
            UtilControls.EfeitoCampoComFoco(txtLitros);
            UtilControls.EfeitoCampoComFoco(txtPrecoLitro);
            UtilControls.EfeitoCampoComFoco(txtKmAtual);
            //efeito de campo numérico
            UtilControls.EfeitoCampoNumerico(txtLitros);
            UtilControls.EfeitoCampoNumerico(txtKmAtual);
            //efeito de campo monetário
            UtilControls.EfeitoCampoMonetario(txtPrecoLitro);
            //atualiza o campo de seleção de placa
            AtualizarCampoPlacas();
        }

        private void AtualizarCampoPlacas()
        {
            //obtém todos os números de placas da lista de veículos
            var lista = Veiculo.Lista.Select(x => new {Placa = x.Placa}).ToList();
            //remove os dados de cbxPlaca
            cbxPlaca.DataSource = null;
            //define a propriedade "Placa" para ser apresentada no cbxPlaca
            cbxPlaca.DisplayMember = "Placa";
            //define a propriedade "Placa" para ser valor do cbxPlaca
            cbxPlaca.ValueMember = "Placa";
            //atribui a lista de placas à fonte de dados do cbxPlaca
            cbxPlaca.DataSource = lista;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //cria um novo objeto Abastecimento
            Abastecimento abastecimento = new Abastecimento();
            //preenche as propriedades do objeto com os valores do formulário
            abastecimento.Placa = cbxPlaca.Text;
            abastecimento.Data = dtpDataAbastecimento.Value.Date;
            abastecimento.Combustivel = cbxCombustivel.Text;
            abastecimento.Litros = Convert.ToDouble(txtLitros.Text);
            abastecimento.PrecoLitro = Convert.ToDouble(txtPrecoLitro.Text);
            abastecimento.KmAtual = Convert.ToDouble(txtKmAtual.Text);
            //adiciona o objeto à lista de abastecimentos
            Abastecimento.Lista.Add(abastecimento);
            //persiste a lista em arquivo
            Abastecimento.PersistirLista();
            //fecha o formulário com resultado "OK"
            this.DialogResult = DialogResult.OK;
        }        
    }
}
