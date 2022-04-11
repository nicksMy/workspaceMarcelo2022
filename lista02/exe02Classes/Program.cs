// Nicolas Schüssler 30/03/2022
using System;

namespace exe02Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // definição de variavel
            float media = 0;

            // criação do objeto
            FazMedia objFazMedia;
            objFazMedia = new FazMedia();

            // solicitação para usuario inserir os 10 valores
            Console.WriteLine("Digite seus 10 valores inteiros: "); 

            // criação de loop para receber e amarzenar 10 valores inteiros
            for (int i = 0; i < 10; i++)
            {
                // ler e armazenar a entrada
                objFazMedia.setArrValorInt(i, Convert.ToInt32(Console.ReadLine()));

                // soma do resultado e número da posição                
                media += objFazMedia.getArrValorInt(i);
                objFazMedia.setMediaPonderada(media);

                // condição para mostrar o resultado e quebrar o laço de repetição
                if (i == 9)
                {
                    // mostrar mensagem na tela e o resultdado dividido por 10
                    Console.WriteLine("A média do seus valores é: " + objFazMedia.getMediaPonderada()/10);
                    break;
                }
            }
        }
    }
}