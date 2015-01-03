namespace TrabMaroquioAV2
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCadastroDeMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCadastroDePaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCadastroDeEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeEstabelecimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.novaConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeMédicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeEstabelecimentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeEspecialidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doençasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCadMed = new System.Windows.Forms.ToolStripButton();
            this.tsbCadPac = new System.Windows.Forms.ToolStripButton();
            this.tsbCadEspec = new System.Windows.Forms.ToolStripButton();
            this.tsbCadEstab = new System.Windows.Forms.ToolStripButton();
            this.tsbCadCons = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.webToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCadastroDeMedico,
            this.mnsCadastroDePaciente,
            this.mnsCadastroDeEspecialidades,
            this.cadastroDeEstabelecimentosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.novaConsultaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // mnsCadastroDeMedico
            // 
            this.mnsCadastroDeMedico.Name = "mnsCadastroDeMedico";
            this.mnsCadastroDeMedico.Size = new System.Drawing.Size(230, 22);
            this.mnsCadastroDeMedico.Text = "Cadastro de &Médicos";
            this.mnsCadastroDeMedico.Click += new System.EventHandler(this.mnsCadastroDeMedico_Click);
            // 
            // mnsCadastroDePaciente
            // 
            this.mnsCadastroDePaciente.Name = "mnsCadastroDePaciente";
            this.mnsCadastroDePaciente.Size = new System.Drawing.Size(230, 22);
            this.mnsCadastroDePaciente.Text = "Cadastro de &Pacientes";
            this.mnsCadastroDePaciente.Click += new System.EventHandler(this.cadastroDePacienteToolStripMenuItem_Click);
            // 
            // mnsCadastroDeEspecialidades
            // 
            this.mnsCadastroDeEspecialidades.Name = "mnsCadastroDeEspecialidades";
            this.mnsCadastroDeEspecialidades.Size = new System.Drawing.Size(230, 22);
            this.mnsCadastroDeEspecialidades.Text = "Cadastro de &Especialidades";
            this.mnsCadastroDeEspecialidades.Click += new System.EventHandler(this.cadastroDeEspecialidadesToolStripMenuItem_Click);
            // 
            // cadastroDeEstabelecimentosToolStripMenuItem
            // 
            this.cadastroDeEstabelecimentosToolStripMenuItem.Name = "cadastroDeEstabelecimentosToolStripMenuItem";
            this.cadastroDeEstabelecimentosToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.cadastroDeEstabelecimentosToolStripMenuItem.Text = "Cadastro de E&stabelecimentos";
            this.cadastroDeEstabelecimentosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeEstabelecimentosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(227, 6);
            // 
            // novaConsultaToolStripMenuItem
            // 
            this.novaConsultaToolStripMenuItem.Name = "novaConsultaToolStripMenuItem";
            this.novaConsultaToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.novaConsultaToolStripMenuItem.Text = "Nova &Consulta";
            this.novaConsultaToolStripMenuItem.Click += new System.EventHandler(this.novaConsultaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeMédicosToolStripMenuItem,
            this.cadastroDePacientesToolStripMenuItem,
            this.cadastroDeEstabelecimentosToolStripMenuItem1,
            this.cadastroDeEspecialidadesToolStripMenuItem1,
            this.consultasToolStripMenuItem,
            this.doençasToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.consultaToolStripMenuItem.Text = "C&onsultar Cadastros";
            // 
            // cadastroDeMédicosToolStripMenuItem
            // 
            this.cadastroDeMédicosToolStripMenuItem.Name = "cadastroDeMédicosToolStripMenuItem";
            this.cadastroDeMédicosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cadastroDeMédicosToolStripMenuItem.Text = "&Médicos";
            this.cadastroDeMédicosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeMédicosToolStripMenuItem_Click);
            // 
            // cadastroDePacientesToolStripMenuItem
            // 
            this.cadastroDePacientesToolStripMenuItem.Name = "cadastroDePacientesToolStripMenuItem";
            this.cadastroDePacientesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cadastroDePacientesToolStripMenuItem.Text = "&Pacientes";
            this.cadastroDePacientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePacientesToolStripMenuItem_Click);
            // 
            // cadastroDeEstabelecimentosToolStripMenuItem1
            // 
            this.cadastroDeEstabelecimentosToolStripMenuItem1.Name = "cadastroDeEstabelecimentosToolStripMenuItem1";
            this.cadastroDeEstabelecimentosToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.cadastroDeEstabelecimentosToolStripMenuItem1.Text = "&Unidades de Saúde";
            this.cadastroDeEstabelecimentosToolStripMenuItem1.Click += new System.EventHandler(this.cadastroDeEstabelecimentosToolStripMenuItem1_Click);
            // 
            // cadastroDeEspecialidadesToolStripMenuItem1
            // 
            this.cadastroDeEspecialidadesToolStripMenuItem1.Name = "cadastroDeEspecialidadesToolStripMenuItem1";
            this.cadastroDeEspecialidadesToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.cadastroDeEspecialidadesToolStripMenuItem1.Text = "&Especialidades";
            this.cadastroDeEspecialidadesToolStripMenuItem1.Click += new System.EventHandler(this.cadastroDeEspecialidadesToolStripMenuItem1_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // doençasToolStripMenuItem
            // 
            this.doençasToolStripMenuItem.Name = "doençasToolStripMenuItem";
            this.doençasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.doençasToolStripMenuItem.Text = "&Doenças";
            this.doençasToolStripMenuItem.Click += new System.EventHandler(this.doençasToolStripMenuItem_Click);
            // 
            // webToolStripMenuItem
            // 
            this.webToolStripMenuItem.Name = "webToolStripMenuItem";
            this.webToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.webToolStripMenuItem.Text = "Web";
            this.webToolStripMenuItem.Click += new System.EventHandler(this.webToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::TrabMaroquioAV2.Properties.Resources.estetoscopio_curso_de_medicina;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 436);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadMed,
            this.tsbCadPac,
            this.tsbCadEspec,
            this.tsbCadEstab,
            this.tsbCadCons,
            this.toolStripSeparator1,
            this.tsbSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(909, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbCadMed
            // 
            this.tsbCadMed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadMed.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadMed.Image")));
            this.tsbCadMed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadMed.Name = "tsbCadMed";
            this.tsbCadMed.Size = new System.Drawing.Size(52, 52);
            this.tsbCadMed.Text = "Cadastrar Medico";
            this.tsbCadMed.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbCadMed.Click += new System.EventHandler(this.tsbCadMed_Click);
            this.tsbCadMed.MouseHover += new System.EventHandler(this.tsbCadMed_MouseHover);
            // 
            // tsbCadPac
            // 
            this.tsbCadPac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadPac.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadPac.Image")));
            this.tsbCadPac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadPac.Name = "tsbCadPac";
            this.tsbCadPac.Size = new System.Drawing.Size(52, 52);
            this.tsbCadPac.Text = "Cadastrar Paciente";
            this.tsbCadPac.Click += new System.EventHandler(this.tsbCadPac_Click);
            // 
            // tsbCadEspec
            // 
            this.tsbCadEspec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadEspec.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadEspec.Image")));
            this.tsbCadEspec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadEspec.Name = "tsbCadEspec";
            this.tsbCadEspec.Size = new System.Drawing.Size(52, 52);
            this.tsbCadEspec.Text = "Cadastrar Especialidade";
            this.tsbCadEspec.Click += new System.EventHandler(this.tsbCadEspec_Click);
            // 
            // tsbCadEstab
            // 
            this.tsbCadEstab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadEstab.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadEstab.Image")));
            this.tsbCadEstab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadEstab.Name = "tsbCadEstab";
            this.tsbCadEstab.Size = new System.Drawing.Size(52, 52);
            this.tsbCadEstab.Text = "Consultório";
            this.tsbCadEstab.Click += new System.EventHandler(this.cadastroDeEstabelecimentosToolStripMenuItem_Click);
            // 
            // tsbCadCons
            // 
            this.tsbCadCons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadCons.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadCons.Image")));
            this.tsbCadCons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadCons.Name = "tsbCadCons";
            this.tsbCadCons.Size = new System.Drawing.Size(52, 52);
            this.tsbCadCons.Text = "Cadastro Consulta";
            this.tsbCadCons.Click += new System.EventHandler(this.novaConsultaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbSair
            // 
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(52, 52);
            this.tsbSair.Text = "Sair do Programa";
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 508);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Unificado de Consultas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsCadastroDeMedico;
        private System.Windows.Forms.ToolStripMenuItem mnsCadastroDePaciente;
        private System.Windows.Forms.ToolStripMenuItem mnsCadastroDeEspecialidades;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novaConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMédicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeEspecialidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doençasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeEstabelecimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeEstabelecimentosToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCadMed;
        private System.Windows.Forms.ToolStripButton tsbCadPac;
        private System.Windows.Forms.ToolStripButton tsbCadEspec;
        private System.Windows.Forms.ToolStripButton tsbCadEstab;
        private System.Windows.Forms.ToolStripButton tsbCadCons;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.ToolStripMenuItem webToolStripMenuItem;

    }
}

