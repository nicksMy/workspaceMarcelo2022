// Nicolas Schüssler 27/04/2022
using System;
using System.Collections.Generic;

namespace texas
{
    public class Crupie
    {
        // estado
        private List<Carta> listaCartas = new List<Carta>();
        private Stack<Carta> deck = new Stack<Carta>();

        public Crupie () // construtor
        {

        }

        public void criarCartas ()
        {
            
        }
        public void embaralhar (int []arr, int n)
        {
            Random r = new Random();

            for (int i = n - 1; i > 0; i--)
            {
                int j =  r.Next(0, i + 1);

                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // set / get
        // encapsulamento

        // get
        public void getCarta ()
        {
            
        }
    }
}