// Erica Cordeiro & Nicolas Schüssler 15/06/2022

// classe para efetuar a organização como um jogo
using System;
using System.Linq;
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

            List<Carta> tempMaoCompletaP1 = new List<Carta>();
            List<Carta> tempMaoCompletaP2 = new List<Carta>();

            // adição da mão do jogador com sua respectiva lista
            tempMaoP1 = p1.getMao();
            tempMaoP2 = p2.getMao();

            // criação de um novo objeto Valida para efetuar os ranqueamentos implementados
            Valida validaRank = new Valida();

            // concatenação da mão do jogador com as cartas da mesa na lista temporaria
            tempMaoCompletaP1 = crupie.getMesa().Concat(tempMaoP1).ToList();
            tempMaoCompletaP2 = crupie.getMesa().Concat(tempMaoP2).ToList();

            // definição de variaveis para armazenar as pontuações dos jogadores
            int pontuacaoP1 = 0;
            int pontuacaoP2 = 0;

            // debug
            //foreach(Carta c in tempMaoCompletaP1) {Console.WriteLine($"cartas da mao e da mesa P1: {c.getValor()} {c.getNaipe()}");}
            //Console.WriteLine("\n-----------------------------------------------------\n");
            //foreach(Carta c in tempMaoCompletaP2) {Console.WriteLine($"cartas da mao e da mesa P2: {c.getValor()} {c.getNaipe()}");}

            // validações para o jogador número 1
            pontuacaoP1 = validaRank.FourOfaKind(tempMaoCompletaP1);
            if (pontuacaoP1 == 0) {pontuacaoP1 = validaRank.FullHouse(tempMaoCompletaP1);}
            if (pontuacaoP1 == 0) {pontuacaoP1 = validaRank.Flush(tempMaoCompletaP1);}
            if (pontuacaoP1 == 0) {pontuacaoP1 = validaRank.ThreeOfaKind(tempMaoCompletaP1);}
            if (pontuacaoP1 == 0) {pontuacaoP1 = validaRank.TwoPair(tempMaoCompletaP1);}
            if (pontuacaoP1 == 0) {pontuacaoP1 = validaRank.OnePair(tempMaoCompletaP1);}
            if (pontuacaoP1 == 0) {pontuacaoP1 = validaRank.HighCard(tempMaoCompletaP1);}

            // validações para o jogador número 2
            pontuacaoP2 = validaRank.FourOfaKind(tempMaoCompletaP2);
            if (pontuacaoP2 == 0) {pontuacaoP2 = validaRank.FullHouse(tempMaoCompletaP2);}
            if (pontuacaoP2 == 0) {pontuacaoP2 = validaRank.Flush(tempMaoCompletaP2);}
            if (pontuacaoP2 == 0) {pontuacaoP2 = validaRank.ThreeOfaKind(tempMaoCompletaP2);}
            if (pontuacaoP2 == 0) {pontuacaoP2 = validaRank.TwoPair(tempMaoCompletaP2);}
            if (pontuacaoP2 == 0) {pontuacaoP2 = validaRank.OnePair(tempMaoCompletaP2);}
            if (pontuacaoP2 == 0) {pontuacaoP2 = validaRank.HighCard(tempMaoCompletaP2);}

            // validações afirmar quem ganhou
            if (pontuacaoP1 > pontuacaoP2) {Console.WriteLine("O Jogador 1 venceu!");}
            if (pontuacaoP1 < pontuacaoP2) {Console.WriteLine("O Jogador 2 venceu!");}
            if (pontuacaoP1 == pontuacaoP2) {Console.WriteLine("Empate!");}
            
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}