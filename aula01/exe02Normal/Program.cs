// Nicolas Schüssler 30/03/2022
using System;

namespace exe02Normal
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0, peso = 0, media = 0;

            double valorTemp = 0, pesoTemp = 0; // temp = temporada

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Digite um número inteiro: ");
                valorTemp = double.Parse(Console.ReadLine());
                pesoTemp = i + 1;

                soma = soma + (valorTemp * pesoTemp);
                peso = peso + pesoTemp;
            }

            media = soma / peso;
            Console.WriteLine("Sua média é: " + media);
        }
    }
}
