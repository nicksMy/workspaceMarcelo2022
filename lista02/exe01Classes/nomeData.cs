// Nicolas Schüssler 30/03/2022
namespace exe01Classes
{
    public class NomeData
    {
        // estados
        private string ultimoNome;
        private string dataNascimento;

        // comportamentos
        public NomeData() // construtor
        {
            ultimoNome = "";
            dataNascimento = "";
        }

        // set / get
        // encapsulamento

        // set
        public void setNome (string n) 
        {
            ultimoNome = n;
        }

        public void setDataNascimento (string d)
        {
            dataNascimento = d;
        }

        // get
        public string getNome ()
        {
            return ultimoNome;
        }

        public string getDataNascimento ()
        {
            return dataNascimento;
        }
    }
}