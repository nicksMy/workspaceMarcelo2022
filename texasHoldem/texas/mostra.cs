// Nicolas Schüssler 11/05/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace texas
{
    public class Mostra
    {
        public static void mostraMenu ()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Testar\n2 - Jogar\n");
            Console.WriteLine("-----------------------------------------------------");
        }
        public static void mostraReiniciar ()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Reiniciar\n2 - Exit\n");
            Console.WriteLine("-----------------------------------------------------");
        }

        public static void mostraCartas (List<Carta> cartas)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Apenas uma lista de cartas");
            Console.WriteLine("-----------------------------------------------------");
            foreach (var item in cartas)
            {
                string temporaria = item.ToString();
                Console.WriteLine(temporaria);
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.WriteLine("-----------------------------------------------------");
        }

        public static void mostraHistograma (List<List<Carta>> histo)
        {
            int ctrl = 0;
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Apenas uma lista de cartas");
            Console.WriteLine("-----------------------------------------------------");
            foreach (var list in histo)
            {
                if (list.Count == 0)
                    Console.WriteLine($"Cartas no index: {ctrl} - 0");
                else
                {
                    Console.WriteLine($"Cartas no index: {ctrl}");
                    for (int i = 0; i < list.Count; i++)
                        Console.WriteLine("\t" + list[i].ToString());
                }
                ctrl++;
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.WriteLine("-----------------------------------------------------");
            Console.ReadKey();
        }
    }
}