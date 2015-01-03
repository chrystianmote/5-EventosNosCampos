using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TrabMaroquioAV2
{
    public class Doenca
    {
        private string codigo;
        private string nome;

        public string Codigo
        {
            get { return codigo; }
            set
            {
                if ((value.Length == 3) || (value.Length == 5))
                    codigo = value;
                else
                    throw new Exception("Código de Doença Inválido!");
            }
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length != 0)
                    nome = value;
                else
                    throw new Exception("Insira um Nome");
            }
        }
    }

}
