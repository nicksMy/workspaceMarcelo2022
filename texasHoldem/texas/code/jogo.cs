// Erica Cordeiro & Nicolas Schüssler 15/06/2022

// classe para efetuar a organização como um jogo
using System;
using System.Collections.Generic;

namespace texas.code
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
            // criação dos objetos pertencentes a uma partida do jogo
            crupie = new Crupie();
            p1 = new Pessoa("P1");
            p2 = new Pessoa("P2");
        }
        
        public void Inicio ()
        {
            // ações do objeto crupie
            crupie.criarCartas();
            crupie.embaralhar();
            crupie.setDeck();

            // criação dos novos objetos Carta para cada jogador, tirados apartir do deck feito pelo Crupie
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

            // pós criação das cartas dos jogadores setado as cartas da mesa
            crupie.setMesa();
        }

        // procedimento para exibição de todas as cartas geradas
        public void mostraJogo()
        {
            Mostra.mostraJogo(crupie, p1, p2);
        }

        // procedimento para a avaliação do jogo, quem ganhou e quem perdeu ou se houve empate
        public void avaliajogo()
        {
            // criação de lista da mão para uso temporario
            List<Carta> tempMaoP1 = new List<Carta>();
            List<Carta> tempMaoP2 = new List<Carta>();

            // adição da mão do jogador com sua respectiva lista
            tempMaoP1 = p1.getMao();
            tempMaoP2 = p2.getMao();

            // criação de um novo objeto Valida para efetuar os ranqueamentos implementados
            Valida validaRank = new Valida();

            // adição da cartas da mesa pra dentro da lista temporaria dos jogadores
            crupie.getMesa().AddRange(tempMaoP1);
            crupie.getMesa().AddRange(tempMaoP2);

            // debug
            Console.WriteLine($"cartas da mao e da mesa P1: {getCartasJogador(tempMaoP1)}");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
        }

        public List<Carta> getCartasJogador (List<Carta> _cartasJogador)
        {
            return _cartasJogador;
        }
    }
}