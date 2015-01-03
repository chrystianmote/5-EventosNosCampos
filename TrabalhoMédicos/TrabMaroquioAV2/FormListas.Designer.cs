namespace TrabMaroquioAV2
{
    partial class FormListas
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
            this.tbcListas = new System.Windows.Forms.TabControl();
            this.tbpMedicos = new System.Windows.Forms.TabPage();
            this.dgvListaMedico = new System.Windows.Forms.DataGridView();
            this.tbpPacientes = new System.Windows.Forms.TabPage();
            this.dgvListaPaciente = new System.Windows.Forms.DataGridView();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomePac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefonePac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpUnidades = new System.Windows.Forms.TabPage();
            this.dgvListaEstab = new System.Windows.Forms.DataGridView();
            this.colEstbCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstabNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstabTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpListaConsulta = new System.Windows.Forms.TabPage();
            this.dgvListaConsulta = new System.Windows.Forms.DataGridView();
            this.colMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraDataConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpEspecialidades = new System.Windows.Forms.TabPage();
            this.dgvListarEspecialidades = new System.Windows.Forms.DataGridView();
            this.colCodEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEspecialidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNMed = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbpListaDoencas = new System.Windows.Forms.TabPage();
            this.dgvListaDoencas = new System.Windows.Forms.DataGridView();
            this.colCodDoencas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescDoencas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEspec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcListas.SuspendLayout();
            this.tbpMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMedico)).BeginInit();
            this.tbpPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPaciente)).BeginInit();
            this.tbpUnidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEstab)).BeginInit();
            this.tbpListaConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConsulta)).BeginInit();
            this.tbpEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEspecialidades)).BeginInit();
            this.tbpListaDoencas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoencas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcListas
            // 
            this.tbcListas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcListas.Controls.Add(this.tbpMedicos);
            this.tbcListas.Controls.Add(this.tbpPacientes);
            this.tbcListas.Controls.Add(this.tbpUnidades);
            this.tbcListas.Controls.Add(this.tbpListaConsulta);
            this.tbcListas.Controls.Add(this.tbpEspecialidades);
            this.tbcListas.Controls.Add(this.tbpListaDoencas);
            this.tbcListas.Location = new System.Drawing.Point(1, 1);
            this.tbcListas.Name = "tbcListas";
            this.tbcListas.SelectedIndex = 0;
            this.tbcListas.Size = new System.Drawing.Size(662, 443);
            this.tbcListas.TabIndex = 0;
            // 
            // tbpMedicos
            // 
            this.tbpMedicos.Controls.Add(this.dgvListaMedico);
            this.tbpMedicos.Location = new System.Drawing.Point(4, 22);
            this.tbpMedicos.Name = "tbpMedicos";
            this.tbpMedicos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMedicos.Size = new System.Drawing.Size(654, 417);
            this.tbpMedicos.TabIndex = 0;
            this.tbpMedicos.Text = "Médicos";
            this.tbpMedicos.UseVisualStyleBackColor = true;
            // 
            // dgvListaMedico
            // 
            this.dgvListaMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCRM,
            this.colNomeMed,
            this.colEspec,
            this.colRenda});
            this.dgvListaMedico.Location = new System.Drawing.Point(1, 0);
            this.dgvListaMedico.Name = "dgvListaMedico";
            this.dgvListaMedico.Size = new System.Drawing.Size(643, 417);
            this.dgvListaMedico.TabIndex = 0;
            // 
            // tbpPacientes
            // 
            this.tbpPacientes.Controls.Add(this.dgvListaPaciente);
            this.tbpPacientes.Location = new System.Drawing.Point(4, 22);
            this.tbpPacientes.Name = "tbpPacientes";
            this.tbpPacientes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPacientes.Size = new System.Drawing.Size(654, 417);
            this.tbpPacientes.TabIndex = 1;
            this.tbpPacientes.Text = "Pacientes";
            this.tbpPacientes.UseVisualStyleBackColor = true;
            // 
            // dgvListaPaciente
            // 
            this.dgvListaPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCPF,
            this.colNomePac,
            this.colTelefonePac});
            this.dgvListaPaciente.Location = new System.Drawing.Point(1, 0);
            this.dgvListaPaciente.Name = "dgvListaPaciente";
            this.dgvListaPaciente.Size = new System.Drawing.Size(643, 417);
            this.dgvListaPaciente.TabIndex = 1;
            // 
            // colCPF
            // 
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            // 
            // colNomePac
            // 
            this.colNomePac.HeaderText = "Nome";
            this.colNomePac.Name = "colNomePac";
            this.colNomePac.Width = 300;
            // 
            // colTelefonePac
            // 
            this.colTelefonePac.HeaderText = "Telefone";
            this.colTelefonePac.Name = "colTelefonePac";
            this.colTelefonePac.Width = 200;
            // 
            // tbpUnidades
            // 
            this.tbpUnidades.Controls.Add(this.dgvListaEstab);
            this.tbpUnidades.Location = new System.Drawing.Point(4, 22);
            this.tbpUnidades.Name = "tbpUnidades";
            this.tbpUnidades.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUnidades.Size = new System.Drawing.Size(654, 417);
            this.tbpUnidades.TabIndex = 2;
            this.tbpUnidades.Text = "Unidades de Saúde";
            this.tbpUnidades.UseVisualStyleBackColor = true;
            // 
            // dgvListaEstab
            // 
            this.dgvListaEstab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaEstab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEstab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEstbCNPJ,
            this.colEstabNome,
            this.colEstabTel});
            this.dgvListaEstab.Location = new System.Drawing.Point(1, 0);
            this.dgvListaEstab.Name = "dgvListaEstab";
            this.dgvListaEstab.Size = new System.Drawing.Size(643, 417);
            this.dgvListaEstab.TabIndex = 1;
            // 
            // colEstbCNPJ
            // 
            this.colEstbCNPJ.HeaderText = "CNPJ";
            this.colEstbCNPJ.Name = "colEstbCNPJ";
            // 
            // colEstabNome
            // 
            this.colEstabNome.HeaderText = "Razão Social";
            this.colEstabNome.Name = "colEstabNome";
            this.colEstabNome.Width = 300;
            // 
            // colEstabTel
            // 
            this.colEstabTel.HeaderText = "Telefone";
            this.colEstabTel.Name = "colEstabTel";
            this.colEstabTel.Width = 200;
            // 
            // tbpListaConsulta
            // 
            this.tbpListaConsulta.Controls.Add(this.dgvListaConsulta);
            this.tbpListaConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbpListaConsulta.Name = "tbpListaConsulta";
            this.tbpListaConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListaConsulta.Size = new System.Drawing.Size(654, 417);
            this.tbpListaConsulta.TabIndex = 3;
            this.tbpListaConsulta.Text = "Consultas";
            this.tbpListaConsulta.UseVisualStyleBackColor = true;
            // 
            // dgvListaConsulta
            // 
            this.dgvListaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMed,
            this.colPac,
            this.colHoraDataConsulta});
            this.dgvListaConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaConsulta.Location = new System.Drawing.Point(3, 3);
            this.dgvListaConsulta.Name = "dgvListaConsulta";
            this.dgvListaConsulta.Size = new System.Drawing.Size(648, 411);
            this.dgvListaConsulta.TabIndex = 0;
            // 
            // colMed
            // 
            this.colMed.HeaderText = "Médico";
            this.colMed.Name = "colMed";
            this.colMed.Width = 225;
            // 
            // colPac
            // 
            this.colPac.HeaderText = "Paciente";
            this.colPac.Name = "colPac";
            this.colPac.Width = 225;
            // 
            // colHoraDataConsulta
            // 
            this.colHoraDataConsulta.HeaderText = "Data da Consulta";
            this.colHoraDataConsulta.Name = "colHoraDataConsulta";
            this.colHoraDataConsulta.Width = 150;
            // 
            // tbpEspecialidades
            // 
            this.tbpEspecialidades.Controls.Add(this.dgvListarEspecialidades);
            this.tbpEspecialidades.Location = new System.Drawing.Point(4, 22);
            this.tbpEspecialidades.Name = "tbpEspecialidades";
            this.tbpEspecialidades.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEspecialidades.Size = new System.Drawing.Size(654, 417);
            this.tbpEspecialidades.TabIndex = 4;
            this.tbpEspecialidades.Text = "Especialidades";
            this.tbpEspecialidades.UseVisualStyleBackColor = true;
            // 
            // dgvListarEspecialidades
            // 
            this.dgvListarEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodEsp,
            this.colEspecialidades,
            this.colNMed});
            this.dgvListarEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListarEspecialidades.Location = new System.Drawing.Point(3, 3);
            this.dgvListarEspecialidades.Name = "dgvListarEspecialidades";
            this.dgvListarEspecialidades.Size = new System.Drawing.Size(640, 411);
            this.dgvListarEspecialidades.TabIndex = 0;
            // 
            // colCodEsp
            // 
            this.colCodEsp.HeaderText = "Código Esp.";
            this.colCodEsp.Name = "colCodEsp";
            // 
            // colEspecialidades
            // 
            this.colEspecialidades.HeaderText = "Especialidades";
            this.colEspecialidades.Name = "colEspecialidades";
            this.colEspecialidades.Width = 170;
            // 
            // colNMed
            // 
            this.colNMed.HeaderText = "Médicos Vinculados";
            this.colNMed.Name = "colNMed";
            this.colNMed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNMed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colNMed.Width = 325;
            // 
            // tbpListaDoencas
            // 
            this.tbpListaDoencas.Controls.Add(this.dgvListaDoencas);
            this.tbpListaDoencas.Location = new System.Drawing.Point(4, 22);
            this.tbpListaDoencas.Name = "tbpListaDoencas";
            this.tbpListaDoencas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListaDoencas.Size = new System.Drawing.Size(654, 417);
            this.tbpListaDoencas.TabIndex = 5;
            this.tbpListaDoencas.Text = "Doenças";
            this.tbpListaDoencas.UseVisualStyleBackColor = true;
            // 
            // dgvListaDoencas
            // 
            this.dgvListaDoencas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoencas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodDoencas,
            this.colDescDoencas});
            this.dgvListaDoencas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaDoencas.Location = new System.Drawing.Point(3, 3);
            this.dgvListaDoencas.Name = "dgvListaDoencas";
            this.dgvListaDoencas.Size = new System.Drawing.Size(648, 411);
            this.dgvListaDoencas.TabIndex = 0;
            // 
            // colCodDoencas
            // 
            this.colCodDoencas.HeaderText = "Códigos";
            this.colCodDoencas.Name = "colCodDoencas";
            // 
            // colDescDoencas
            // 
            this.colDescDoencas.HeaderText = "Descrição da Doença";
            this.colDescDoencas.Name = "colDescDoencas";
            this.colDescDoencas.Width = 505;
            // 
            // colCRM
            // 
            this.colCRM.HeaderText = "CRM";
            this.colCRM.Name = "colCRM";
            // 
            // colNomeMed
            // 
            this.colNomeMed.HeaderText = "Nome";
            this.colNomeMed.Name = "colNomeMed";
            this.colNomeMed.Width = 250;
            // 
            // colEspec
            // 
            this.colEspec.HeaderText = "Especialização";
            this.colEspec.Name = "colEspec";
            this.colEspec.Width = 150;
            // 
            // colRenda
            // 
            this.colRenda.HeaderText = "Pagamentos";
            this.colRenda.Name = "colRenda";
            // 
            // FormListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 444);
            this.Controls.Add(this.tbcListas);
            this.Name = "FormListas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas";
            this.tbcListas.ResumeLayout(false);
            this.tbpMedicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMedico)).EndInit();
            this.tbpPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPaciente)).EndInit();
            this.tbpUnidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEstab)).EndInit();
            this.tbpListaConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaConsulta)).EndInit();
            this.tbpEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEspecialidades)).EndInit();
            this.tbpListaDoencas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoencas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcListas;
        private System.Windows.Forms.TabPage tbpMedicos;
        private System.Windows.Forms.DataGridView dgvListaMedico;
        private System.Windows.Forms.TabPage tbpPacientes;
        private System.Windows.Forms.TabPage tbpUnidades;
        private System.Windows.Forms.DataGridView dgvListaPaciente;
        private System.Windows.Forms.DataGridView dgvListaEstab;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomePac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefonePac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstbCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstabNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstabTel;
        private System.Windows.Forms.TabPage tbpListaConsulta;
        private System.Windows.Forms.DataGridView dgvListaConsulta;
        private System.Windows.Forms.TabPage tbpEspecialidades;
        private System.Windows.Forms.DataGridView dgvListarEspecialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspecialidades;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNMed;
        private System.Windows.Forms.TabPage tbpListaDoencas;
        private System.Windows.Forms.DataGridView dgvListaDoencas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodDoencas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescDoencas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraDataConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenda;
    }
}