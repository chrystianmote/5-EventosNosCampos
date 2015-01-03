using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsStart
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            this.Text = "Formulário Principal";
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Principal";
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.Aquamarine;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string digitos = "0123456789";
            if (!digitos.Contains(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            //exibe o formulário de maneira modal (excluisiva)
            //form.ShowDialog();
            //exibe o formulário de maneira não modal (compartilhada)

            this.Hide();

            form.ShowDialog();

            this.Show();
        }

        private void ntfPrincipal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
            }
            else 
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                ntfPrincipal.Visible = false;
                
            }
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            //se a janela foi minimizada
            if (this.WindowState == FormWindowState.Minimized)
            {
                //mostra o ícone da área de notificação
                ntfPrincipal.Visible = true;
                //oculta o formulário
                this.Hide();
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            ntfPrincipal.Visible = true;
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }

        private void btnMostrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnMostrar_Click(null, null);
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobre janela = new FormSobre();
            janela.ShowDialog();
        }

        private void menuNotify_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListagem form = new FormListagem();
            form.ShowDialog();
        }
    }
}
