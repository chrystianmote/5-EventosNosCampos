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
    public partial class FormCadastroVeiculo : Form
    {
        //propriedade utilizada para se armazenar um objeto veículo
        //a ser alterado, quando a operação for de alteração
        public Veiculo Veiculo { get; set; }

        //método construtor da classe
        public FormCadastroVeiculo()
        {
            InitializeComponent();
            //efeito de recebimento de foco
            UtilControls.EfeitoCampoComFoco(txtPlaca);
            UtilControls.EfeitoCampoComFoco(txtAnoAquis);
            UtilControls.EfeitoCampoComFoco(txtAnoFab);
            UtilControls.EfeitoCampoComFoco(txtEixos);
            UtilControls.EfeitoCampoComFoco(txtModelo);
            UtilControls.EfeitoCampoComFoco(cbxFabricante);
            UtilControls.EfeitoCampoComFoco(cbxTipo);
            UtilControls.EfeitoCampoComFoco(txtCapacidade);
            //efeito de campo numérico
            UtilControls.EfeitoCampoNumerico(txtAnoAquis);
            UtilControls.EfeitoCampoNumerico(txtAnoFab);
            UtilControls.EfeitoCampoNumerico(txtEixos);
            UtilControls.EfeitoCampoNumerico(txtCapacidade);            
        }

        //manipulador do clique do botão "Cadastrar"
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //recupera o veículo associado a este formulário, utilizado
            //quando se trata de uma alteração de um objeto existente
            Veiculo veiculo = this.Veiculo;
            if (veiculo == null)
                 veiculo = new Veiculo();            
            //preenche as propriedades do objeto com os dados do formulário    
            veiculo.Placa = txtPlaca.Text;
            veiculo.AnoAquisicao = Convert.ToInt32(txtAnoAquis.Text);
            veiculo.AnoFabricacao = Convert.ToInt32(txtAnoFab.Text);
            veiculo.Eixos = Convert.ToInt32(txtEixos.Text);
            veiculo.Modelo = txtModelo.Text;
            veiculo.Fabricante = cbxFabricante.Text;
            veiculo.Tipo = cbxTipo.Text;
            veiculo.Capacidade = Convert.ToInt32(txtCapacidade.Text);
            //se o veículo associado ao formulário for nulo, significa que
            //não é uma alteração, ou seja, é uma inclusão
            if (this.Veiculo == null)
                Veiculo.Lista.Add(veiculo);
            //persiste a lista de veículos em arquivo
            Veiculo.PersistirLista();
            //fecha o formulário com o resultado "OK"
            this.DialogResult = DialogResult.OK;
        }

        //manipulador do evento "Shown", executado quando o formulário é exibido
        private void FormCadastroVeiculo_Shown(object sender, EventArgs e)
        {
            //se há um veículo associado ao formulário, ou seja,
            //se é uma alteração...
            if (this.Veiculo != null)
            {
                //preenche os campos do formulário com os dados do veículo a ser alterado
                txtPlaca.Text = this.Veiculo.Placa;
                txtAnoAquis.Text = this.Veiculo.AnoAquisicao.ToString();
                txtAnoFab.Text = this.Veiculo.AnoFabricacao.ToString();
                txtEixos.Text = this.Veiculo.Eixos.ToString();
                txtModelo.Text = this.Veiculo.Modelo;
                cbxFabricante.Text = this.Veiculo.Fabricante;
                cbxTipo.Text = this.Veiculo.Tipo;
                txtCapacidade.Text = this.Veiculo.Capacidade.ToString();
                btnCadastrar.Text = "Alterar";
            }
        }        
    }
}
