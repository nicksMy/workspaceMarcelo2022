// Nicolas Schüssler 30/03/2022
using System;

namespace exe01Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // definição de variavel
            string temp01 = "";
            string temp02 = "";

            // criação dos objetos
            NomeData objNomeData01;
            NomeData objNomeData02;

            objNomeData01 = new NomeData();
            objNomeData02 = new NomeData();

            // definição de variavel nome do objeto
            objNomeData01.setNome("Schüssler");
            objNomeData02.setNome("Silva");

            // definição da variavel data de nascimento do objeto
            objNomeData01.setDataNascimento("03/03/2003");
            objNomeData02.setDataNascimento("25/10/1995");

            // atribuição dos valores a variavel local
            temp01 = objNomeData01.getDataNascimento() + " " + objNomeData01.getNome();
            temp02 = objNomeData02.getDataNascimento() + " " + objNomeData02.getNome();

            // exibição da variavel local
            Console.WriteLine(temp01);
            Console.WriteLine(temp02);
        }
    }
}
