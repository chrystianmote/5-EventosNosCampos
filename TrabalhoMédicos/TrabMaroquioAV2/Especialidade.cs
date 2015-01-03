using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabMaroquioAV2
{
    public class Especialidade
    {
        private int codEsp;
        private string nomeEsp;
        private string descricaoEspec;
        private List<Medico> medVinculados = new List<Medico>();

        public List<Medico> MedVinculados
        {
            get { return medVinculados; }
            set { medVinculados = value; }
        }

        public int CodEsp
        {
            get { return codEsp; }
            set
            {
                if (value > 0)
                    codEsp = value;
                else
                    throw new Exception("Erro de Código!");
            }
        }

        public string NomeEsp
        {
            get { return nomeEsp; }
            set
            {
                if (value.Length != 0)
                    nomeEsp = value;
                else
                    throw new Exception("Insira uma Especialidade");
            }
        }


        public string DescricaoEspec
        {
            get { return descricaoEspec; }
            set
            {
                if (value.Length != 0)
                    descricaoEspec = value;
                else
                    throw new Exception("Digite alguma Descrição!");
            }
        }
    }
}
