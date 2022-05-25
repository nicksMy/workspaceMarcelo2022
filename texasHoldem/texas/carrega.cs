// Nicolas Schüssler 18/05/2022
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Collections.IEnumerable;

namespace texas
{
    public class Carrega
    {
        public static List<Carta> carregaMao()
        {
            List<Carta> cartas = new List<Carta>();
            string pathFile = Directory.GetCurrentDirectory();
            
            Console.WriteLine("\nDigite o nome do arquivo");
            
            pathFile += "\\arquivoCartas";
            pathFile += Console.ReadLine();

            string[] leTexto = File.ReadAllLines(pathFile);

            foreach(var s in leTexto)
            {
                string[] linha = s.Split(';');
                {
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