// Erica Cordeiro & Nicolas Schüssler 11/05/2022

// classe para exibir menus e dados na tela
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace texas
{
    public class Mostra
    {
        // exibir opções de modos para rodar o programa
        public static void mostraMenu ()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Testar\n2 - Jogar\n");
            Console.WriteLine("-----------------------------------------------------");
        }

        // exibir opções de modos de finalizar o programa
        public static void mostraReiniciar ()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Reiniciar\n2 - Exit\n");
            Console.WriteLine("-----------------------------------------------------");
        }

        // exibir cartas geradas pelo crupie
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

        // exibir histograma referente as cartas geradas
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