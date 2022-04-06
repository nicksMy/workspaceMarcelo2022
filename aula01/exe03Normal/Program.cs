// Nicolas Schüssler 30/03/2022
using System;

namespace exe03Normal
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0, inverso = 0, resultado = 0;

            Console.WriteLine("Digite um número qualquer: ");
            valor = Convert.ToDouble(Console.ReadLine());

            inverso = 1 / valor;
            resultado = valor * (inverso * inverso);

            Console.WriteLine("Seu número multiplicado pelo quadrado do seu inverso é: " + resultado);
        }
    }
}
