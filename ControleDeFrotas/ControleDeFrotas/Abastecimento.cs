using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ControleDeFrotas
{
    public class Abastecimento
    {
        //propriedades
        public string Placa { get; set; }
        public DateTime Data { get; set; }
        public string Combustivel { get; set; }
        public double Litros { get; set; }
        public double PrecoLitro { get; set; }
        public double KmAtual { get; set; }
        //lista estática para armazenar objetos dessa classe
        public static List<Abastecimento> Lista = new List<Abastecimento>();
        //método para gravar a lista em um arquivo texto chamado
        //Abastecimentos.dat, criado no mesmo diretório da aplicação
        public static void PersistirLista()
        {
            //monta o caminho do arquivo a ser criado ou sobrescrito
            string caminhoArquivo = AppDomain.CurrentDomain.BaseDirectory +
                "Abastecimentos.dat";
            //cria um objeto de escrita em arquivo texto
            StreamWriter sw = new StreamWriter(caminhoArquivo);
            //para cada item da lista de objetos
            foreach (var item in Abastecimento.Lista)
            {
                //escreve uma linha no arquivo com os valores de suas
                //propriedades separados pelo caractere '|', ou seja, 
                //o arquivo terá 1 objeto por linha
                sw.WriteLine(
                    string.Format("{0}|{1}|{2}|{3}|{4}|{5}",
                    item.Placa, item.Data, item.Combustivel,
                    item.Litros, item.PrecoLitro, item.KmAtual));
            }
            //fecha o arquivo criado ou sobrescrito
            sw.Close();
        }

        //método para gravar a lista em um arquivo texto chamado
        //Veiculos.dat, criado no mesmo diretório da aplicação
        public static void CarregarLista()
        {
            //monta o caminho do arquivo a ser criado ou sobrescrito
            string caminhoArquivo = AppDomain.CurrentDomain.BaseDirectory +
                "Abastecimentos.dat";
            //verifica se o arquivo de persistência existe antes de carregá-lo
            if (File.Exists(caminhoArquivo))
            {
                //limpa a lista estática de objetos do tipo Abastecimento
                Abastecimento.Lista.Clear();
                //cria um objeto de leitura de arquivos texto
                StreamReader sr = new StreamReader(caminhoArquivo);
                //enquanto não chegar ao fim do arquivo (última linha)
                while (!sr.EndOfStream)
                {
                    //lê uma linha de texto do arquivo
                    string linha = sr.ReadLine();
                    //cria um vetor com os dados da linha lida, dividindo-a
                    //no caractere '|', conforme foi gravado na persistência
                    string[] dados = linha.Split('|');
                    //cria um novo objeto do tipo Abastecimento
                    Abastecimento abastecimento = new Abastecimento();
                    //preenche as propriedades do objeto com os valores lidos
                    //da linha atual do arquivo persistido
                    abastecimento.Placa = dados[0];
                    abastecimento.Data = Convert.ToDateTime(dados[1]);
                    abastecimento.Combustivel = dados[2];
                    abastecimento.Litros = Convert.ToDouble(dados[3]);
                    abastecimento.PrecoLitro = Convert.ToDouble(dados[4]);
                    abastecimento.KmAtual = Convert.ToDouble(dados[5]);
                    //adiciona o objeto criado à lista estática de abastecimentos
                    Abastecimento.Lista.Add(abastecimento);
                }
                //fecha o objeto de leitura de arquivos texto
                sr.Close();
            }
        }
    }
}
