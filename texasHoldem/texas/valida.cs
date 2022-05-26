// Erica Cordeiro & Nicolas Schüssler 25/05/2022

using System;
using System.Collections.Generic;
namespace texas
{
    public class Valida
    {
        private List<List<Carta>> _histo;

        // validação para identificação Royal Flush
        public bool royalFlush (List<List<Carta>> histo)
        {
            _histo = histo;
            Console.WriteLine("texto");
            return true;
        }

        // validação para identificação Straight Flush
        public bool straightFlush (List<List<Carta>> histo)
        {
            _histo = histo;
            Console.WriteLine("texto");
            return true;
        }

        // validação para identificação Four Of a Kind
        public bool fourOfKind (List<List<Carta>> histo)
        {
            _histo = histo;
            Console.WriteLine("texto");
            return true;
        }

        // validação para identificação Full House
        public bool fullHouse (List<List<Carta>> histo)
        {
            _histo = histo;
            Console.WriteLine("texto");
            return true;
        }

        // validação para identificação Flush
        public bool flush (List<List<Carta>> histo)
        {
            _histo = histo;
            Console.WriteLine("texto");
            return true;
        }
    }
}