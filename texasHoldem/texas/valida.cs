// Erica Cordeiro & Nicolas Schüssler 25/05/2022


// classe para fazer o validaçãos dospossiveis ranqueamentos
using System;
using System.Collections.Generic;
namespace texas
{
    public class Valida
    {
        private List<List<Carta>> _histo;

        // procedimento para validação para identificação High Card
        public void HighCard (List<Carta> Mao)
        {
            Carta temp = new Carta(0, 0, "");

            // loop para efetuar o teste em todas as cartas
            foreach (Carta carta in Mao)
            {
                if (carta.getValor() > temp.getValor())
                {
                    temp = carta;
                }
            }
            Console.WriteLine($"\n- - - H I G H  C A R D - - -\n\nSua maior carta é: {temp.getValor()}");
        }

        // procedimento para validação para identificação One Pair
        public void OnePair (List<Carta> Mao)
        {
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

                if (conta == 2)
                {
                    temp01 = carta;
                }
            }
            Console.WriteLine($"\n- - - O N E  P A I R - - -\n\nSeu maior par de cartas é: {temp01.getValor()}");
        }

        // procedimento para validação para identificação Two Pair
        public void TwoPair (List<Carta> Mao)
        {
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

                // caso tenha o primeiro par
                if (conta == 2 && primeiro == true)
                {
                    if (carta.getValor() != primeiroPar.getValor())
                    {
                        segundoPar = carta.getValor();
                        segundo = true;
                    }
                }

                conta = 0;
            }
            Console.WriteLine($"\n- - - T W O  P A I R - - -\n\nSeus pares de cartas são: {primeiroPar.getValor()} e {segundoPar}");
        }

        // procedimento para validação para identificação Three-of-a-Kind
        public void ThreeOfaKind (List<Carta> Mao)
        {
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

                if (conta == 3)
                {
                    temp01 = carta;
                }
            }
            Console.WriteLine($"\n- - - T H R E E  O F  A  K I N D - - -\n\nSeu trio de cartas é: {temp01.getValor()}");
        }

        // procedimento para validação para identificação Straight
        public void Straight (List<Carta> Mao)
        {
            
        }

        // procedimento para validação para identificação Flush
        public void Flush (List<Carta> Mao)
        {
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
                    if (carta.getValor() == Mao[i].getValor())
                    {
                        conta++;
                    }
                }

                if (conta == 5)
                {
                    temp01 = carta;
                }
            }
            Console.WriteLine($"\n- - - F L U S H - - -\n\nSeu quarteto de cartas é: {temp01.getValor()}");
        }

        // procedimento para validação para identificação Full House
        public void FullHouse (List<Carta> Mao)
        {
            
        }

        // procedimento para validação para identificação Four-of-a-Kind
        public void FourOfaKind (List<Carta> Mao)
        {
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

                if (conta == 4)
                {
                    temp01 = carta;
                }
            }
            Console.WriteLine($"\n- - - F O U R  O F  A  K I N D - - -\n\nSeu quarteto de cartas é: {temp01.getValor()}");
        }

        // procedimento para validação para identificação Straight Flush
        public void StraightFlush (List<Carta> Mao)
        {
            
        }

        // procedimento para validação para identificação Royal Flush
        public void RoyalFlush (List<Carta> Mao)
        {
            
        }
    }
}