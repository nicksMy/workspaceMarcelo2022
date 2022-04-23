// Nicolas Schüssler 20/04/2022
namespace texas
{
    public class Carta
    {
        // estados
        private int valor;
        private int dono;
        private string naipe;

        public Carta (int _valor, int _dono, string _naipe) // construtor
        {
            valor = _valor;
            dono = _dono;
            naipe = _naipe;
        }

        // set / get
        // encapsulamento

        // set
        public void setDono (int d)
        {
            dono = d;
        }

        // get
        public int getValor ()
        {
            return valor;
        }

        public int getDono ()
        {
            return dono;
        }

        public string getNaipe ()
        {
            return naipe;
        }
    }
}