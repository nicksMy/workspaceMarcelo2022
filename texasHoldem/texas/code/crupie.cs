// Erica Cordeiro & Nicolas Schüssler 27/04/2022

// classe para representar o crupie vulgo quem dirige a mesa de jogo
using System;
using System.Collections.Generic;

namespace texas.code
{
    public class Crupie
    {
        // estado
        private List<Carta> listaCartas;
        private Stack<Carta> deck;
        private List<Carta> mesa;

        // construtor
        public Crupie ()
        {
            listaCartas = new List<Carta>();
            deck = new Stack<Carta>();
            mesa = new List<Carta>();
        }

        // procedimento para criação das cartas
        public void criarCartas ()
        {
            for (int i = 0; i < 13; i++)
            {
                // criações de objetos Carta
                Carta carta01 = new Carta((i + 1), 1, "Hearts");
                Carta carta02 = new Carta((i + 1), 1, "Diamonds");
                Carta carta03 = new Carta((i + 1), 1, "Clubs");
                Carta carta04 = new Carta((i + 1), 1, "Spades");

                // adição das cartas criadas para a lista das mesmas
                listaCartas.Add(carta01);
                listaCartas.Add(carta02);
                listaCartas.Add(carta03);
                listaCartas.Add(carta04);
            }
        }
        
        // procediemtno para embaralhamento das cartas geradas
        public void embaralhar ()
        {
            // criação de um novo objeto Random
            Random ran = new Random();

            // laço de loop para embaralhar com todas as cartas dentro da lista de cartas
            for (int i = listaCartas.Count - 1; i > 0; i--)
            {
                int j =  ran.Next(0, i + 1);

                // criação de um novo objeto Carta para utilização temporaria
                Carta temp = new Carta(listaCartas[i]);

                // sistema para aleatorizar as cartas entre si
                listaCartas[i] = listaCartas[j];
                listaCartas[j] = temp;
            }
        }
        
        // set / get
        // encapsulamento

        // set
        public void setDeck ()
        {
            // botando cartas da lista de cartas no deck
            for (int i = 0; i < listaCartas.Count; i++)
            {
                deck.Push(listaCartas[i]);
            }
        }

        public void setMesa ()
        {
            // botando 5 cartas do deck na mesa
            for (int i = 0; i < 5; i++)
            {
                mesa.Add(deck.Pop());
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

        public List<Carta> getMesa ()
        {
            return mesa;
        }
    }
}