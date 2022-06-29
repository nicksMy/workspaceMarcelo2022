// Erica Cordeiro & Nicolas Schüssler 11/05/2022

// classe para exibir menus e dados na tela
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace texas.code
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

        // exibir input dos jogadores
        // mostrar a mesa e as mãos
        public static void mostraJogo (Crupie c, Pessoa p1, Pessoa p2)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("JOGO");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Nome do jogador 1 (P1): " + p1.getNome());
            foreach (var carta in p1.getMao())
            {
                Console.WriteLine(carta.ToString());
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Cartas da mesa: ");
            foreach (var carta in c.getMesa())
            {
                Console.WriteLine(carta.ToString());
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Nome do jogador 2 (P2): " + p2.getNome());
            foreach (var carta in p2.getMao())
            {
                Console.WriteLine(carta.ToString());
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.WriteLine("-----------------------------------------------------");
            Console.ReadKey();
        }
    }
}