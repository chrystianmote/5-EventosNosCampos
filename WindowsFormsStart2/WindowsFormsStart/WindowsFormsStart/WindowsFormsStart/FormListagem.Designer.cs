namespace WindowsFormsStart
{
    partial class FormListagem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNome,
            this.clmData,
            this.clmAtivo,
            this.clmAlterar});
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(0, 0);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(559, 317);
            this.dgvDados.TabIndex = 0;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // clmCodigo
            // 
            this.clmCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Format = "D6";
            dataGridViewCellStyle4.NullValue = null;
            this.clmCodigo.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmCodigo.Frozen = true;
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 80;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "Nome";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmNome.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmNome.Frozen = true;
            this.clmNome.HeaderText = "Nome";
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            this.clmNome.Width = 200;
            // 
            // clmData
            // 
            this.clmData.DataPropertyName = "Data";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.clmData.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmData.Frozen = true;
            this.clmData.HeaderText = "Data";
            this.clmData.Name = "clmData";
            this.clmData.ReadOnly = true;
            // 
            // clmAtivo
            // 
            this.clmAtivo.DataPropertyName = "Ativo";
            this.clmAtivo.FalseValue = "Não";
            this.clmAtivo.Frozen = true;
            this.clmAtivo.HeaderText = "Ativo";
            this.clmAtivo.IndeterminateValue = "Indefinido";
            this.clmAtivo.Name = "clmAtivo";
            this.clmAtivo.ReadOnly = true;
            this.clmAtivo.TrueValue = "Sim";
            this.clmAtivo.Width = 60;
            // 
            // clmAlterar
            // 
            this.clmAlterar.DataPropertyName = "Codigo";
            this.clmAlterar.Frozen = true;
            this.clmAlterar.HeaderText = "Alteração";
            this.clmAlterar.Name = "clmAlterar";
            this.clmAlterar.ReadOnly = true;
            this.clmAlterar.Text = "Alterar";
            this.clmAlterar.UseColumnTextForButtonValue = true;
            this.clmAlterar.Width = 60;
            // 
            // FormListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 317);
            this.Controls.Add(this.dgvDados);
            this.Name = "FormListagem";
            this.Text = "Listagem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmAtivo;
        private System.Windows.Forms.DataGridViewButtonColumn clmAlterar;
    }
}