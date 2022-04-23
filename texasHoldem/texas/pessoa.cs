// Nicolas Schüssler 20/04/2022
namespace texas
{
    public class Pessoa
    {
        // estados
        private string nome;

        public Pessoa (string nomePessoa) // construtor
        {
            nome = nomePessoa;
        }

        // set / get
        // encapsulamento

        // get
        public string getNome ()
        {
            return nome;
        }
    }
}