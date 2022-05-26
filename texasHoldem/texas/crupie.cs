// Erica Cordeiro & Nicolas Schüssler 27/04/2022

// classe para representar o crupie vulgo quem dirige a mesa de jogo
using System;
using System.Collections.Generic;

namespace texas
{
    public class Crupie
    {
        // estado
        private List<Carta> listaCartas;
        private Stack<Carta> deck ;

        public Crupie () // construtor
        {
            listaCartas = new List<Carta>();
            deck = new Stack<Carta>();
        }

        // procedimento para criação das cartas
        public void criarCartas ()
        {
            for (int i = 0; i < 13; i++)
            {
                Carta carta01 = new Carta((i + 1), 0, "Hearts");
                Carta carta02 = new Carta((i + 1), 0, "Diamonds");
                Carta carta03 = new Carta((i + 1), 0, "Clubs");
                Carta carta04 = new Carta((i + 1), 0, "Spades");

                listaCartas.Add(carta01);
                listaCartas.Add(carta02);
                listaCartas.Add(carta03);
                listaCartas.Add(carta04);
            }
        }
        
        // procediemtno para embaralhamento das cartas geradas
        public void embaralhar ()
        {
            Random ran = new Random();

            for (int i = listaCartas.Count - 1; i > 0; i--)
            {
                int j =  ran.Next(0, i + 1);

                Carta temp = new Carta(listaCartas[i]);
                listaCartas[i] = listaCartas[j];
                listaCartas[j] = temp;
            }
        }
        
        // set / get
        // encapsulamento

        // set
        public void setDeck ()
        {
            for (int i = 0; i < listaCartas.Count; i++)
            {
                deck.Push(listaCartas[i]);
            }
        }

        // get
        public List<Carta> getListaCartas ()
        {
            return listaCartas;
        }

        public Carta getCarta ()
        {
            return deck.Pop();
        }
    }
}