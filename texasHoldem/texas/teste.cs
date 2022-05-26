// Erica Cordeiro & Nicolas Schüssler 25/05/2022

// classe para rodar os testes de reconhecimento das cartas
using System;
using System.Collections.Generic;
namespace texas
{
    public class Teste
    {
        // estados
        private List<Carta> listaCarta;

        public Teste () // construtor
        {
            listaCarta = new List<Carta>();
        }

        // set / get
        // encapsulamento

        // get
        public List<Carta> getCartas ()
        {
            return listaCarta;
        }

        // puxa metodo da classe load
        public void carregaCartas ()
        {
            listaCarta = Carrega.carregaMao();
        }
    }
}