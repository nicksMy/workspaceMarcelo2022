// Erica Cordeiro & Nicolas Schüssler 15/06/2022

// classe para efetuar a organização como um jogo
using System;
using System.Collections.Generic;

namespace texas
{
    public class Jogo
    {
        // estados
        private Crupie crupie;
        private Pessoa p1;
        private Pessoa p2;

        // construtor
        public Jogo ()
        {
            crupie = new Crupie();
            p1 = new Pessoa("P1");
            p2 = new Pessoa("P2");
        }
        
        public void Inicio ()
        {
            crupie.criarCartas();
            crupie.embaralhar();
            crupie.setDeck();

            Carta carta = new Carta(crupie.getCarta());
            carta.setDono(0);
            p1.setCarta(carta);
            
            carta = new Carta(crupie.getCarta());
            carta.setDono(0);
            p2.setCarta(carta);

            carta = new Carta(crupie.getCarta());
            carta.setDono(0);
            p1.setCarta(carta);

            carta = new Carta(crupie.getCarta());
            carta.setDono(0);
            p2.setCarta(carta);

            crupie.setMesa();
        }

        public void mostraJogo()
        {
            Mostra.mostraJogo(crupie, p1, p2);
        }

        public void avaliajogo()
        {
            Console.WriteLine("IMPLEMENTAR AQUI");
            Console.WriteLine("Aperte qualquer tecla para continuar");
        }
    }
}