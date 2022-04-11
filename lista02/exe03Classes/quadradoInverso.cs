// Nicolas Schüssler 11/04/2022
namespace exe03Classes
{
    public class QuadradoInverso
    {
        // estados
        private float valorEntrada;
        private float resultado;

        // comportamentos
        public QuadradoInverso () // construtor
        {
            valorEntrada = 0;
            resultado = 0;
        }

        // set / get
        // encapsulamento

        // set
        public void setValorEntrada (float v)
        {
            valorEntrada = v;
        }

        public void setResultado (float r)
        {
            resultado = r;
        }

        // get
        public float getValorEntrada ()
        {
            return valorEntrada;
        }

        public float getResultado ()
        {
            return resultado;
        }
    }
}