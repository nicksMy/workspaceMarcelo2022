// Erica Cordeiro & Nicolas Schüssler 25/05/2022

// classe para fazer o validaçãos dospossiveis ranqueamentos
using System;
using System.Collections.Generic;

namespace texas.code
{
    public class Valida
    {
        /*
        public enum pontuacaoMao : int
        {
            HIGHCARD = 1,
            ONEPAIR = 2,
            TWOPAIR = 3,
            THREEOFAKIND = 4,
            STRAIGHT = 5,
            FLUSH = 6,
            FULLHOUSE = 7,
            FOUROFAKIND = 8,
            STRAIGHTFLUSH = 9,
            ROYALFLUSH = 10
        }
        */
        private List<List<Carta>> _histo;

        //###### ------------------------------------------------------------------------ ######

        // procedimento para validação para identificação High Card
        public int HighCard (List<Carta> Mao)
        {
            // criação de carta temporaria para efetuar a validação
            Carta temp = new Carta(0, 0, "");

            // loop para efetuar o teste em todas as cartas
            foreach (Carta carta in Mao)
            {
                if (carta.getValor() > temp.getValor())
                {
                    temp = carta;
                    Console.WriteLine($"\n- - - H I G H  C A R D - - -\n\nSua maior carta é: {temp.getValor()}");

                    // retorna o valor da pontuação correspondente a combinação
                    return 1;
                }
            }
            // retorna zero quando não identificado na combinação
            return 0;
        }

        //###### ------------------------------------------------------------------------ ######

        // procedimento para validação para identificação One Pair
        public int OnePair (List<Carta> Mao)
        {
            // criação de carta temporaria para efetuar a validação
            Carta temp01 = new Carta(0, 0, "");
            Carta temp02 = new Carta(0, 0, "");
            int conta = 0;

            // loop para efetuar o teste em todas as cartas
            foreach (Carta carta in Mao)
            {   
                // laço para contar o valor das cartas
                for (int i = 0; i < Mao.Count; i++)
                {
                    if (carta.getValor() == Mao[i].getValor())
                    {
                        conta++;
                    }
                }

                // caso tenha encontrado duas cartas com o valor igual armazena a carta em questão
                if (conta == 2)
                {
                    temp01 = carta;
                    Console.WriteLine($"\n- - - O N E  P A I R - - -\n\nSeu maior par de cartas é: {temp01.getValor()}");

                    // retorna o valor da pontuação correspondente a combinação
                    return 2;
                }
                conta = 0;
            }
            // retorna zero quando não identificado na combinação
            return 0;
        }

        //###### ------------------------------------------------------------------------ ######

        // procedimento para validação para identificação Two Pair
        public int TwoPair (List<Carta> Mao)
        {
            // criação de carta temporaria para efetuar a validação
            Carta temp01 = new Carta(0, 0, "");
            Carta temp02 = new Carta(0, 0, "");
            Carta primeiroPar = new Carta(0, 0, "");
            
            int segundoPar = 0;
            int conta = 0;

            bool primeiro = false;
            bool segundo = false;

            // loop para efetuar o teste em todas as cartas
            foreach (Carta carta in Mao)
            {   
                // laço para contar o valor das cartas
                for (int i = 0; i < Mao.Count; i++)
                {
                    if (carta.getValor() == Mao[i].getValor())
                    {
                        conta++;
                    }
                }

                // caso não tenha o primeiro par
                if (conta == 2 && primeiro == false)
                {
                    primeiroPar = carta;
                    primeiro = true;
                }

                // variavel bool para armazenar o primeiro par
                bool par01 = conta == 2;

                // caso encontre um novo par e já tenha o primeiro par
                if (conta == 2 && primeiro == true)
                {
                    // validação para não pegar o mesmo par dentro das cartas
                    if (carta.getValor() != primeiroPar.getValor())
                    {
                        segundoPar = carta.getValor();
                        segundo = true;
                        Console.WriteLine($"\n- - - T W O  P A I R - - -\n\nSeus pares de cartas são: {primeiroPar.getValor()} e {segundoPar}");

                        // retorna o valor da pontuação correspondente a combinação
                        return 3;
                    }
                }
                conta = 0;
            }
            // retorna zero quando não identificado na combinação
            return 0;
        }

        //###### ------------------------------------------------------------------------ ######

        // procedimento para validação para identificação Three-of-a-Kind
        public int ThreeOfaKind (List<Carta> Mao)
        {
            // criação de carta temporaria para efetuar a validação
            Carta temp01 = new Carta(0, 0, "");
            Carta temp02 = new Carta(0, 0, "");
            Carta temp03 = new Carta(0, 0, "");

            int conta = 0;

            // loop para efetuar o teste em todas as cartas
            foreach (Carta carta in Mao)
            {   
                // laço para contar o valor das cartas
                for (int i = 0; i < Mao.Count; i++)
                {
                    if (carta.getValor() == Mao[i].getValor())
                    {
                        conta++;
                    }
                }

                // caso tenha encontrado três cartas com o valor igual armazena a carta em questão
                if (conta == 3)
                {
                    temp01 = carta;
                    Console.WriteLine($"\n- - - T H R E E  O F  A  K I N D - - -\n\nSeu trio de cartas é: {temp01.getValor()}");

                    // retorna o valor da pontuação correspondente a combinação
                    return 4;
                }
                conta = 0;
            }
            // retorna zero quando não identificado na combinação
            return 0;
        }

        //###### ------------------------------------------------------------------------ ######

        // procedimento para validação para identificação Straight
        public void Straight (List<Carta> Mao)
        {
            
        }

        //###### ------------------------------------------------------------------------ ######

        // procedimento para validação para identificação Flush
        public int Flush (List<Carta> Mao)
        {
            // criação de carta temporaria para efetuar a validação
            Carta temp01 = new Carta(0, 0, "");
            Carta temp02 = new Carta(0, 0, "");
            Carta temp03 = new Carta(0, 0, "");
            Carta temp04 = new Carta(0, 0, "");
            Carta temp05 = new Carta(0, 0, "");

            int conta = 0;

            // loop para efetuar o teste em todas as cartas
            foreach (Carta carta in Mao)
            {   
                // laço para contar o valor das cartas
                for (int i = 0; i < Mao.Count; i++)
                {
                    if (carta.getNaipe() == Mao[i].getNaipe())
                    {
                        conta++;
                    }
                }

                if (conta == 5)
                {
                    temp01 = carta;
                    Console.WriteLine($"\n- - - F L U S H - - -\n\nSeu naipe da sequencia de cartas é: {temp01.getNaipe()}");

                    // retorna o valor da pontuação correspondente a combinação
                    return 5;
                }
                conta = 0;
            }
            // retorna zero quando não identificado na combinação
            return 0;
        }

        //###### ------------------------------------------------------------------------ ######

        // procedimento para validação para identificação Full House
        public int FullHouse (List<Carta> Mao)
        {
            // criação de carta temporaria para efetuar a validação
            Carta temp01 = new Carta(0, 0, "");
            Carta temp02 = new Carta(0, 0, "");
            Carta primeiroPar = new Carta(0, 0, "");
            
            int conta = 0;
            int segundoPar = 0;

            bool primeiro = false;
            bool segundo = false;

            foreach (Carta carta in Mao)
            {
                for (int c = 0; c < Mao.Count; c++)
                {
                    if (carta.getValor() == Mao[c].getValor())
                    {
                        conta++;
                    }
                }

                // caso não tenha o primeiro par
                if (conta == 2 && primeiro == false)
                {
                    primeiroPar = carta;
                    primeiro = true;
                }

                bool par01 = conta == 2;

                // caso encontre um novo par e já tenha o primeiro par
                if (conta == 3 && primeiro == true)
                {
                    // validação para não pegar o mesmo par dentro das cartas
                    if (carta.getValor() != primeiroPar.getValor())
                    {
                        segundoPar = carta.getValor();
                        segundo = true;
                        Console.WriteLine($"\n- - - F U L L  H O U S E - - -\n\nSua sequencia de cartas do Full House é: {primeiroPar.getValor()} e {segundoPar}");

                        // retorna o valor da pontuação correspondente a combinação
                        return 6;
                    }
                }
                conta = 0;
            }
            // retorna zero quando não identificado na combinação
            return 0;
        }

        //###### ------------------------------------------------------------------------ ######

        // procedimento para validação para identificação Four-of-a-Kind
        public int FourOfaKind (List<Carta> Mao)
        {
            // criação de carta temporaria para efetuar a validação
            Carta temp01 = new Carta(0, 0, "");
            Carta temp02 = new Carta(0, 0, "");
            Carta temp03 = new Carta(0, 0, "");
            Carta temp04 = new Carta(0, 0, "");

            int conta = 0;

            // loop para efetuar o teste em todas as cartas
            foreach (Carta carta in Mao)
            {   
                // laço para contar o valor das cartas
                for (int i = 0; i < Mao.Count; i++)
                {
                    if (carta.getValor() == Mao[i].getValor())
                    {
                        conta++;
                    }
                }

                // caso tenha encontrado quatro cartas com o valor igual armazena a carta em questão
                if (conta == 4)
                {
                    temp01 = carta;
                    Console.WriteLine($"\n- - - F O U R  O F  A  K I N D - - -\n\nSeu quarteto de cartas é: {temp01.getValor()}");

                    // retorna o valor da pontuação correspondente a combinação
                    return 7;
                }
                conta = 0;
            }
            // retorna zero quando não identificado na combinação
            return 0;
        }

        //###### ------------------------------------------------------------------------ ######

        // procedimento para validação para identificação Straight Flush
        public void StraightFlush (List<Carta> Mao)
        {
            
        }

        //###### ------------------------------------------------------------------------ ######

        // procedimento para validação para identificação Royal Flush
        public void RoyalFlush (List<Carta> Mao)
        {
            
        }

        //###### ------------------------------------------------------------------------ ######
    }
}