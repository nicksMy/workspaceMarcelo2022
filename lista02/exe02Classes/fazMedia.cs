// Nicolas Schüssler 30/03/2022
namespace exe02Classes
{
    public class FazMedia
    {
        // estados
        private int [] arrValorInt;
        private float mediaPonderada;

        // comportamentos
        public FazMedia () // construtor
        {
            
            arrValorInt = new int [10];
            mediaPonderada = 0;
        }

        // set / get
        // encapsulameto

        // set
        public void setArrValorInt (int i, int a)
        {
            arrValorInt [i] = a;
        }

        public void setMediaPonderada (float m)
        {
            mediaPonderada = m;
        }

        // get
        public int getArrValorInt (int i)
        {
            return arrValorInt [i];
        }

        public double getMediaPonderada ()
        {
            return mediaPonderada;
        }
    }
}