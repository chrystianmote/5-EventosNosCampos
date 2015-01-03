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
            this.Text = "Formulário";
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked == true)
                txtNome.UseSystemPasswordChar = true;
            else
                txtNome.UseSystemPasswordChar = false;
        }

        private void Campo_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.Aquamarine;
        }

        private void Campoo_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string digitos = "0123456789";
            //Se não for dígito e nem for backspace
            if (!digitos.Contains(e.KeyChar) && (e.KeyChar != (char)8))
            {
                //Não aceita caractere
                e.Handled = true;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void ntfPrincipal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                ntfPrincipal.Visible = false;
            }
        }

        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState ==
                FormWindowState.Minimized)
            {
                ntfPrincipal.Visible = true;
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
            Application.ExitThread();
        }
    }
}
