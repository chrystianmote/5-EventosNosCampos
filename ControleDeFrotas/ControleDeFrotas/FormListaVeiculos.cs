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
    public partial class FormListaVeiculos : Form
    {
        public FormListaVeiculos()
        {
            InitializeComponent();             
            AtualizarGridVeiculos();         
        }

        //atualiza o dgvVeiculos com todos os veículos cadastrados
        private void AtualizarGridVeiculos()
        {
            //remove os dados atuais
            dgvVeiculos.DataSource = null;
            //desabilita a criação automática de colunas
            dgvVeiculos.AutoGenerateColumns = false;
            //redefine a fonte de dados
            dgvVeiculos.DataSource = Veiculo.Lista;
            //define que o alinhamento da quarta coluna é à esquerda
            dgvVeiculos.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;            
        }

        //atualiza o dgvAbastecimentos com os abastecimentos do veículo selecionado
        private void AtualizarGridAbastecimentos(List<Abastecimento> lista)
        {
            //remove os dados atuais
            dgvAbastecimentos.DataSource = null;
            //desabilita a criação automática de colunas
            dgvAbastecimentos.AutoGenerateColumns = false;
            //redefine a fonte de dados
            dgvAbastecimentos.DataSource = lista;
        }

        //manipulador da troca de linha selecionada no dgvVeiculos
        private void dgvVeiculos_SelectionChanged(object sender, EventArgs e)
        {
            //se há um veículo selecionado...
            if (dgvVeiculos.CurrentRow != null)
            {
                //captura a placa, obtendo o valor da primeira coluna da linha selecionada
                string placa = dgvVeiculos.CurrentRow.Cells[0].Value.ToString();
                //filtra os abastecimentos do veículo cuja placa foi capturada acima
                var abastecimentos = Abastecimento.Lista.Where(
                    x => x.Placa == placa).ToList<Abastecimento>();
                //atualiza o grid de abastecimentos com a lista obtida acima
                AtualizarGridAbastecimentos(abastecimentos);
            }
        }

        //manipulador do clique do mouse sobre o dgvVeiculos
        private void dgvVeiculos_MouseDown(object sender, MouseEventArgs e)
        {
            //cria um objeto que armazena informações de um ponto clicado
            DataGridView.HitTestInfo Hti;
            //se o botão direito do mouse foi clicado sobre o dgvVeiculos
            if (e.Button == MouseButtons.Right)
            {
                //obtém informações do ponto clicado
                Hti = dgvVeiculos.HitTest(e.X, e.Y);
                //se o ponto clicado é uma célula do DataGridView
                if (Hti.Type == DataGridViewHitTestType.Cell)
                {
                    //se a linha clicada não está selecionada
                    if (!((DataGridViewRow)(dgvVeiculos.Rows[Hti.RowIndex])).Selected)
                    {
                        //remove qualquer seleção de linha
                        dgvVeiculos.ClearSelection();
                        //seleciona a linha clicada
                        ((DataGridViewRow)dgvVeiculos.Rows[Hti.RowIndex]).Selected = true;                        
                        //torna a a primeira célula da linha como a célula atual
                        dgvVeiculos.CurrentCell = dgvVeiculos.Rows[Hti.RowIndex].Cells[0];
                        //invoca o método que carrega os abastecimentos do veículo
                        dgvVeiculos_SelectionChanged(null, null);
                    }
                }
                //mostra o menu suspenso no ponto clicado
                cmsVeiculos.Show(dgvVeiculos.PointToScreen(e.Location));
            }     
        }

        //manipulador do clique do menu suspenso "Alterar"
        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se há um veículo selecionado em dgvVeiculos
            if (dgvVeiculos.CurrentRow != null)
            {
                //captura a placa, pegando o valor da primeira célula da linha selecionada
                string placa = dgvVeiculos.CurrentRow.Cells[0].Value.ToString();
                //recupera, na lista de veículos, o objeto cuja placa é igual à capturada acima
                var veiculo = Veiculo.Lista.FirstOrDefault(
                    x => x.Placa == placa);
                //instancia um novo formulário de cadastro de veículos
                FormCadastroVeiculo form = new FormCadastroVeiculo();
                //associa o veículo capturado (já cadastrado) à propriedade "Veiculo" do formulário                
                form.Veiculo = veiculo;
                //se o formulário for exibido e for fechado com resultado "OK"
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //atualiza o dgvVeiculos
                    AtualizarGridVeiculos();
                }            
            }
        }

        //manipulador do duplo clique em dgvVeiculos
        private void dgvVeiculos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //invoca o método de alteração do veículo selecionado em dgvVeiculos
            alterarToolStripMenuItem_Click(sender, null);
        }        
    }
}
