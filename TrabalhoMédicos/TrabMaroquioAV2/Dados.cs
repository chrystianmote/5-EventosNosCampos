using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TrabMaroquioAV2
{
    public class Dados
    {
        public static List<Medico> TodosMedicos = new List<Medico>();
        public static List<Paciente> TodosPacientes = new List<Paciente>();
        public static List<Consulta> TodasConsultas = new List<Consulta>();
        public static List<Especialidade> TodasEspecialidades = new List<Especialidade>();
        public static List<Doenca> TodasDoencas = new List<Doenca>();
        public static List<Unidade> TodUnidadesSaude = new List<Unidade>();

        public static void LoadingTudo() 
        {
            LoadingEspecialidade();
            LoadingDoencas();
            LoadingMedico();
            LoadingPaciente();
            Loading_UnidadesdeSaude();
            LoadingConsulta();
            
        }

        public static void EscreverTudo()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Especialidades.txt"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "Especialidades.txt");
            
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Medicos.txt"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "Medicos.txt");

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Pacientes.txt"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "Pacientes.txt");

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Consultas.txt"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "Consultas.txt");

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Unidades.txt"))
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "Unidades.txt");

            EscreverEspecialidade();
            EscreverMedicos();
            EscreverPaciente();
            EscreverConsulta();
            Escrever_UnidadesdeSaude();
        }



        public static void LimparTudo()
        {
            TodosMedicos.Clear();
            TodosPacientes.Clear();
            TodasConsultas.Clear();
            TodasEspecialidades.Clear();
            TodasDoencas.Clear();
            TodUnidadesSaude.Clear();
        }

        public static void LoadingDoencas()
        {
            StreamReader src = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Doencas.txt");
            while (!src.EndOfStream)
            {
                string linha = src.ReadLine();
                string[] dados = linha.Split('|');
                Doenca d = new Doenca();
                d.Codigo = dados[0];
                d.Nome = dados[1];
                TodasDoencas.Add(d);
            }
            src.Close();
            src.Dispose();
        }

        public static void LoadingEspecialidade()
        {
            StreamReader src = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Especialidades.txt");
            while (!src.EndOfStream)
            {
                string linha = src.ReadLine();
                string[] dados = linha.Split('|');
                Especialidade e = new Especialidade();
                e.CodEsp = Convert.ToInt32(dados[0]);
                e.NomeEsp = dados[1];
                e.DescricaoEspec = dados[2];
                TodasEspecialidades.Add(e);
            }
            src.Close();
            src.Dispose();
        }
        public static void EscreverEspecialidade()
        {
            StreamWriter swv = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Especialidades.txt");
            foreach (Especialidade e in TodasEspecialidades)
            {
                swv.WriteLine("{0}|{1}|{2}",
                    e.CodEsp.ToString(),
                    e.NomeEsp.ToString(),
                    e.DescricaoEspec.ToString());
            }
            swv.Close();
        }

        public static void LoadingMedico()
        {
            StreamReader src = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Medicos.txt");
            while (!src.EndOfStream)
            {
                string linha = src.ReadLine();
                string[] dados = linha.Split('|');
                Medico m = new Medico();
                m.CRM = Convert.ToInt32(dados[0]);
                m.NomeMed = dados[1];
                m.Consultas = new List<Consulta>();
                m.Espec = Pesquisar(dados[2], TodasEspecialidades);
                m.Espec.MedVinculados.Add(m);
                TodosMedicos.Add(m);
            }
            src.Close();
            src.Dispose();
        }

        public static void EscreverMedicos()
        {
            StreamWriter swv = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Medicos.txt");
            foreach (Medico m in TodosMedicos)
            {
                swv.WriteLine("{0}|{1}|{2}",
                    m.CRM.ToString(),
                    m.NomeMed,
                    m.Espec.CodEsp.ToString());
            }
            swv.Close();

        }

        public static void LoadingPaciente()
        {
            StreamReader src = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Pacientes.txt");
            while (!src.EndOfStream)
            {
                string linha = src.ReadLine();
                string[] dados = linha.Split('|');
                Paciente p = new Paciente();
                p.CPF = Convert.ToInt64(dados[0]);
                p.NomePac = dados[1];
                p.Email = dados[2];
                p.Telefone = dados[3];
                p.Endereco = dados[4];
                p.Consultas = new List<Consulta>();
                TodosPacientes.Add(p);
            }
            src.Close();
            src.Dispose();
        }
        public static void EscreverPaciente()
        {
            StreamWriter swv = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Pacientes.txt");
            foreach (Paciente p in TodosPacientes)
            {
                swv.WriteLine("{0}|{1}|{2}|{3}|{4}",
                    p.CPF.ToString(),
                    p.NomePac,
                    p.Email,
                    p.Telefone,
                    p.Endereco);
            }
            swv.Close();
        }

        public static void LoadingConsulta()
        {
            StreamReader src = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Consultas.txt");
            while (!src.EndOfStream)
            {
                string linha = src.ReadLine();
                string[] dados = linha.Split('|');
                Consulta c = new Consulta();
                c.Medico = Pesquisar(dados[0], TodosMedicos);
                c.Medico.Consultas.Add(c);
                c.Paciente = Pesquisar(dados[1], TodosPacientes);
                c.Paciente.Consultas.Add(c);
                c.Doenca = Pesquisar(dados[2], TodasDoencas);
                c.HoraConsulta = Convert.ToDateTime(dados[3]);
                c.ValorConsulta = Convert.ToDecimal(dados[4]);
                c.Consultorio = Pesquisar(dados[5], TodUnidadesSaude);
                c.Descricao = dados[6];
                TodasConsultas.Add(c);
            }
            src.Close();
            src.Dispose();
        }
        public static void EscreverConsulta()
        {
            StreamWriter swv = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Consultas.txt");
            foreach (Consulta c in TodasConsultas)
            {
                swv.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}",
                    c.Medico.CRM.ToString(),
                    c.Paciente.NomePac,
                    c.Doenca.Codigo,
                    c.HoraConsulta.ToShortDateString(),
                    c.ValorConsulta.ToString(),
                    c.Consultorio.CNPJ,
                    c.Descricao);
            }
            swv.Close();
        }

        public static void Loading_UnidadesdeSaude()
        {
            StreamReader src = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Unidades.txt");
            while (!src.EndOfStream)
            {
                string linha = src.ReadLine();
                string[] dados = linha.Split('|');
                Unidade uni = new Unidade();
                uni.CNPJ = dados[0];
                uni.InscricaoEst = dados[1];
                uni.RazaoSoc = dados[2];
                uni.Telefone = dados[3];
                uni.Email = dados[4];
                uni.EnderecoTotal = dados[5];
                TodUnidadesSaude.Add(uni);
            }
            src.Close();
            src.Dispose();
        }
        public static void Escrever_UnidadesdeSaude()
        {
            StreamWriter swv = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Unidades.txt");
            foreach (Unidade uni in TodUnidadesSaude)
            {
                swv.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}",
                    uni.CNPJ,
                    uni.InscricaoEst,
                    uni.RazaoSoc,
                    uni.Telefone,
                   uni.Email,
                   uni.EnderecoTotal);
            }
            swv.Close();
        }




        public static Especialidade Pesquisar(string nomecod, List<Especialidade> LE)
        {
            int cod = 0;
            if (int.TryParse(nomecod, out cod))
            {
                foreach (Especialidade es in LE)
                {
                    if (es.CodEsp == cod)
                        return es;
                }
            }
            else
            {
                foreach (Especialidade espec in LE)
                {
                    if (nomecod.ToUpper() == espec.NomeEsp.ToUpper())
                        return espec;
                }
            }
            return null;
        }

        public static Paciente Pesquisar(string nomecod, List<Paciente> LP)
        {
            long cod = 0;
            if (long.TryParse(nomecod, out cod))
            {
                foreach (Paciente p in LP)
                {
                    if (p.CPF == cod)
                        return p;
                }
            }
            else
            {
                foreach (Paciente pa in LP)
                {
                    if (nomecod.ToUpper() == pa.NomePac.ToUpper())
                        return pa;
                }
            }
            return null;
        }

        public static Medico Pesquisar(string nomecod, List<Medico> LM)
        {
            int cod = 0;
            if (int.TryParse(nomecod, out cod))
            {
                foreach (Medico m in LM)
                {
                    if (m.CRM == cod)
                        return m;
                }
            }
            else
            {
                foreach (Medico md in LM)
                {
                    if (nomecod.ToUpper() == md.NomeMed.ToUpper())
                        return md;
                }
            }
            return null;
        }
        public static Doenca Pesquisar(string nomecod, List<Doenca> LD)
        {
            foreach (Doenca d in LD)
            {
                if (nomecod.ToUpper() == d.Codigo.ToUpper())
                    return d;
            }
            return null;
        }

        public static Unidade Pesquisar(string nomecod, List<Unidade> LUS)
        {
            foreach (Unidade u in LUS)
            {
                if ((nomecod.ToUpper() == u.CNPJ.ToUpper())||(nomecod.ToUpper() == u.RazaoSoc.ToUpper()))
                    return u;
            }
            return null;
        }

    }
}
