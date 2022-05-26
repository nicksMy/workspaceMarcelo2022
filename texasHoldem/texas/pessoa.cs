// Erica Cordeiro & Nicolas Schüssler 20/04/2022

// classe para representar um jogador no simulador
using System;
using System.Collections.Generic;

namespace texas
{
    public class Pessoa
    {
        // estados
        private string nome;
        private List<Carta> mao;

        public Pessoa (string _nome) // construtor
        {
            nome = _nome;
            mao = new List<Carta>();
        }

        // set / get
        // encapsulamento

        // set
        public void setCart (Carta _carta)
        {
            mao.Add(_carta);
        }

        // get
        public string getNome ()
        {
            return nome;
        }

        public List<Carta> getMao ()
        {
            return mao;
        }
    }
}