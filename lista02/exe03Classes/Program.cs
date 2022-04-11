// Nicolas Schüssler 11/04/2022
using System;

namespace exe03Classes
{
    class Program
    {   
        static void Main(string[] args)
        {
            // definição de variavel
            float entrada = 0;
            float inverso = 0;

            // criação do objeto
            QuadradoInverso objQuadradoInverso;
            objQuadradoInverso = new QuadradoInverso();

            // solicitação de entrada de um valor qualquer
            Console.WriteLine("Digite um valor numerico: ");
            objQuadradoInverso.setValorEntrada(Convert.ToInt32(Console.ReadLine())); // conversão e armazenamento valor de entrada do usuario 
            inverso = (1 / objQuadradoInverso.getValorEntrada()); // calculo e armazenamento do inverso do valor de entrada
            objQuadradoInverso.setResultado((objQuadradoInverso.getValorEntrada() * (inverso * inverso))); // calculo e armazenamento do quadrado do seu inverso

            // mostrar mensagem com o valor
            Console.WriteLine("Seu valor de entrada multiplicado pelo quadrado do seu inverso é: " + objQuadradoInverso.getResultado());
        }
    }
}
