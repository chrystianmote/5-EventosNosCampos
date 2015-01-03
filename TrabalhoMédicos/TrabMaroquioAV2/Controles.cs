using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace TrabMaroquioAV2
{
    public class Controles
    {
        //utilizado para fazer com quem um textbox aceite apenas números inteiros
        private static void txtCampoNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] caracteresPermitidos = new char[] { '0', '1', '2', '3', '4',
                '5', '6', '7', '8', '9', Convert.ToChar(8) };

            if (!caracteresPermitidos.Contains(e.KeyChar))
            {
                e.Handled = true;
                e.KeyChar = Convert.ToChar(0);
            }
        }
        //utilizado para que a cor de um controle mude quando ele receber o foco
        private static void CampoForm_Enter(object sender, EventArgs e)
        {
            //hierarquia de componentes Windows Forms
            //http://msdn.microsoft.com/en-us/library/8w7ed3ba(v=vs.71).aspx
            (sender as Control).BackColor =
                Color.FromKnownColor(KnownColor.ActiveBorder);
        }
        //utilizado para que a cor de um controle volte ao normal quando ele receber o foco
        private static void CampoForm_Leave(object sender, EventArgs e)
        {
            //hierarquia de componentes Windows Forms
            //http://msdn.microsoft.com/en-us/library/8w7ed3ba(v=vs.71).aspx
            (sender as Control).BackColor =
                Color.FromKnownColor(KnownColor.Window);
        }
        //utilizado para fazer com quem um textbox aceite apenas valores com 2 casas decimais
        private static void txtCampoMonetario_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtValor = (sender as TextBox);
            string valor = txtValor.Text.Replace(",", "");

            char[] caracteresPermitidos = new char[] { '0', '1', '2', '3', '4',
                '5', '6', '7', '8', '9' };

            if (!caracteresPermitidos.Contains(e.KeyChar))
            {
                if (e.KeyChar == Convert.ToChar(8))
                {
                    valor = valor.Remove(valor.Length - 1, 1);
                }
                e.Handled = true;
                e.KeyChar = Convert.ToChar(0);
            }
            else
            {
                if (valor.Length < txtValor.MaxLength)
                {
                    e.Handled = true;
                    valor += e.KeyChar;
                }
                else
                {
                    e.Handled = true;
                    e.KeyChar = Convert.ToChar(0);
                    SystemSounds.Beep.Play();
                }
            }
            if (valor.Length == 0) { valor = "0"; }
            txtValor.Text = (Convert.ToDouble(valor) / 100).ToString("F2");
            txtValor.SelectionStart = txtValor.Text.Length;
        }
        //tratamento especial para campos monetários, para que o cursor de digitação 
        //fique sempre no final (à direita) do valor digitado quando este receber o foco
        private static void txtCampoMonetario_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectionStart =
                (sender as TextBox).Text.Length;
        }
        //tratamento especial para campos monetários, para que o cursor de digitação 
        //fique sempre no final (à direita) do valor digitado quando este for clicado
        private static void txtCampoMonetario_MouseClick(object sender, MouseEventArgs e)
        {
            (sender as TextBox).SelectionStart =
                (sender as TextBox).Text.Length;
        }
        //anula a funcionalidade das teclas "Delete" e "Seta para Esquerda" em campos monetários
        private static void txtCampoMonetario_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Left))
            {
                e.Handled = true;
            }
        }
        //aplica efeito de campo monetário a um textbox
        public static void EfeitoCampoMonetario(TextBox textBox)
        {
            textBox.KeyPress += txtCampoMonetario_KeyPress;
            textBox.Enter += txtCampoMonetario_Enter;
            textBox.MouseClick += txtCampoMonetario_MouseClick;
            textBox.KeyDown += txtCampoMonetario_KeyDown;
        }
        //aplica efeito de campo numérico a um textbox
        public static void EfeitoCampoNumerico(TextBox textBox)
        {
            textBox.KeyPress += txtCampoNumerico_KeyPress;
        }
        //aplica efeito troca de cor de foco com controles de entrada de dados
        public static void EfeitoCampoComFoco(Control control)
        {
            control.Enter += CampoForm_Enter;
            control.Leave += CampoForm_Leave;
        }
    }
}
