using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabMaroquioAV2
{
    public class Unidade
    {
        private string razaoSoc;
        private string cNPJ;
        private string inscricaoEst;
        private string enderecoTotal;
        private string telefone;
        private string email;

        public string RazaoSoc
        {
            get { return razaoSoc; }
            set { razaoSoc = value; }
        }
        public string CNPJ
        {
            get { return cNPJ; }
            set { cNPJ = value; }

        }
        public string InscricaoEst
        {
            get { return inscricaoEst; }
            set { inscricaoEst = value; }
        }
        public string EnderecoTotal
        {
            get { return enderecoTotal; }
            set { enderecoTotal = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
