using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabMaroquioAV2
{
    public class Paciente
    {
        private long cPF;
        private string endereco;
        private string nomePac;
        private string telefone;
        private string email;

        private List<Consulta> consultas = new List<Consulta>();


        public long CPF
        {
            get { return cPF; }
            set
            {
                string cpf = value.ToString();
                bool validar = false;
                if (cpf.Length == 11)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        const string v = "1234567890";
                        if (!v.Contains(cpf[i]))
                            break;
                        else
                            validar = true;
                    }
                }
                else
                    throw new Exception("CPF Inválido!");

                if (validar)
                    cPF = value;
                else
                    throw new Exception("CPF Inválido!");
            }
        }



        public string NomePac
        {
            get { return nomePac; }
            set
            {
                char[] n = value.ToCharArray();
                if (n.Length > 5)
                {
                    if (n.Contains(' '))
                        nomePac = value;
                    else
                        throw new Exception("A pessoa deve ter sobrenome");
                }
                else
                    throw new Exception("A pessoa deve ter nome com mais de 5 caracteres");
            }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public List<Consulta> Consultas
        {
            get { return consultas; }
            set { consultas = value; }

        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
