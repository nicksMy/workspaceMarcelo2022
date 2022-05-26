// Erica Cordeiro & Nicolas Schüssler 20/04/2022

// classe para representar uma carta dentro do jogo
using System;
using System.Collections.Generic;

namespace texas
{
    public class Carta
    {
        // estados
        private int valor;
        private int dono;
        private string naipe;

        public Carta (int _valor, int _dono, string _naipe) // construtor
        {
            valor = _valor;
            dono = _dono;
            naipe = _naipe;
        }

        public Carta (Carta _carta)
        {
            valor = _carta.getValor();
            dono = _carta.getDono();
            naipe = _carta.getNaipe();
        }

        // set / get
        // encapsulamento

        // set
        public void setDono (int _dono)
        {
            dono = _dono;
        }

        // get
        public int getValor ()
        {
            return valor;
        }

        public int getDono ()
        {
            return dono;
        }

        public string getNaipe ()
        {
            return naipe;
        }

        public override string ToString()
        {
            string textoCarta = "Naipe: " + naipe;
            textoCarta += "\tValue: " + valor;
            textoCarta += "\tDono" + dono;
            return textoCarta;
        }
    }
}