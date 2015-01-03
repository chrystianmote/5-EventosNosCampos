using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabMaroquioAV2
{
    public class Consulta
    {
        private Medico medico;
        private Paciente paciente;
        private DateTime horaConsulta;
        private Doenca doenca;
        private Unidade consultorio; 
        private decimal valorConsulta;
        private string descricao;


        public Medico Medico
        {
            get { return medico; }
            set
            {
                if (value != null)
                    medico = value;
                else
                    throw new Exception("Inserir Médico Consultado");

            }
        }


        public Paciente Paciente
        {
            get { return paciente; }
            set
            {

                if (value != null)
                    paciente = value;
                else
                    throw new Exception("Inserir Paciente na Consulta");
            }
        }


        public DateTime HoraConsulta
        {
            get { return horaConsulta; }
            set
            {
                if (value != null)
                    horaConsulta = value;
                else
                    throw new Exception("Horário Inválido");
            }
        }


        public decimal ValorConsulta
        {
            get { return valorConsulta; }
            set
            {
                if (value >= 0)
                    valorConsulta = value;
                else
                    throw new Exception("Valor de consulta Inválido");
            }
        }

        public Doenca Doenca
        {
            get { return doenca; }
            set
            {
                if (value != null)
                    doenca = value;
                else
                    throw new Exception("Cite algum Problema de Saúde");

            }
        }

        public Unidade Consultorio
        {
            get { return consultorio; }
            set
            {
                if (value != null)
                    consultorio = value;
                else
                    throw new Exception("Local de Consulta deve ser Indicado!");

            }
        }

        public string Descricao
        {
            get { return descricao; }
            set
            {
                if (value.Length != 0)
                    descricao = value;
                else
                    throw new Exception("Digite alguma Descrição!");
            }
        }
    }
}
