using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TrabMaroquioAV2
{
    public class Medico
    {
        private int cRM;
        private string nomeMed;
        private Especialidade espec;
        private List<Consulta> consultas = new List<Consulta>();


        public int CRM
        {
            get { return cRM; }
            set
            {
                string c = value.ToString();
                if (c.Length != 0)
                    cRM = value;
                else
                    throw new Exception("O Médico deve ter CRM!");
            }
        }


        public string NomeMed
        {
            get { return nomeMed; }
            set
            {
                char[] n = value.ToCharArray();
                if (n.Length > 5)
                {
                    if (n.Contains(' '))
                        nomeMed = value;
                    else
                        throw new Exception("O Médico deve ter sobrenome");
                }
                else
                    throw new Exception("O Médico deve ter nome com mais de 5 caracteres");
            }
        }


        public Especialidade Espec
        {
            get { return espec; }
            set
            {
                if (value != null)
                    espec = value;
                else
                    throw new Exception("É necessário uma Especialidade");

            }
        }

        public List<Consulta> Consultas
        {
            get { return consultas; }
            set { consultas = value; }
        }


        public decimal Renda
        {
            get 
            {
                decimal valor = 0;
                foreach (Consulta c in consultas)
                    valor += c.ValorConsulta; 
                return valor; 
            }
            
        }
    }
}

