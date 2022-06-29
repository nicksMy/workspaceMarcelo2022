// Erica Cordeiro & Nicolas Schüssler 18/05/2022

// classe para efetuar a leitura do arquivo de texto para teste
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace texas.code
{
    public class Carrega
    {
        // função solicitando o nome do arquivo
        public static List<Carta> carregaMao()
        {
            // criação de lista
            List<Carta> cartas = new List<Carta>();
            string pathFile = Directory.GetCurrentDirectory();
            
            // mensagem para inserir o nome do arquivo desejado para carregar e ser usado em futuro teste
            Console.WriteLine("\nDigite o nome do arquivo");

            // adição do caminho para carregamento dos arquivos texto para teste
            // posterior leitura e adição do arquivo texto
            pathFile += "\\arquivoCartas\\";
            pathFile += Console.ReadLine();

            string[] leTexto = File.ReadAllLines(pathFile);

            // para cada linha de texto lida
            foreach(var s in leTexto)
            {
                string[] linha = s.Split(';');
                {
                    // criação de um novo objeto Carta
                    Carta carta = new Carta
                    (
                        int.Parse(linha[0]),
                        int.Parse(linha[1]),
                        linha[2]
                    );
                    cartas.Add(carta);
                }
            }
            return cartas;
        }
    }
}