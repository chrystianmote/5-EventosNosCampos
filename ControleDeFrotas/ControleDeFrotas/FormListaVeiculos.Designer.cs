namespace ControleDeFrotas
{
    partial class FormListaVeiculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.clmPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAnoAquisicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAnoFabricacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCapacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEixos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAbastecimentos = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cmsVeiculos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clmData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCombustivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLitros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecoLitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKmAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbastecimentos)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.cmsVeiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPlaca,
            this.clmAnoAquisicao,
            this.clmAnoFabricacao,
            this.clmModelo,
            this.clmFabricante,
            this.clmCapacidade,
            this.clmEixos});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVeiculos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVeiculos.Location = new System.Drawing.Point(9, 34);
            this.dgvVeiculos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.ReadOnly = true;
            this.dgvVeiculos.RowTemplate.Height = 24;
            this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeiculos.Size = new System.Drawing.Size(645, 262);
            this.dgvVeiculos.TabIndex = 0;
            this.dgvVeiculos.SelectionChanged += new System.EventHandler(this.dgvVeiculos_SelectionChanged);
            this.dgvVeiculos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvVeiculos_MouseDoubleClick);
            this.dgvVeiculos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvVeiculos_MouseDown);
            // 
            // clmPlaca
            // 
            this.clmPlaca.DataPropertyName = "Placa";
            this.clmPlaca.HeaderText = "Placa";
            this.clmPlaca.Name = "clmPlaca";
            this.clmPlaca.ReadOnly = true;
            this.clmPlaca.Width = 80;
            // 
            // clmAnoAquisicao
            // 
            this.clmAnoAquisicao.DataPropertyName = "AnoAquisicao";
            this.clmAnoAquisicao.HeaderText = "Ano Aquis.";
            this.clmAnoAquisicao.Name = "clmAnoAquisicao";
            this.clmAnoAquisicao.ReadOnly = true;
            this.clmAnoAquisicao.Width = 60;
            // 
            // clmAnoFabricacao
            // 
            this.clmAnoFabricacao.DataPropertyName = "AnoFabricacao";
            this.clmAnoFabricacao.HeaderText = "Ano Fab.";
            this.clmAnoFabricacao.Name = "clmAnoFabricacao";
            this.clmAnoFabricacao.ReadOnly = true;
            this.clmAnoFabricacao.Width = 60;
            // 
            // clmModelo
            // 
            this.clmModelo.DataPropertyName = "Modelo";
            this.clmModelo.HeaderText = "Modelo";
            this.clmModelo.Name = "clmModelo";
            this.clmModelo.ReadOnly = true;
            this.clmModelo.Width = 140;
            // 
            // clmFabricante
            // 
            this.clmFabricante.DataPropertyName = "Fabricante";
            this.clmFabricante.HeaderText = "Fabricante";
            this.clmFabricante.Name = "clmFabricante";
            this.clmFabricante.ReadOnly = true;
            this.clmFabricante.Width = 120;
            // 
            // clmCapacidade
            // 
            this.clmCapacidade.DataPropertyName = "Capacidade";
            this.clmCapacidade.HeaderText = "Capacidade";
            this.clmCapacidade.Name = "clmCapacidade";
            this.clmCapacidade.ReadOnly = true;
            this.clmCapacidade.Width = 70;
            // 
            // clmEixos
            // 
            this.clmEixos.DataPropertyName = "Eixos";
            this.clmEixos.HeaderText = "Eixos";
            this.clmEixos.Name = "clmEixos";
            this.clmEixos.ReadOnly = true;
            this.clmEixos.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veículos Cadastrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abastecimentos do Veículo Selecionado";
            // 
            // dgvAbastecimentos
            // 
            this.dgvAbastecimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbastecimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmData,
            this.clmCombustivel,
            this.clmLitros,
            this.clmPrecoLitro,
            this.clmKmAtual});
            this.dgvAbastecimentos.Location = new System.Drawing.Point(9, 323);
            this.dgvAbastecimentos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAbastecimentos.Name = "dgvAbastecimentos";
            this.dgvAbastecimentos.RowTemplate.Height = 24;
            this.dgvAbastecimentos.Size = new System.Drawing.Size(645, 158);
            this.dgvAbastecimentos.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnFechar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 493);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(663, 42);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Location = new System.Drawing.Point(575, 10);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(68, 20);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // cmsVeiculos
            // 
            this.cmsVeiculos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.cmsVeiculos.Name = "cmsVeiculos";
            this.cmsVeiculos.Size = new System.Drawing.Size(124, 52);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // clmData
            // 
            this.clmData.DataPropertyName = "Data";
            this.clmData.HeaderText = "Data/Hora";
            this.clmData.Name = "clmData";
            this.clmData.Width = 120;
            // 
            // clmCombustivel
            // 
            this.clmCombustivel.DataPropertyName = "Combustivel";
            this.clmCombustivel.HeaderText = "Combustivel";
            this.clmCombustivel.Name = "clmCombustivel";
            this.clmCombustivel.Width = 180;
            // 
            // clmLitros
            // 
            this.clmLitros.DataPropertyName = "Litros";
            this.clmLitros.HeaderText = "Litros";
            this.clmLitros.Name = "clmLitros";
            this.clmLitros.Width = 80;
            // 
            // clmPrecoLitro
            // 
            this.clmPrecoLitro.DataPropertyName = "PrecoLitro";
            this.clmPrecoLitro.HeaderText = "Preço/Litro";
            this.clmPrecoLitro.Name = "clmPrecoLitro";
            // 
            // clmKmAtual
            // 
            this.clmKmAtual.DataPropertyName = "KmAtual";
            this.clmKmAtual.HeaderText = "Km Atual";
            this.clmKmAtual.Name = "clmKmAtual";
            // 
            // FormListaVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 535);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAbastecimentos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVeiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListaVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listagem de Veículos Cadastrados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbastecimentos)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.cmsVeiculos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVeiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAbastecimentos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ContextMenuStrip cmsVeiculos;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAnoAquisicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAnoFabricacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCapacidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEixos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCombustivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLitros;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecoLitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKmAtual;
    }
}