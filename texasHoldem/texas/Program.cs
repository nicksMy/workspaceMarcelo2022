// Nicolas Schüssler 20/04/2022
using System;
using System.Collections.Generic;

namespace texas
{
    class Program
    {
        public enum Naipes
            {
                Espadas,
                Paus,
                Copas,
                Ouros
            }

        static void Main(string[] args)
        {   
            // game
            // test

            bool go = true;
            int opcao = 0;
            Console.Clear();

            while(go)
            {
                Mostra.mostraMenu();
                opcao = getOpcao();

                switch (opcao)
                {
                    case 1:
                        #region Croupie_

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

                        #endregion

                        #region Test
                        /*
                        testar novo objeto
                        carregar a partir do arquivo
                        mostrar a lista de cartas

                        construir o histograma de cartas
                        */
                        #endregion
                        break;

                    case 2:
                        Console.WriteLine("Jogo não ainda não implementado");
                        Console.WriteLine("Aperte qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }
                Mostra.mostraReiniciar();
                opcao = getOpcao();

                // <true or false> ? <caso seja true> : <caso seja false>
                go = opcao == 2 ? false : true; 
            }
        }
        public static int getOpcao()
        {
            int opt = 0;
            while (true)
            {
                Int32.TryParse(Console.ReadLine(), out opt);

                if (opt >= 1 && opt <= 2)
                    break;
                else
                    Console.WriteLine("Opções validas: 1 ou 2");
            }
            return opt;
        }
    }
}