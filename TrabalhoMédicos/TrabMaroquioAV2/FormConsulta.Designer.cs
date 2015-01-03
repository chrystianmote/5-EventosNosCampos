namespace TrabMaroquioAV2
{
    partial class FormConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.btnCancelarConsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGravarConsulta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCadConsValor = new System.Windows.Forms.TextBox();
            this.cbbCadConsPaciente = new System.Windows.Forms.ComboBox();
            this.cbbCadConsLocal = new System.Windows.Forms.ComboBox();
            this.cbbCadConsMedico = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbDoencasCID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelarConsulta
            // 
            this.btnCancelarConsulta.Location = new System.Drawing.Point(352, 410);
            this.btnCancelarConsulta.Name = "btnCancelarConsulta";
            this.btnCancelarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarConsulta.TabIndex = 10;
            this.btnCancelarConsulta.Text = "&Cancelar";
            this.btnCancelarConsulta.UseVisualStyleBackColor = true;
            this.btnCancelarConsulta.Click += new System.EventHandler(this.btnCancelarConsulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paciente.:";
            // 
            // dtpDataConsulta
            // 
            this.dtpDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataConsulta.Location = new System.Drawing.Point(73, 137);
            this.dtpDataConsulta.Name = "dtpDataConsulta";
            this.dtpDataConsulta.Size = new System.Drawing.Size(85, 20);
            this.dtpDataConsulta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Médico:";
            // 
            // btnGravarConsulta
            // 
            this.btnGravarConsulta.Location = new System.Drawing.Point(271, 410);
            this.btnGravarConsulta.Name = "btnGravarConsulta";
            this.btnGravarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnGravarConsulta.TabIndex = 9;
            this.btnGravarConsulta.Text = "&Gravar";
            this.btnGravarConsulta.UseVisualStyleBackColor = true;
            this.btnGravarConsulta.Click += new System.EventHandler(this.btnGravarConsulta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Local:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor:";
            // 
            // txtCadConsValor
            // 
            this.txtCadConsValor.Location = new System.Drawing.Point(337, 137);
            this.txtCadConsValor.Name = "txtCadConsValor";
            this.txtCadConsValor.Size = new System.Drawing.Size(90, 20);
            this.txtCadConsValor.TabIndex = 6;
            this.txtCadConsValor.Text = "0,00";
            this.txtCadConsValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbbCadConsPaciente
            // 
            this.cbbCadConsPaciente.FormattingEnabled = true;
            this.cbbCadConsPaciente.Location = new System.Drawing.Point(73, 16);
            this.cbbCadConsPaciente.Name = "cbbCadConsPaciente";
            this.cbbCadConsPaciente.Size = new System.Drawing.Size(354, 21);
            this.cbbCadConsPaciente.TabIndex = 1;
            // 
            // cbbCadConsLocal
            // 
            this.cbbCadConsLocal.FormattingEnabled = true;
            this.cbbCadConsLocal.Location = new System.Drawing.Point(73, 80);
            this.cbbCadConsLocal.Name = "cbbCadConsLocal";
            this.cbbCadConsLocal.Size = new System.Drawing.Size(354, 21);
            this.cbbCadConsLocal.TabIndex = 3;
            // 
            // cbbCadConsMedico
            // 
            this.cbbCadConsMedico.FormattingEnabled = true;
            this.cbbCadConsMedico.Location = new System.Drawing.Point(73, 48);
            this.cbbCadConsMedico.Name = "cbbCadConsMedico";
            this.cbbCadConsMedico.Size = new System.Drawing.Size(354, 21);
            this.cbbCadConsMedico.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(73, 224);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(354, 147);
            this.txtDescricao.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Diagnóstico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "CID.:";
            // 
            // cbbDoencasCID
            // 
            this.cbbDoencasCID.FormattingEnabled = true;
            this.cbbDoencasCID.Location = new System.Drawing.Point(73, 189);
            this.cbbDoencasCID.Name = "cbbDoencasCID";
            this.cbbDoencasCID.Size = new System.Drawing.Size(273, 21);
            this.cbbDoencasCID.TabIndex = 7;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 445);
            this.Controls.Add(this.cbbDoencasCID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbCadConsMedico);
            this.Controls.Add(this.cbbCadConsLocal);
            this.Controls.Add(this.cbbCadConsPaciente);
            this.Controls.Add(this.txtCadConsValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGravarConsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Consulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGravarConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCadConsValor;
        private System.Windows.Forms.ComboBox cbbCadConsPaciente;
        private System.Windows.Forms.ComboBox cbbCadConsLocal;
        private System.Windows.Forms.ComboBox cbbCadConsMedico;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbDoencasCID;
    }
}