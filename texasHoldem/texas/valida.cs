// Erica Cordeiro & Nicolas Schüssler 25/05/2022

using System;
using System.Collections.Generic;
namespace texas
{
    public class Valida
    {
        private List<List<Carta>> _histo;

        // procedimento para validação para identificação High Card
        public void HighCard (List<Carta> mao)
        {
            Carta temp = new Carta(0, 0, "");

            // loop para efetuar o teste em todas as cartas
            foreach (Carta carta in mao)
            {
                if (carta.getValor() > temp.getValor())
                {
                    temp = carta;
                }
            }
            Console.WriteLine($"H I G H  C A R D\n\nSua maior carta é: {temp.getValor()}");
        }

        // procedimento para validação para identificação One Pair
        // procedimento para validação para identificação Two Pair
        // procedimento para validação para identificação Three-of-a-Kind
        // procedimento para validação para identificação Straight
        // procedimento para validação para identificação Flush
        // procedimento para validação para identificação Full House
        // procedimento para validação para identificação Four-of-a-Kind
        // procedimento para validação para identificação Straight Flush
        // procedimento para validação para identificação Royal Flush
    }
}