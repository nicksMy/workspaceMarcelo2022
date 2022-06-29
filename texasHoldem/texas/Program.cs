// Erica Cordeiro & Nicolas Schüssler 20/04/2022

// classe estabelecendo o ponto de entrada do programa
// onde é iniciado a execução do mesmo
using System;
using System.Collections.Generic;

namespace texas.code
{
    class Program
    {
        // ponto de entrada do programa
        static void Main(string[] args)
        {   
            // game test
            bool go = true;
            int opcao = 0;
            Console.Clear();

            // enquanto a opção selecionada for true
            while(go)
            {
                // mostra o menu e coleta a escolha
                Mostra.mostraMenu();
                opcao = getOpcao();

                switch (opcao)
                {
                    //### caso da opção testar ###
                    case 1:
                        //### região para criação do crupie e suas ações ###
                        #region Croupie_
                        /*
                        Crupie crupie = new Crupie();
                        crupie.criarCartas();
                        Mostra.mostraCartas(crupie.getListaCartas());

                        crupie.embaralhar();
                        crupie.setDeck();

                        for (int i = 0; i < 52; i++)
                        {
                        Carta cartaTemporaria = new Carta(crupie.getCarta());
                        Console.WriteLine(cartaTemporaria.ToString());
                        }

                        Console.ReadKey();
                        */
                        #endregion

                        //###### ------------------------------------------------------------------------ ######
                        //### região para teste com o arquivo texto utilizando o histograma ###
                        #region Test_

                        // criação de um novo objeto Teste
                        Teste teste = new Teste();
                        teste.carregaCartas();
                        Mostra.mostraCartas(teste.getCartas());

                        // criação de um novo objeto Histograma
                        Histograma histo = new Histograma(teste.getCartas());
                        histo.contaValores();
                        Mostra.mostraHistograma(histo.getHistograma());

                        // criação de um novo objeto Valida para efetuar os ranqueamentos implementados
                        Valida validaRank = new Valida();

                        // Teste para HIGH CARD
                        validaRank.HighCard(teste.getCartas());

                        // Teste para ONE PAIR
                        validaRank.OnePair(teste.getCartas());

                        // Teste para TWO PAIR
                        validaRank.TwoPair(teste.getCartas());

                        // Teste para THREE OF A KIND
                        validaRank.ThreeOfaKind(teste.getCartas());

                        // Teste para FLUSH
                        validaRank.Flush(teste.getCartas());

                        // Teste para FULL HOUSE
                        validaRank.FullHouse(teste.getCartas());

                        // Teste para FOUR OF A KIND
                        validaRank.FourOfaKind(teste.getCartas());

                        Console.ReadKey();
                        
                        //### fim da região de teste ###
                        #endregion

                        //###### ------------------------------------------------------------------------ ######

                        break;
                
                    //### caso da opção jogar ###
                    case 2:
                        // criação de um novo objeto Jogo
                        Jogo jogo = new Jogo();

                        // bloco com ações utilizando novo jogo
                        jogo.Inicio();
                        jogo.mostraJogo();
                        jogo.avaliajogo();
                        break;

                    //### caso não tenha um caso dentro das opções ###
                    default:
                        break;
                }
                // limpar console e mostrar opções de reinicialização
                Mostra.mostraReiniciar();
                opcao = getOpcao();

                // <true or false> ? <caso seja true> : <caso seja false>
                go = opcao == 2 ? false : true; 
            }
        }
        // pegar opção até que seja uma das escolhas validas
        public static int getOpcao()
        {
            int opt = 0;
            while (true)
            {   
                // leitura e armazenamento de dado pós resultado da tentativa de passar para Int32
                Int32.TryParse(Console.ReadLine(), out opt);

                if (opt >= 1 && opt <= 2) break;
                else Console.WriteLine("Opções validas: 1 ou 2");
            }
            return opt;
        }
    }
}