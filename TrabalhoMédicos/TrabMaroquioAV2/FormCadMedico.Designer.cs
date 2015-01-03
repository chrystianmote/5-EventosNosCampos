namespace TrabMaroquioAV2
{
    partial class frmCadMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadMedicos));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbEspecMed = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeMed = new System.Windows.Forms.TextBox();
            this.btnGravarMedico = new System.Windows.Forms.Button();
            this.btnCancelarCadMed = new System.Windows.Forms.Button();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CRM.:";
            // 
            // cbbEspecMed
            // 
            this.cbbEspecMed.FormattingEnabled = true;
            this.cbbEspecMed.Location = new System.Drawing.Point(97, 108);
            this.cbbEspecMed.Name = "cbbEspecMed";
            this.cbbEspecMed.Size = new System.Drawing.Size(234, 21);
            this.cbbEspecMed.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Especialidade.:";
            // 
            // txtNomeMed
            // 
            this.txtNomeMed.Location = new System.Drawing.Point(59, 48);
            this.txtNomeMed.Name = "txtNomeMed";
            this.txtNomeMed.Size = new System.Drawing.Size(272, 20);
            this.txtNomeMed.TabIndex = 1;
            // 
            // btnGravarMedico
            // 
            this.btnGravarMedico.Location = new System.Drawing.Point(175, 161);
            this.btnGravarMedico.Name = "btnGravarMedico";
            this.btnGravarMedico.Size = new System.Drawing.Size(75, 23);
            this.btnGravarMedico.TabIndex = 4;
            this.btnGravarMedico.Text = "&Gravar";
            this.btnGravarMedico.UseVisualStyleBackColor = true;
            this.btnGravarMedico.Click += new System.EventHandler(this.btnGravarMedico_Click);
            // 
            // btnCancelarCadMed
            // 
            this.btnCancelarCadMed.Location = new System.Drawing.Point(256, 161);
            this.btnCancelarCadMed.Name = "btnCancelarCadMed";
            this.btnCancelarCadMed.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadMed.TabIndex = 5;
            this.btnCancelarCadMed.Text = "&Cancelar";
            this.btnCancelarCadMed.UseVisualStyleBackColor = true;
            this.btnCancelarCadMed.Click += new System.EventHandler(this.btnCancelarCadMed_Click_1);
            // 
            // txtCRM
            // 
            this.txtCRM.Location = new System.Drawing.Point(59, 16);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(76, 20);
            this.txtCRM.TabIndex = 0;
            // 
            // frmCadMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 210);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.btnCancelarCadMed);
            this.Controls.Add(this.btnGravarMedico);
            this.Controls.Add(this.txtNomeMed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbEspecMed);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Médicos";
            this.Load += new System.EventHandler(this.frmCadMedicos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbEspecMed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeMed;
        private System.Windows.Forms.Button btnGravarMedico;
        private System.Windows.Forms.Button btnCancelarCadMed;
        private System.Windows.Forms.TextBox txtCRM;
    }
}