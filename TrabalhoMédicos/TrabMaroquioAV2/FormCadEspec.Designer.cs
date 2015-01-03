namespace TrabMaroquioAV2
{
    partial class frmCadastroEspec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEspec));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescEspec = new System.Windows.Forms.TextBox();
            this.btnCancelarCadEspec = new System.Windows.Forms.Button();
            this.btnGravarEspec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodEspec = new System.Windows.Forms.TextBox();
            this.txtNomenovaEspec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especialidade.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // txtDescEspec
            // 
            this.txtDescEspec.Location = new System.Drawing.Point(97, 80);
            this.txtDescEspec.Multiline = true;
            this.txtDescEspec.Name = "txtDescEspec";
            this.txtDescEspec.Size = new System.Drawing.Size(368, 132);
            this.txtDescEspec.TabIndex = 3;
            // 
            // btnCancelarCadEspec
            // 
            this.btnCancelarCadEspec.Location = new System.Drawing.Point(390, 231);
            this.btnCancelarCadEspec.Name = "btnCancelarCadEspec";
            this.btnCancelarCadEspec.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadEspec.TabIndex = 6;
            this.btnCancelarCadEspec.Text = "&Cancelar";
            this.btnCancelarCadEspec.UseVisualStyleBackColor = true;
            this.btnCancelarCadEspec.Click += new System.EventHandler(this.btnCancelarCadEspec_Click);
            // 
            // btnGravarEspec
            // 
            this.btnGravarEspec.Location = new System.Drawing.Point(309, 231);
            this.btnGravarEspec.Name = "btnGravarEspec";
            this.btnGravarEspec.Size = new System.Drawing.Size(75, 23);
            this.btnGravarEspec.TabIndex = 5;
            this.btnGravarEspec.Text = "&Gravar";
            this.btnGravarEspec.UseVisualStyleBackColor = true;
            this.btnGravarEspec.Click += new System.EventHandler(this.btnGravarEspec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Código.:";
            // 
            // txtCodEspec
            // 
            this.txtCodEspec.Enabled = false;
            this.txtCodEspec.Location = new System.Drawing.Point(97, 16);
            this.txtCodEspec.Name = "txtCodEspec";
            this.txtCodEspec.Size = new System.Drawing.Size(100, 20);
            this.txtCodEspec.TabIndex = 1;
            // 
            // txtNomenovaEspec
            // 
            this.txtNomenovaEspec.Location = new System.Drawing.Point(97, 48);
            this.txtNomenovaEspec.Name = "txtNomenovaEspec";
            this.txtNomenovaEspec.Size = new System.Drawing.Size(210, 20);
            this.txtNomenovaEspec.TabIndex = 2;
            // 
            // frmCadastroEspec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 266);
            this.Controls.Add(this.txtNomenovaEspec);
            this.Controls.Add(this.txtCodEspec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelarCadEspec);
            this.Controls.Add(this.btnGravarEspec);
            this.Controls.Add(this.txtDescEspec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastroEspec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova Especialidade";
            this.Load += new System.EventHandler(this.frmCadastroEspec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescEspec;
        private System.Windows.Forms.Button btnCancelarCadEspec;
        private System.Windows.Forms.Button btnGravarEspec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodEspec;
        private System.Windows.Forms.TextBox txtNomenovaEspec;
    }
}