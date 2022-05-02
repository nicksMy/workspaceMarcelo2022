// Nicolas Schüssler 15/04/2022 
// netcoreapp3.1
using System;
using System.Collections.Generic;

namespace texas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random valorRandom = new Random();

            Queue<int> listaNum = new Queue<int>();
            listaNum.Enqueue(valorRandom.Next(1, 13));
            listaNum.Enqueue(valorRandom.Next(1, 13));
            listaNum.Enqueue(valorRandom.Next(1, 13));
            listaNum.Enqueue(valorRandom.Next(1, 13));
            listaNum.Enqueue(valorRandom.Next(1, 13));
            listaNum.Enqueue(valorRandom.Next(1, 13));
            listaNum.Enqueue(valorRandom.Next(1, 13));
            listaNum.Enqueue(valorRandom.Next(1, 13));
            listaNum.Enqueue(valorRandom.Next(1, 13));

            Queue<int> listaNaipe = new Queue<int>();
            listaNaipe.Enqueue(valorRandom.Next(1,4));
            listaNaipe.Enqueue(valorRandom.Next(1,4));
            listaNaipe.Enqueue(valorRandom.Next(1,4));
            listaNaipe.Enqueue(valorRandom.Next(1,4));
            listaNaipe.Enqueue(valorRandom.Next(1,4));
            listaNaipe.Enqueue(valorRandom.Next(1,4));
            listaNaipe.Enqueue(valorRandom.Next(1,4));
            listaNaipe.Enqueue(valorRandom.Next(1,4));
            listaNaipe.Enqueue(valorRandom.Next(1,4));
            
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine(String.Format("{0, -10}  {1, -10} {2, -10} {3, -10}", "Cartas do Jogador 1: ", listaNum.Dequeue(), "Naipe: ", listaNaipe.Dequeue()));
            Console.WriteLine(String.Format("{0, -10}  {1, -10} {2, -10} {3, -10}", "Cartas do Jogador 1: ", listaNum.Dequeue(), "Naipe: ", listaNaipe.Dequeue()));

            Console.WriteLine(String.Format("\n{0, -21}  {1, -10} {2, -10} {3, -10}", "Cartas do Dealer: ", listaNum.Dequeue(), "Naipe: ", listaNaipe.Dequeue()));
            Console.WriteLine(String.Format("{0, -21}  {1, -10} {2, -10} {3, -10}", "Cartas do Dealer: ", listaNum.Dequeue(), "Naipe: ", listaNaipe.Dequeue()));
            Console.WriteLine(String.Format("{0, -21}  {1, -10} {2, -10} {3, -10}", "Cartas do Dealer: ", listaNum.Dequeue(), "Naipe: ", listaNaipe.Dequeue()));
            Console.WriteLine(String.Format("{0, -21}  {1, -10} {2, -10} {3, -10}", "Cartas do Dealer: ", listaNum.Dequeue(), "Naipe: ", listaNaipe.Dequeue()));
            Console.WriteLine(String.Format("{0, -21}  {1, -10} {2, -10} {3, -10}", "Cartas do Dealer: ", listaNum.Dequeue(), "Naipe: ", listaNaipe.Dequeue()));

            Console.WriteLine(String.Format("\n{0, -10}  {1, -10} {2, -10} {3, -10}", "Cartas do Jogador 2: ", listaNum.Dequeue(), "Naipe: ", listaNaipe.Dequeue()));
            Console.WriteLine(String.Format("{0, -10}  {1, -10} {2, -10} {3, -10}", "Cartas do Jogador 2: ", listaNum.Dequeue(), "Naipe: ", listaNaipe.Dequeue()));
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
    }
}
    