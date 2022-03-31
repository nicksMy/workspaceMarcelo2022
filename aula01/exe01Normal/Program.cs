// Nicolas Schüssler 30/03/2022
using System;

namespace exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataNascimento = new DateTime();

            Console.WriteLine("Digite seu último nome: ");
            string ultimoNome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite sua data de nascimento: \nUse o formato (DD/MM/AAAA HH:MM:SS)");
            dataNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Aqui está sua data de nascimento e seu último nome: ");
            Console.WriteLine("{0} | {1}", dataNascimento, ultimoNome);
        }
    }
}
