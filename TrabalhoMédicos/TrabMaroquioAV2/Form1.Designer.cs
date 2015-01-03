namespace TrabMaroquioAV2
{
    partial class Form1
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
            this.btnpersistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpersistir
            // 
            this.btnpersistir.Location = new System.Drawing.Point(37, 50);
            this.btnpersistir.Name = "btnpersistir";
            this.btnpersistir.Size = new System.Drawing.Size(133, 50);
            this.btnpersistir.TabIndex = 0;
            this.btnpersistir.Text = "Doenca";
            this.btnpersistir.UseVisualStyleBackColor = true;
            this.btnpersistir.Click += new System.EventHandler(this.btnpersistir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 262);
            this.Controls.Add(this.btnpersistir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpersistir;
    }
}

