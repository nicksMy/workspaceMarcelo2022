// Nicolas Schüssler 20/04/2022
using System;
using System.Collections.Generic;

namespace texas
{
    class Program
    {
        public enum Naipes
            {
                Espadas,
                Paus,
                Copas,
                Ouros
            }

        static void Main(string[] args)
        {   
            Random valorRandom = new Random();
            Type type = typeof(Naipes);

            Array valores = type.GetEnumValues();
            int i = valorRandom.Next(valores.Length);
            Naipes value = (Naipes)valores.GetValue(i);

            /*
            Console.WriteLine("Digite o nome do Jogador 1");
            string nomeJogador01 = Console.ReadLine();

            Console.WriteLine("Digite o nome do Jogador 2");
            string nomeJogador02 = Console.ReadLine();

            Pessoa jogador01 = new Pessoa (nomeJogador01);
            Pessoa jogador02 = new Pessoa (nomeJogador02);
            */

            Pessoa jogador01 = new Pessoa ("[NOME JOGADOR 01]");
            Pessoa jogador02 = new Pessoa ("[NOME JOGADOR 02]");

            Carta carta01 = new Carta (valorRandom.Next(1, 13), 0, $"{value}");
            Carta carta02 = new Carta (valorRandom.Next(1, 13), 0, $"{value}");
            Carta carta03 = new Carta (valorRandom.Next(1, 13), 0, $"{value}");
            Carta carta04 = new Carta (valorRandom.Next(1, 13), 0, $"{value}");
            Carta carta05 = new Carta (valorRandom.Next(1, 13), 0, $"{value}");
            Carta carta06 = new Carta (valorRandom.Next(1, 13), 0, $"{value}");
            Carta carta07 = new Carta (valorRandom.Next(1, 13), 0, $"{value}");
            Carta carta08 = new Carta (valorRandom.Next(1, 13), 0, $"{value}");
            Carta carta09 = new Carta (valorRandom.Next(1, 13), 0, $"{value}");

            carta01.setDono(1);
            carta02.setDono(1);

            carta03.setDono(0);
            carta04.setDono(0);
            carta05.setDono(0);
            carta06.setDono(0);
            carta07.setDono(0);

            carta08.setDono(2);
            carta09.setDono(2);
            //Console.WriteLine(String.Format("{0, -10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -10}", "Numero: ", carta01.getValor(), "Naipe: ", carta01.getNaipe(), "De: ", carta01.getDono()));

            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine(String.Format("{0, -10} {1, -10} {2, -10} {3, -10} {4, -10} {5, -10}", "Numero: ", carta01.getValor(), "Naipe: ", carta01.getNaipe(), "De: ", carta01.getDono()));
            }
        }
    }
}