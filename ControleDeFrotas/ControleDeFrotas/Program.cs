using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControleDeFrotas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //carrega os dados persistidos em arquivo
            Veiculo.CarregarLista();            
            Abastecimento.CarregarLista();
            Application.Run(new FormPrincipal());            
        }
    }
}
