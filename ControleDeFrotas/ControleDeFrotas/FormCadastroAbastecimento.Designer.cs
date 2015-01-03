namespace ControleDeFrotas
{
    partial class FormCadastroAbastecimento
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPlaca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCombustivel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataAbastecimento = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecoLitro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKmAtual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Placa:";
            // 
            // cbxPlaca
            // 
            this.cbxPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPlaca.FormattingEnabled = true;
            this.cbxPlaca.Location = new System.Drawing.Point(17, 37);
            this.cbxPlaca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxPlaca.Name = "cbxPlaca";
            this.cbxPlaca.Size = new System.Drawing.Size(76, 21);
            this.cbxPlaca.Sorted = true;
            this.cbxPlaca.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data:";
            // 
            // cbxCombustivel
            // 
            this.cbxCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCombustivel.FormattingEnabled = true;
            this.cbxCombustivel.Items.AddRange(new object[] {
            "Álcool",
            "Diesel",
            "Gás Natural",
            "Gasolina"});
            this.cbxCombustivel.Location = new System.Drawing.Point(17, 81);
            this.cbxCombustivel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCombustivel.Name = "cbxCombustivel";
            this.cbxCombustivel.Size = new System.Drawing.Size(173, 21);
            this.cbxCombustivel.Sorted = true;
            this.cbxCombustivel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Combustível:";
            // 
            // dtpDataAbastecimento
            // 
            this.dtpDataAbastecimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAbastecimento.Location = new System.Drawing.Point(106, 38);
            this.dtpDataAbastecimento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataAbastecimento.Name = "dtpDataAbastecimento";
            this.dtpDataAbastecimento.Size = new System.Drawing.Size(84, 20);
            this.dtpDataAbastecimento.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnCadastrar);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 165);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(207, 42);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(119, 10);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(68, 20);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(47, 10);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 20);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(17, 126);
            this.txtLitros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLitros.MaxLength = 3;
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(34, 20);
            this.txtLitros.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Litros:";
            // 
            // txtPrecoLitro
            // 
            this.txtPrecoLitro.Location = new System.Drawing.Point(68, 126);
            this.txtPrecoLitro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecoLitro.MaxLength = 4;
            this.txtPrecoLitro.Name = "txtPrecoLitro";
            this.txtPrecoLitro.Size = new System.Drawing.Size(60, 20);
            this.txtPrecoLitro.TabIndex = 4;
            this.txtPrecoLitro.Text = "0,00";
            this.txtPrecoLitro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Preço/Litro:";
            // 
            // txtKmAtual
            // 
            this.txtKmAtual.Location = new System.Drawing.Point(143, 126);
            this.txtKmAtual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKmAtual.MaxLength = 6;
            this.txtKmAtual.Name = "txtKmAtual";
            this.txtKmAtual.Size = new System.Drawing.Size(47, 20);
            this.txtKmAtual.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Km Atual:";
            // 
            // FormCadastroAbastecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 207);
            this.Controls.Add(this.txtKmAtual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecoLitro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dtpDataAbastecimento);
            this.Controls.Add(this.cbxCombustivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxPlaca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroAbastecimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Abastecimento";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCombustivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataAbastecimento;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecoLitro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKmAtual;
        private System.Windows.Forms.Label label6;
    }
}