using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ControleDeFrotas
{
    public class Veiculo
    {
        //propriedades
        public string Placa { get; set; }
        public int AnoAquisicao { get; set; }
        public int AnoFabricacao { get; set; }
        public int Eixos { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public string Tipo { get; set; }
        public int Capacidade { get; set; }
        //lista estática para armazenar objetos dessa classe
        public static List<Veiculo> Lista = new List<Veiculo>();
        //método para gravar a lista em um arquivo texto chamado
        //Veiculos.dat, criado no mesmo diretório da aplicação
        public static void PersistirLista()
        {
            //monta o caminho do arquivo a ser criado ou sobrescrito
            string caminhoArquivo = AppDomain.CurrentDomain.BaseDirectory +
                "Veiculos.dat";
            //cria um objeto de escrita em arquivo texto
            StreamWriter sw = new StreamWriter(caminhoArquivo);
            //para cada item da lista de objetos
            foreach (var item in Veiculo.Lista)
            {
                //escreve uma linha no arquivo com os valores de suas
                //propriedades separados pelo caractere '|', ou seja, 
                //o arquivo terá 1 objeto por linha
                sw.WriteLine(
                    string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}",
                    item.Placa, item.AnoAquisicao, item.AnoFabricacao,
                    item.Eixos, item.Modelo, item.Fabricante, item.Tipo,
                    item.Capacidade));
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
                "Veiculos.dat";
            //verifica se o arquivo de persistência existe antes de carregá-lo
            if (File.Exists(caminhoArquivo))
            {
                //limpa a lista estática de objetos do tipo Veiculo
                Veiculo.Lista.Clear();
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
                    //cria um novo objeto do tipo Veiculo
                    Veiculo veiculo = new Veiculo();
                    //preenche as propriedades do objeto com os valores lidos
                    //da linha atual do arquivo persistido
                    veiculo.Placa = dados[0];
                    veiculo.AnoAquisicao = Convert.ToInt32(dados[1]);
                    veiculo.AnoFabricacao = Convert.ToInt32(dados[2]);
                    veiculo.Eixos = Convert.ToInt32(dados[3]);
                    veiculo.Modelo = dados[4];
                    veiculo.Fabricante = dados[5];
                    veiculo.Tipo = dados[6];
                    veiculo.Capacidade = Convert.ToInt32(dados[7]);
                    //adiciona o objeto criado à lista estática de veículos
                    Veiculo.Lista.Add(veiculo);
                }
                //fecha o objeto de leitura de arquivos texto
                sr.Close();
            }
        }
    }
}