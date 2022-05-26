// Erica Cordeiro & Nicolas Schüssler 25/05/2022

// classe para obter estrutura intermediária histograma
using System;
using System.Collections.Generic;
namespace texas
{
    public class Histograma
    {
        List<Carta> organize; // para segurar as cartas

        List<List<Carta>> histograma; // para armazenar a estruturado histograma

        public Histograma (List<Carta> cList) // construtor
        {
            organize = new List<Carta>(); // inicia a lista vazia
            foreach (var c in cList)
                organize.Add(new Carta(c)); // criação da copia das cartas

            histograma = new List<List<Carta>>(); // inicia a estrutura do histograma
            for (int i = 0; i < 14; i++)  // inicia cada lista em estrutura do histograma
            {
                histograma.Add(new List<Carta>());
            }
        }

        // procedimento para qualificação do rank e pocisionamento da carta na lista
        public void contaValores ()
        {
            // cada carta na lista é adicionada nas listas de acordo com seu valor
            for (int i = 0; i < organize.Count; i++)
            {
                int valor = organize[i].getValor();
                histograma[valor].Add(new Carta(organize[i]));
            }
        }

        // set / get
        // encapsulamento

        // get
        public List<List<Carta>> getHistograma () 
        {
            return histograma;
        }

        public List<Carta> getOrganize ()
        {
            return organize;
        }
    }
}